using System.Data.SqlClient;

namespace Database;

internal static class Methods
{
    /// <summary>
    /// Add row to specific table in database.
    /// </summary>
    /// <param name="Grid">DataGridView which needs to be updated.</param>
    /// <param name="ExecuteCommand">Stored procedure to be performed.</param>
    internal static void ExecuteCommand(in SqlCommand executeCommand, string message)
    {
        using SqlConnection Connection = new(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=SeaphonServer;");
        executeCommand.Connection = Connection;
        try
        {
            Connection.Open();
        }
        catch
        {
            MessageBox.Show("Нет соединения с базой данных!");
        }

        // I think connection error very rare. No need to checking.
        Console.WriteLine(executeCommand.ExecuteScalar());


        executeCommand.Dispose();
    }
}
