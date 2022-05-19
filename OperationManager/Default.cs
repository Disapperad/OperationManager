using Database;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace OperationManager
{
    public partial class Default : Form
    {
        [DllImport("kernel32")]
        static extern bool AllocConsole();

        public Default()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void Accounts_Search_Click(object sender, EventArgs e)
        {
            SqlParameter[] Parameters = new SqlParameter[4];
            Parameters[0] = Misc.GetSqlParameter(Accounts_Search_ID.Text, "ID");
            Parameters[1] = Misc.GetSqlParameter(Accounts_Search_Account.Text, "AccountID");
            Parameters[2] = Misc.GetSqlParameter(Accounts_Search_FullName.Text, "FullName");

            if ( Accounts_Search_RadioM.Checked )
            {
                Parameters[3] = Misc.GetSqlParameter(Accounts_Search_Cash.Text, "Cash");
            }
            else
            {
                Parameters[3] = Misc.GetSqlParameter(Accounts_Search_Cash.Text, "Cash2");
            }

            Misc.SetGridContent(Grid_Accounts, "SearchAccounts", Parameters);
        }

        private void Accounts_Add_Click(object sender, EventArgs e)
        {
            new Accounts_Add(Grid_Accounts).ShowDialog();
        }

        private void Accounts_Remove_Click(object sender, EventArgs e)
        {
            if (Grid_Accounts.CurrentRow != null)
            {
                SqlParameter[] Parameters =
                {
                    new SqlParameter("@ID", Grid_Accounts.CurrentRow.Cells[0].Value)
                };

                Methods.ExecuteCommand(Misc.GetSqlCommand("RemoveAccount", Parameters), "—чЄт успешно удалЄн!");
            }
        }

        private void Operations_Search_Click(object sender, EventArgs e)
        {
            SqlParameter[] Parameters = new SqlParameter[6];
            Parameters[0] = Misc.GetSqlParameter(Operations_Search_Number.Text, "ID");
            Parameters[1] = Misc.GetSqlParameter(Operations_Search_From.Text, "AccountFrom");
            Parameters[2] = Misc.GetSqlParameter(Operations_Search_To.Text, "AccountTo");
            Console.WriteLine(Operations_Search_Date.Text);

            if (Operations_CheckBox.Checked)
            {
                SqlParameter CurrentDate = Misc.GetSqlParameter(Operations_Search_Date.Text, "OperationDate");
                CurrentDate.DbType = System.Data.DbType.Date;
                Parameters[3] = CurrentDate;

                SqlParameter CurrentTime = Misc.GetSqlParameter(Operations_Search_Date2.Text, "OperationDate2");
                CurrentTime.DbType = System.Data.DbType.Date;
                Parameters[4] = CurrentTime;
            }

            if (Operations_RadioB.Checked)
            {
                Parameters[5] = Misc.GetSqlParameter(Operations_Search_Cash.Text, "Cash");
            }
            else
            {
                Parameters[5] = Misc.GetSqlParameter(Operations_Search_Cash.Text, "Cash2");
            }

            Misc.SetGridContent(Grid_Operations, "SearchOperations", Parameters);
        }

        private void Operations_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Operations_Search_Date.Enabled = Operations_CheckBox.Checked;
            Operations_Search_Date2.Enabled = Operations_CheckBox.Checked;
        }

        private void Operations_Button_Add_Click(object sender, EventArgs e)
        {

        }
    }
}