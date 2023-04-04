namespace CentralDustBin
{
    partial class MainPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis2 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis2 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis3 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis3 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis4 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis4 = new Telerik.WinControls.UI.LinearAxis();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.DGV_Client = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LB_NoIntenet = new System.Windows.Forms.Label();
            this.PNL_Estimation = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_BinPercentage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BGW_GetData = new System.ComponentModel.BackgroundWorker();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BT_EstimationView = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BT_FrequenceView = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PGB_Remplisage = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Client)).BeginInit();
            this.panel3.SuspendLayout();
            this.PNL_Estimation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(657, 681);
            this.panel4.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gMapControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGV_Client);
            this.splitContainer1.Size = new System.Drawing.Size(657, 681);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.TabIndex = 0;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(657, 534);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // DGV_Client
            // 
            this.DGV_Client.AllowUserToAddRows = false;
            this.DGV_Client.AllowUserToDeleteRows = false;
            this.DGV_Client.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Client.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column2});
            this.DGV_Client.GridColor = System.Drawing.Color.White;
            this.DGV_Client.Location = new System.Drawing.Point(6, 3);
            this.DGV_Client.MultiSelect = false;
            this.DGV_Client.Name = "DGV_Client";
            this.DGV_Client.RowHeadersVisible = false;
            this.DGV_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Client.Size = new System.Drawing.Size(645, 137);
            this.DGV_Client.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LB_NoIntenet);
            this.panel3.Controls.Add(this.PNL_Estimation);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.radChartView1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.BT_EstimationView);
            this.panel3.Controls.Add(this.BT_FrequenceView);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.bunifuSeparator4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.LB_BinPercentage);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.bunifuSeparator2);
            this.panel3.Controls.Add(this.PGB_Remplisage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(657, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 681);
            this.panel3.TabIndex = 4;
            // 
            // LB_NoIntenet
            // 
            this.LB_NoIntenet.AutoSize = true;
            this.LB_NoIntenet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.LB_NoIntenet.ForeColor = System.Drawing.Color.Red;
            this.LB_NoIntenet.Location = new System.Drawing.Point(11, 3);
            this.LB_NoIntenet.Name = "LB_NoIntenet";
            this.LB_NoIntenet.Size = new System.Drawing.Size(151, 20);
            this.LB_NoIntenet.TabIndex = 22;
            this.LB_NoIntenet.Text = "Aucun accès internet";
            this.LB_NoIntenet.Visible = false;
            // 
            // PNL_Estimation
            // 
            this.PNL_Estimation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Estimation.Controls.Add(this.DGV);
            this.PNL_Estimation.Controls.Add(this.label11);
            this.PNL_Estimation.Location = new System.Drawing.Point(15, 432);
            this.PNL_Estimation.Name = "PNL_Estimation";
            this.PNL_Estimation.Size = new System.Drawing.Size(402, 237);
            this.PNL_Estimation.TabIndex = 20;
            this.PNL_Estimation.Visible = false;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column10});
            this.DGV.GridColor = System.Drawing.Color.White;
            this.DGV.Location = new System.Drawing.Point(10, 64);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(385, 170);
            this.DGV.TabIndex = 36;
            // 
            // Column9
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.FillWeight = 86.41192F;
            this.Column9.HeaderText = "Temps";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Niveau Restant";
            this.Column1.Name = "Column1";
            // 
            // Column10
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Column10.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column10.FillWeight = 86.41192F;
            this.Column10.HeaderText = "Niveau Remplis";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(375, 48);
            this.label11.TabIndex = 15;
            this.label11.Text = "Estimation du prochain remplissage de la poubelle QST-201 dans +/- 12 jours (le 2" +
    "1/03/2022)";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(332, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Niv Restant";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(228, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Niv Remplis";
            // 
            // radChartView1
            // 
            this.radChartView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radChartView1.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.TickOrigin = null;
            categoricalAxis2.IsPrimary = true;
            linearAxis2.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis2.IsPrimary = true;
            linearAxis2.MajorStep = 5D;
            linearAxis2.TickOrigin = null;
            categoricalAxis3.IsPrimary = true;
            linearAxis3.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis3.IsPrimary = true;
            linearAxis3.TickOrigin = null;
            categoricalAxis4.IsPrimary = true;
            linearAxis4.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis4.IsPrimary = true;
            linearAxis4.TickOrigin = null;
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1,
            categoricalAxis2,
            linearAxis2,
            categoricalAxis3,
            linearAxis3,
            categoricalAxis4,
            linearAxis4});
            this.radChartView1.Location = new System.Drawing.Point(22, 452);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(381, 217);
            this.radChartView1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Analyse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(87)))), ((int)(((byte)(194)))));
            this.label7.Location = new System.Drawing.Point(92, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "(2)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Remplisage";
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(19, 351);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(391, 10);
            this.bunifuSeparator4.TabIndex = 3;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(79, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ken Kabange Mwepu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(79, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Particulier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(53, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Q\\Golf Plateau Av\\Lusonde 2628";
            // 
            // LB_BinPercentage
            // 
            this.LB_BinPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_BinPercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BinPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(68)))));
            this.LB_BinPercentage.Location = new System.Drawing.Point(289, 201);
            this.LB_BinPercentage.Name = "LB_BinPercentage";
            this.LB_BinPercentage.Size = new System.Drawing.Size(88, 46);
            this.LB_BinPercentage.TabIndex = 3;
            this.LB_BinPercentage.Text = "0";
            this.LB_BinPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "QST-201";
            // 
            // BGW_GetData
            // 
            this.BGW_GetData.WorkerReportsProgress = true;
            this.BGW_GetData.WorkerSupportsCancellation = true;
            this.BGW_GetData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_GetData_DoWork);
            this.BGW_GetData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGW_GetData_ProgressChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pictureBox6.Location = new System.Drawing.Point(316, 432);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pictureBox5.Location = new System.Drawing.Point(207, 432);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // BT_EstimationView
            // 
            this.BT_EstimationView.ActiveBorderThickness = 1;
            this.BT_EstimationView.ActiveCornerRadius = 20;
            this.BT_EstimationView.ActiveFillColor = System.Drawing.Color.White;
            this.BT_EstimationView.ActiveForecolor = System.Drawing.Color.Black;
            this.BT_EstimationView.ActiveLineColor = System.Drawing.Color.Black;
            this.BT_EstimationView.BackColor = System.Drawing.Color.White;
            this.BT_EstimationView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_EstimationView.BackgroundImage")));
            this.BT_EstimationView.ButtonText = "Estimation";
            this.BT_EstimationView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_EstimationView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EstimationView.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_EstimationView.IdleBorderThickness = 1;
            this.BT_EstimationView.IdleCornerRadius = 20;
            this.BT_EstimationView.IdleFillColor = System.Drawing.Color.White;
            this.BT_EstimationView.IdleForecolor = System.Drawing.Color.Black;
            this.BT_EstimationView.IdleLineColor = System.Drawing.Color.Silver;
            this.BT_EstimationView.Location = new System.Drawing.Point(150, 386);
            this.BT_EstimationView.Margin = new System.Windows.Forms.Padding(5);
            this.BT_EstimationView.Name = "BT_EstimationView";
            this.BT_EstimationView.Size = new System.Drawing.Size(125, 41);
            this.BT_EstimationView.TabIndex = 12;
            this.BT_EstimationView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_EstimationView.Click += new System.EventHandler(this.BT_EstimationView_Click);
            // 
            // BT_FrequenceView
            // 
            this.BT_FrequenceView.ActiveBorderThickness = 1;
            this.BT_FrequenceView.ActiveCornerRadius = 20;
            this.BT_FrequenceView.ActiveFillColor = System.Drawing.Color.White;
            this.BT_FrequenceView.ActiveForecolor = System.Drawing.Color.Black;
            this.BT_FrequenceView.ActiveLineColor = System.Drawing.Color.Black;
            this.BT_FrequenceView.BackColor = System.Drawing.Color.White;
            this.BT_FrequenceView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_FrequenceView.BackgroundImage")));
            this.BT_FrequenceView.ButtonText = "Fréquence";
            this.BT_FrequenceView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_FrequenceView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_FrequenceView.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_FrequenceView.IdleBorderThickness = 1;
            this.BT_FrequenceView.IdleCornerRadius = 20;
            this.BT_FrequenceView.IdleFillColor = System.Drawing.Color.White;
            this.BT_FrequenceView.IdleForecolor = System.Drawing.Color.Black;
            this.BT_FrequenceView.IdleLineColor = System.Drawing.Color.Silver;
            this.BT_FrequenceView.Location = new System.Drawing.Point(22, 386);
            this.BT_FrequenceView.Margin = new System.Windows.Forms.Padding(5);
            this.BT_FrequenceView.Name = "BT_FrequenceView";
            this.BT_FrequenceView.Size = new System.Drawing.Size(125, 41);
            this.BT_FrequenceView.TabIndex = 11;
            this.BT_FrequenceView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_FrequenceView.Click += new System.EventHandler(this.BT_FrequenceView_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CentralDustBin.Properties.Resources._B0E6B82C_8354_4A2E_AAD8_0D8F8866858D__png;
            this.pictureBox4.Location = new System.Drawing.Point(26, 298);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CentralDustBin.Properties.Resources.marker_50px;
            this.pictureBox3.Location = new System.Drawing.Point(26, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::CentralDustBin.Properties.Resources.filled_trash_50px;
            this.pictureBox2.Location = new System.Drawing.Point(383, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PGB_Remplisage
            // 
            this.PGB_Remplisage.animated = false;
            this.PGB_Remplisage.animationIterval = 5;
            this.PGB_Remplisage.animationSpeed = 300;
            this.PGB_Remplisage.BackColor = System.Drawing.Color.White;
            this.PGB_Remplisage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PGB_Remplisage.BackgroundImage")));
            this.PGB_Remplisage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.PGB_Remplisage.ForeColor = System.Drawing.Color.SeaGreen;
            this.PGB_Remplisage.LabelVisible = true;
            this.PGB_Remplisage.LineProgressThickness = 8;
            this.PGB_Remplisage.LineThickness = 5;
            this.PGB_Remplisage.Location = new System.Drawing.Point(112, 2);
            this.PGB_Remplisage.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PGB_Remplisage.MaxValue = 100;
            this.PGB_Remplisage.Name = "PGB_Remplisage";
            this.PGB_Remplisage.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.PGB_Remplisage.ProgressColor = System.Drawing.Color.SeaGreen;
            this.PGB_Remplisage.Size = new System.Drawing.Size(230, 230);
            this.PGB_Remplisage.TabIndex = 21;
            this.PGB_Remplisage.Value = 0;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, -4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(10, 682);
            this.bunifuSeparator2.TabIndex = 0;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.FillWeight = 86.41192F;
            this.dataGridViewTextBoxColumn1.HeaderText = "NOM DU CLIENT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ADRESSE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CODE POUBELLE";
            this.Column2.Name = "Column2";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1079, 681);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Client)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PNL_Estimation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.DataGridView DGV_Client;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LB_NoIntenet;
        private System.Windows.Forms.Panel PNL_Estimation;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_EstimationView;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_FrequenceView;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LB_BinPercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar PGB_Remplisage;
        private System.ComponentModel.BackgroundWorker BGW_GetData;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
