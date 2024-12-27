using Dapper;
using MySql.Data.MySqlClient;

namespace EventHub;

public class DataService
{
    private static string connectionString = "Server=localhost;Database=eventhub;Uid=root;Pwd=CST8250!;";
    public static async Task<List<T>> LoadData<T, U>(string sql, U parameters)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            var rows = await conn.QueryAsync<T>(sql, parameters);
            return rows.ToList();
        }
    }

    public static async Task<int> SaveData<U>(string sql, U parameters)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            return await conn.ExecuteAsync(sql, parameters);
        }
    }
}
