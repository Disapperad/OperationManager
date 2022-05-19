using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Database;

internal static class Misc
{
    public static SqlParameter GetSqlParameter(string Value, string Name)
    {
        return new SqlParameter("@"+Name, Value != "" ? Value : DBNull.Value);
    }

    public static void SetGridContent(in DataGridView Grid, in string CommandText, in SqlParameter[]? ParameterList = null)
    {
        Grid.Rows.Clear();

        using SqlConnection Connection = new(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=SeaphonServer;");

        SqlCommand CurrentCommand;

        CurrentCommand = GetSqlCommand(CommandText, ParameterList);

        CurrentCommand.Connection = Connection;

        Connection.Open();

        using SqlDataReader Reader = CurrentCommand.ExecuteReader();

        while (Reader.Read())
        {
            int RowIndex = Grid.Rows.Add();

            for (int i = 0; i < Reader.FieldCount; i++)
            {
                Grid.Rows[RowIndex].Cells[i].Value = Reader.GetValue(i);
            }
        }
    }

    internal static SqlCommand GetSqlCommand(in string procedureName, params SqlParameter[]? sqlParameters)
    {
        SqlCommand MainCommand = new()
        {
            CommandText = procedureName,
            CommandType = System.Data.CommandType.StoredProcedure
        };

        if (sqlParameters != null)
        {
            foreach (SqlParameter SqlParameter in sqlParameters)
            {
                if (SqlParameter != null)
                {
                    MainCommand.Parameters.Add(SqlParameter);
                }
            }

        }

        return MainCommand;
    }
}
