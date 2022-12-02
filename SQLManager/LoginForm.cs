using SQLManager.Dal;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                RepositoryFactory.GetRepository().Login(tbServerName.Text.Trim(), tbLogin.Text.Trim(), tbPassword.Text.Trim());
                new SQLManager().Show();
                Hide();
            }
            catch (Exception ex)
            {

                lbErrorMessage.Text = ex.Message;
            }
        }
    }
}
