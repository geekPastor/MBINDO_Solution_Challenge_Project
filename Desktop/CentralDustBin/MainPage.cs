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
    public partial class MainPage : UserControl
    {
        private IFirebaseClient client;
        private double lastValue;
        private List<Client> AllClients;

        private IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "8Va7nCZh5mZhma1wwdYH4i7ns7hgtlJ1rwLZkNuk",
            BasePath = "https://dustbinbase-default-rtdb.firebaseio.com/"
        };

        #region Methodes
        private void LoadMarker(PointLatLng point)
        {
            LoadMap(point);
            AddMarker(point);
        }

        private void LoadMap(PointLatLng point)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;

            gMapControl1.Position = point;

            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 17;
        }

        private void AddMarker(PointLatLng point)
        {
            Bitmap bmpMarker = (Bitmap)Image.FromFile(@"empty_trash_50px.png");
            Bitmap bmpMarker2 = (Bitmap)Image.FromFile(@"icons8_empty_trash_50px.png");
            GMarkerGoogleType markerType = GMarkerGoogleType.green;

            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(point, bmpMarker);

            var marker2 = new GMarkerGoogle(new PointLatLng(-11.630647719235435, 27.478682152429663), bmpMarker2);
            var marker3 = new GMarkerGoogle(new PointLatLng(-11.67506, 27.47676), bmpMarker2);

            marker.ToolTipText = "QST-201\nMr. Ken Mwepu\nQ\\Makomeno";
            marker.ToolTipText = "QST-203\nMr. Blaise Kamwadi\nQ\\Golf Plateau";
            marker.ToolTipText = "QST-100\nMme. Santa\nQ\\Kalubwe";


            markers.Markers.Add(marker);
            markers.Markers.Add(marker2);
            markers.Markers.Add(marker3);
            gMapControl1.Overlays.Add(markers);
        }

        private void DrawGraphic(DataGridView dgv)
        {
            radChartView1.Series.Clear();

            DataSet set = new DataSet();

            DataTable levelTable = new DataTable("Niveau");
            DataTable ResteTable = new DataTable("Reste");

            set.Tables.Add(levelTable);
            set.Tables.Add(ResteTable);

            foreach (DataTable table in set.Tables)
            {
                table.Columns.Add("Temps");
                table.Columns.Add("Valeur", typeof(double));
            }

            for (int i = 0; i < dgv.RowCount; i++)
            {
                levelTable.Rows.Add(dgv.Rows[i].Cells[0].Value, dgv.Rows[i].Cells[2].Value);
                ResteTable.Rows.Add(dgv.Rows[i].Cells[0].Value, dgv.Rows[i].Cells[1].Value);
            }

            radChartView1.DataSource = set;

            BarSeries NiveauSeries = new BarSeries("Valeur", "Temps");
            NiveauSeries.DataMember = "Niveau";
            NiveauSeries.LegendTitle = "Niveau";
            BarSeries ResteSeries = new BarSeries("Valeur", "Temps");
            ResteSeries.DataMember = "Reste";
            ResteSeries.LegendTitle = "Reste";

            radChartView1.Series.AddRange(NiveauSeries, ResteSeries);
        }
        #endregion

        public MainPage()
        {
            InitializeComponent();
            client = new FirebaseClient(ifc);

            AllClients = new List<Client>()
            {
                new Client(){Name = "Ken Mwepu", Adrress = @"Q\Makomeno Av\Zilo 12", CodePoubelle = "QST-201"},
                new Client(){Name = "Blaise Kamwadi", Adrress = @"Q\Golf Plateau Av\Lusonde 2628", CodePoubelle = "PST-454"},
                new Client(){Name = "Santa", Adrress = @"Q\Kalubwe", CodePoubelle = "QST-23"},
                new Client(){Name = "Michou", Adrress = @"Q\Kalubwe", CodePoubelle = "PST-344"},
                new Client(){Name = "Sylvain", Adrress = @"Q\Kalubwe", CodePoubelle = "QST-3"},
                new Client(){Name = "Joyce", Adrress = @"Q\Kalubwe", CodePoubelle = "QST-202"}
            };
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadMarker(new PointLatLng(-11.62882974, 27.48385781));

            foreach (var item in AllClients)
            {
                DGV_Client.Rows.Add(item.Name, item.Adrress, item.CodePoubelle);
            }

            lastValue = 0;
            BGW_GetData.RunWorkerAsync();
        }

        private void BGW_GetData_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = BGW_GetData;
            int cmpt = 0;

            while (bgw.CancellationPending == false)
            {
                try
                {
                    FirebaseResponse resp = client.Get(@"/dustbinbase-default-rtdb/Poubelle/-N4xMkhxKTPNgU-ORPUn/");
                    Poubelle data = JsonConvert.DeserializeObject<Poubelle>(resp.Body.ToString());

                    bgw.ReportProgress(cmpt, data);
                    cmpt++;

                    if (cmpt == 20)
                        cmpt = 0;

                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
                catch (Exception)
                {
                    bgw.ReportProgress(-1);
                }

            }
        }

        private void BGW_GetData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == -1)
            {
                LB_NoIntenet.Visible = true;
                return;
            }

            LB_NoIntenet.Visible = false;

            Poubelle selectedPoubelle = (Poubelle)e.UserState;

            if (lastValue == selectedPoubelle.Niveau || selectedPoubelle.Niveau < 0)
                return;

            if (selectedPoubelle.Niveau > selectedPoubelle.Capacity)
            {
                PGB_Remplisage.Value = 100;
                LB_BinPercentage.Text = "100%";
                PGB_Remplisage.ProgressColor = Color.Red;
                return;
            }

            if (e.ProgressPercentage == 0)
                DGV.Rows.Clear();

            DGV.Rows.Add(DateTime.Now.ToString(CultureInfo.GetCultureInfo("fr-FR").DateTimeFormat.LongTimePattern), selectedPoubelle.Niveau, selectedPoubelle.Capacity - selectedPoubelle.Niveau);
            lastValue = selectedPoubelle.Niveau;

            PGB_Remplisage.Value = (int)Math.Round(((selectedPoubelle.Capacity - selectedPoubelle.Niveau) / selectedPoubelle.Capacity) * 100);
            LB_BinPercentage.Text = $"{PGB_Remplisage.Value}%";

            if (PGB_Remplisage.Value >= 0 && PGB_Remplisage.Value <= 40)
                PGB_Remplisage.ProgressColor = Color.SeaGreen;
            else if (PGB_Remplisage.Value >= 41 && PGB_Remplisage.Value <= 75)
                PGB_Remplisage.ProgressColor = Color.Gold;
            else
                PGB_Remplisage.ProgressColor = Color.Red;

            DrawGraphic(DGV);
        }

        private void BT_FrequenceView_Click(object sender, EventArgs e) => PNL_Estimation.Visible = false;

        private void BT_EstimationView_Click(object sender, EventArgs e) => PNL_Estimation.Visible = true;
    }
}
