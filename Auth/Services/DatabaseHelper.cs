using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient; // Gunakan namespace ini, bukan Microsoft.Data.SqlClient
using System;
using System.Data;

namespace Auth.Services
{
    public static class DatabaseHelper
    {
        // Connection String MySQL Laragon
        private static readonly string ConnectionString =
            "Server=127.0.0.1;Port=3306;Database=AuthDb;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static bool TestConnection(out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public static DataTable ExecuteQuery(string query, MySqlParameter[]? parameters = null)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query, MySqlParameter[]? parameters = null)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object? ExecuteScalar(string query, MySqlParameter[]? parameters = null)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}