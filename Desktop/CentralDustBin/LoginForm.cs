using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralDustBin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BT_Close_Click(object sender, EventArgs e) => this.Close();

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (TXB_UserName.Text == "Ken" && TXB_PassWord.Text == "1234")
            {
                this.Visible = false;
                new DashboardForm(this).ShowDialog();
            }
            else
                MessageBox.Show("Le nom d'utilisateur ou le mot de passe ne pas valide, veulliez réssayer", "ERREUR D'ACCES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
