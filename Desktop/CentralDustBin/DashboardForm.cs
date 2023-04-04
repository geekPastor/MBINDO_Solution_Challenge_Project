using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using FireSharp.Config;
using Newtonsoft.Json;
using CentralDustBin.Models;
using System.Globalization;

namespace CentralDustBin
{
    public partial class DashboardForm : Form
    {
        private LoginForm LoginPageInstance;
        

        public DashboardForm(LoginForm instanceLoginPage)
        {
            InitializeComponent();

            LoginPageInstance = instanceLoginPage;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            PNL_Content.Controls.Add(new MainPage() { Dock = DockStyle.Fill });
        }

        private void FermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPageInstance.Visible = true;
            this.Close();
        }

        private void RedimensionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            PNL_Content.Controls.Clear();
            PNL_Content.Controls.Add(new MainPage() { Dock = DockStyle.Fill });
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            PNL_Content.Controls.Clear();
            PNL_Content.Controls.Add(new DriversManager() { Dock = DockStyle.Fill });
        }
    }
}
