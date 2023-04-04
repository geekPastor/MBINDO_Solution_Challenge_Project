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
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralDustBin.Models;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using FireSharp.Config;
using Newtonsoft.Json;

namespace CentralDustBin
{
    public partial class Form1 : Form
    {
        private IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "8Va7nCZh5mZhma1wwdYH4i7ns7hgtlJ1rwLZkNuk",
            BasePath = "https://dustbinbase-default-rtdb.firebaseio.com/"
        };

        private IFirebaseClient client;

        private Poubelle Oldpoubelles;

        public Form1()
        {
            InitializeComponent();

            try
            {
                client = new FirebaseClient(ifc);
            }
            catch (Exception)
            {
                MessageBox.Show("Impos");
            }
        }

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
            gMapControl1.Zoom = 20;
        }

        private void AddMarker(PointLatLng point)
        {
            Bitmap bmpMarker = (Bitmap)Image.FromFile(@"C:\Users\Ken Mwepu\Documents\Application Documentation\DustBinProject\images\empty_trash_50px.png");
            GMarkerGoogleType markerType = GMarkerGoogleType.green;

            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(point, bmpMarker);

            marker.ToolTipText = "PB001\nMr. Marcus\nQ\\Makomeno";
            

            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMarker(new PointLatLng(-11.67506, 27.47676));

            //BGW_loadMaps.RunWorkerAsync();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var point = new PointLatLng(Oldpoubelles.lat, Oldpoubelles.longt);
            LoadMarker(point);

            GeoCoderStatusCode statusCode;
            var placeMarker = GoogleMapProvider.Instance.GetPlacemark(point, out statusCode);

            if (statusCode == GeoCoderStatusCode.OK)
                MessageBox.Show(placeMarker?.Address);
            else
                MessageBox.Show("");
        }

        private void BGW_loadMaps_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = BGW_loadMaps;

            while (!bgw.CancellationPending)
            {
                try
                {
                    FirebaseResponse resp = client.Get(@"/dustbinbase-default-rtdb/Poubelle/-N4xMkhxKTPNgU-ORPUn/");
                    Poubelle data = JsonConvert.DeserializeObject<Poubelle>(resp.Body.ToString());

                    bgw.ReportProgress(1, data);

                    Task.Delay(1000);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de connextion !");
                }
            }
        }

        private void BGW_loadMaps_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Poubelle poubelle = (Poubelle)e.UserState;

            if (Oldpoubelles == null && poubelle != null)
            {
                LoadMarker(new PointLatLng(poubelle.lat, poubelle.longt));
                Oldpoubelles = poubelle;
                textBox1.Text = poubelle.Niveau.ToString();
            }

            if (poubelle != null)
            {
                if (Oldpoubelles.Niveau != poubelle.Niveau)
                {
                    textBox1.Text = poubelle.Niveau.ToString();
                    Oldpoubelles = poubelle;
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
