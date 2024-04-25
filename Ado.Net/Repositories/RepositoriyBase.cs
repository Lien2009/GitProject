
using Domain;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Repositories
{
    public abstract class RepositoryBase
    {


        public SqlConnection GetConnection()
        {
            var sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder["Server"] = ".\\sqlexpress";
            sqlStringBuilder["Database"] = "AdoTest";
            sqlStringBuilder["Integrated Security"] = true;
            var sqlStringConnection = sqlStringBuilder.ToString();
            Console.WriteLine(sqlStringConnection);
            var connection = new SqlConnection(sqlStringConnection);
            return connection;
        }
        public async Task<T?> GetAsync<T>(string sql, string propertyName, string value) where T : new()
        {
            T result = new();
            using (SqlConnection connection =this.GetConnection())
            {
                await connection.OpenAsync();
                var adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql, connection);

                if (!string.IsNullOrEmpty(value))
                {
                    command.Parameters.AddWithValue($"@{propertyName}", value);
                }
                else
                {
                    return default(T);
                }

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        var properties = typeof(T).GetProperties();
                        foreach(var property in properties)
                        {
                            property.SetValue(result, reader[property.Name].ToString());
                        }
                        return result;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }
    }
}
