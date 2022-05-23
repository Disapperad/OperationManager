using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationManager
{
    public partial class Operations_Add : Form
    {
        public Operations_Add()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            SqlParameter[] Parameters =
            {
                 new SqlParameter("@AccountFrom", TextBox_From.Text),
                 new SqlParameter("@AccountTo", TextBox_To.Text),
                 new SqlParameter("@Cash", TextBox_Cash.Text)
            };

            Methods.ExecuteCommand(Misc.GetSqlCommand("ExecuteOperation", Parameters), "Операция выполнена");
        }
    }
}
