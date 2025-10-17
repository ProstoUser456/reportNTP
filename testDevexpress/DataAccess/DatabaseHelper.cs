using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["LuciaAnalyze"].ConnectionString;
    }

    // Публичное свойство для доступа из формы
    public string ConnectionString => _connectionString;

    /// <summary>
    /// Возвращает новый объект SqlConnection, подключенный к базе.
    /// </summary>
    public SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }

    /// <summary>
    /// Выполняет хранимую процедуру и возвращает результат в DataTable.
    /// </summary>
    public DataTable ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters)
    {
        DataTable dt = new DataTable();
        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(procedureName, conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }
        }
        return dt;
    }
}
