using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SistemaCRUD.Core
{
    public class DBComponent
    {
        private readonly string _connectionString;
        private readonly Dictionary<string, Dictionary<string, string>> _queries;

        public DBComponent()
        {
            try
            {
                // 1. Intento encontrar config.json en el directorio de ejecuci�n
                var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

                // 2. Si no est� ah�, busco en el directorio del proyecto (para desarrollo)
                if (!File.Exists(configPath))
                {
                    var projectDir = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;
                    if (!string.IsNullOrEmpty(projectDir))
                        configPath = Path.Combine(projectDir, "config.json");
                }

                // 3. Si todav�a no lo encuentro, lanzo excepci�n con ambas rutas y sugerencia
                if (!File.Exists(configPath))
                {
                    var errorMessage = $"No se pudo encontrar config.json en:\n" +
                                       $"1. {AppDomain.CurrentDomain.BaseDirectory}\n" +
                                       $"2. {Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName}\n\n" +
                                       $"Soluci�n: Aseg�rate de que el archivo config.json exista y est� configurado para copiarse al directorio de salida (Propiedades > Copiar al directorio de salida).";
                    throw new FileNotFoundException(errorMessage);
                }

                // Cargar configuraci�n
                var configJson = File.ReadAllText(configPath);
                var config = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(configJson);
                var dbConfig = config["DatabaseConfig"];

                _connectionString = $"Server={dbConfig.GetProperty("Server").GetString()};" +
                                   $"Port={dbConfig.GetProperty("Port").GetString()};" +
                                   $"Database={dbConfig.GetProperty("Database").GetString()};" +
                                   $"User Id={dbConfig.GetProperty("UserId").GetString()};" +
                                   $"Password={dbConfig.GetProperty("Password").GetString()};";

                // Mismo proceso para queries.json
                var queriesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "queries.json");

                if (!File.Exists(queriesPath))
                {
                    var projectDir = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;
                    if (!string.IsNullOrEmpty(projectDir))
                        queriesPath = Path.Combine(projectDir, "queries.json");
                }

                if (!File.Exists(queriesPath))
                {
                    var errorMessage = $"No se pudo encontrar queries.json en:\n" +
                                       $"1. {AppDomain.CurrentDomain.BaseDirectory}\n" +
                                       $"2. {Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName}\n\n" +
                                       $"Soluci�n: Aseg�rate de que el archivo queries.json exista y est� configurado para copiarse al directorio de salida (Propiedades > Copiar al directorio de salida).";
                    throw new FileNotFoundException(errorMessage);
                }

                var queriesJson = File.ReadAllText(queriesPath);
                _queries = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(queriesJson);
            }
            catch (FileNotFoundException ex)
            {
                throw new InvalidOperationException("Error: Archivo de configuraci�n no encontrado. " + ex.Message, ex);
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException("Error: Formato JSON inv�lido en archivo de configuraci�n.", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error inesperado al cargar configuraci�n.", ex);
            }
        }

        public IEnumerable<T> Query<T>(string entity, string operation, object parameters = null)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    if (_queries.TryGetValue(entity, out var entityQueries))
                    {
                        if (entityQueries.TryGetValue(operation, out var query))
                        {
                            return conn.Query<T>(query, parameters);
                        }
                        throw new KeyNotFoundException($"Operaci�n '{operation}' no encontrada para la entidad '{entity}'");
                    }
                    throw new KeyNotFoundException($"Entidad '{entity}' no encontrada en queries");
                }
                catch (NpgsqlException ex)
                {
                    throw new Exception($"Error de PostgreSQL al ejecutar consulta: {entity}/{operation}", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al ejecutar consulta: {entity}/{operation}", ex);
                }
            }
        }

        public int Execute(string entity, string operation, object parameters)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    if (_queries.TryGetValue(entity, out var entityQueries))
                    {
                        if (entityQueries.TryGetValue(operation, out var query))
                        {
                            return conn.Execute(query, parameters);
                        }
                        throw new KeyNotFoundException($"Operaci�n '{operation}' no encontrada para la entidad '{entity}'");
                    }
                    throw new KeyNotFoundException($"Entidad '{entity}' no encontrada en queries");
                }
                catch (NpgsqlException ex)
                {
                    throw new Exception($"Error de PostgreSQL al ejecutar comando: {entity}/{operation}", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al ejecutar comando: {entity}/{operation}", ex);
                }
            }
        }

        public T ExecuteScalar<T>(string entity, string operation, object parameters)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    if (_queries.TryGetValue(entity, out var entityQueries))
                    {
                        if (entityQueries.TryGetValue(operation, out var query))
                        {
                            return conn.ExecuteScalar<T>(query, parameters);
                        }
                        throw new KeyNotFoundException($"Operaci�n '{operation}' no encontrada para la entidad '{entity}'");
                    }
                    throw new KeyNotFoundException($"Entidad '{entity}' no encontrada en queries");
                }
                catch (NpgsqlException ex)
                {
                    throw new Exception($"Error de PostgreSQL al ejecutar ExecuteScalar: {entity}/{operation}", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al ejecutar ExecuteScalar: {entity}/{operation}", ex);
                }
            }
        }
    }
}