using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OperationManager
{
    public partial class Accounts_Add : Form
    {
        DataGridView _grid;

        public Accounts_Add(DataGridView mainGrid)
        {
            InitializeComponent();
            _grid = mainGrid;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] Parameters = new SqlParameter[1];
            Parameters[0] = Misc.GetSqlParameter(AccountID.Text, "AccountID");
            
            Methods.ExecuteCommand(Misc.GetSqlCommand("AddAccount", Parameters), "Запись успешно добавлена!");

            Misc.SetGridContent(_grid, "SearchAccounts");
        }
    }
}
