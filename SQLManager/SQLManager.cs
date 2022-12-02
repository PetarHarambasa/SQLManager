using SQLManager.Dal;
using SQLManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLManager
{
    public partial class SQLManager : Form
    {
        public SQLManager()
        {
            InitializeComponent();
        }

        private void SQLManager_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tbQueryText.Text = string.Empty;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                SqlQueryResultMessage sqlQueryResultMessage = RepositoryFactory.GetRepository().ExecuteInsertedQuery(cbDatabases.Text, tbQueryText.Text);
                tbMessage.ReadOnly = true;
                tbMessage.Text = sqlQueryResultMessage.RecordsAffected < 0 ?
                    $"Commands completed successfully.\r\nCompletion time: {sqlQueryResultMessage.CompletionTime}" :
                    $"Commands completed successfully.\r\n({sqlQueryResultMessage.RecordsAffected} row/s affected)" +
                    $"\r\nCompletion time: {sqlQueryResultMessage.CompletionTime}";

                dgvResult.DataSource = sqlQueryResultMessage.Table;

                lbQuerryStatus.Text = "✔Query executed successfully.";
                lbQuerryStatus.BackColor = Color.LightGreen;
                LoadDatabases();
            }
            catch (Exception ex)
            {
                tbMessage.ReadOnly = false;
                tbMessage.ForeColor = Color.Red;
                tbMessage.Text = ex.Message;
                lbQuerryStatus.Text = "⚠Query completed with errors.";
                lbQuerryStatus.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void LoadDatabases()
        {
            cbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
        }

        private void SQLManager_Load(object sender, EventArgs e)
        {
            LoadDatabases();
        }
    }
}
