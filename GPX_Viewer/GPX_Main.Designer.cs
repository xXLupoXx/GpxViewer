namespace GPX_Viewer
{
    partial class GPX_Viewer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPX_Viewer));
            this.Head_Menue = new System.Windows.Forms.MenuStrip();
            this.datenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordnerImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenbankExportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_show_waypoints = new System.Windows.Forms.Button();
            this.dlg_einzelne_Datei = new System.Windows.Forms.OpenFileDialog();
            this.dlg_export = new System.Windows.Forms.SaveFileDialog();
            this.dlg_browse_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.lv_Tracks = new System.Windows.Forms.ListView();
            this.clh_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbx_suchen_Tracks = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_tracks = new System.Windows.Forms.TabPage();
            this.lbl_suchen_tracks = new System.Windows.Forms.Label();
            this.tp_waypoints = new System.Windows.Forms.TabPage();
            this.lbl_suchen_way = new System.Windows.Forms.Label();
            this.lv_waypoints = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbx_suchen_waypoints = new System.Windows.Forms.TextBox();
            this.lbl_wip = new System.Windows.Forms.Label();
            this.Head_Menue.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_tracks.SuspendLayout();
            this.tp_waypoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // Head_Menue
            // 
            this.Head_Menue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenToolStripMenuItem,
            this.toolStripMenuItem1});
            this.Head_Menue.Location = new System.Drawing.Point(0, 0);
            this.Head_Menue.Name = "Head_Menue";
            this.Head_Menue.Size = new System.Drawing.Size(470, 24);
            this.Head_Menue.TabIndex = 1;
            this.Head_Menue.Text = "menuStrip1";
            // 
            // datenToolStripMenuItem
            // 
            this.datenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importierenToolStripMenuItem,
            this.ordnerImportierenToolStripMenuItem,
            this.datenbankExportierenToolStripMenuItem});
            this.datenToolStripMenuItem.Name = "datenToolStripMenuItem";
            this.datenToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.datenToolStripMenuItem.Text = "Daten";
            // 
            // importierenToolStripMenuItem
            // 
            this.importierenToolStripMenuItem.Name = "importierenToolStripMenuItem";
            this.importierenToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.importierenToolStripMenuItem.Text = "Einzelne Datai Importieren";
            this.importierenToolStripMenuItem.Click += new System.EventHandler(this.importierenToolStripMenuItem_Click);
            // 
            // ordnerImportierenToolStripMenuItem
            // 
            this.ordnerImportierenToolStripMenuItem.Name = "ordnerImportierenToolStripMenuItem";
            this.ordnerImportierenToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ordnerImportierenToolStripMenuItem.Text = "Ordner Importieren";
            this.ordnerImportierenToolStripMenuItem.Click += new System.EventHandler(this.ordnerImportierenToolStripMenuItem_Click);
            // 
            // datenbankExportierenToolStripMenuItem
            // 
            this.datenbankExportierenToolStripMenuItem.Name = "datenbankExportierenToolStripMenuItem";
            this.datenbankExportierenToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.datenbankExportierenToolStripMenuItem.Text = "Datenbank Exportieren";
            this.datenbankExportierenToolStripMenuItem.Click += new System.EventHandler(this.datenbankExportierenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.überToolStripMenuItem.Text = "Über";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(12, 318);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(99, 47);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Exportieren";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(359, 320);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 45);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_show_waypoints
            // 
            this.btn_show_waypoints.Location = new System.Drawing.Point(192, 319);
            this.btn_show_waypoints.Name = "btn_show_waypoints";
            this.btn_show_waypoints.Size = new System.Drawing.Size(99, 47);
            this.btn_show_waypoints.TabIndex = 4;
            this.btn_show_waypoints.Text = "Wegpunkte anzeigen";
            this.btn_show_waypoints.UseVisualStyleBackColor = true;
            this.btn_show_waypoints.Click += new System.EventHandler(this.btn_show_waypoints_Click);
            // 
            // dlg_einzelne_Datei
            // 
            this.dlg_einzelne_Datei.DefaultExt = "gpx";
            this.dlg_einzelne_Datei.Filter = "GPX-Datein|*.gpx|Alle Datein|*.*";
            this.dlg_einzelne_Datei.Title = "Bitte GPX Datei auswählen";
            // 
            // dlg_export
            // 
            this.dlg_export.DefaultExt = "gpx";
            this.dlg_export.Filter = "GPX-Datein|*.gpx|Alle Datein|*.*";
            this.dlg_export.Title = "Datei Exportieren";
            // 
            // lv_Tracks
            // 
            this.lv_Tracks.CheckBoxes = true;
            this.lv_Tracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_Name,
            this.clh_id});
            this.lv_Tracks.Location = new System.Drawing.Point(6, 32);
            this.lv_Tracks.Name = "lv_Tracks";
            this.lv_Tracks.Size = new System.Drawing.Size(429, 183);
            this.lv_Tracks.TabIndex = 7;
            this.lv_Tracks.UseCompatibleStateImageBehavior = false;
            this.lv_Tracks.View = System.Windows.Forms.View.Details;
            this.lv_Tracks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lv_Namen_ItemCheck);
            // 
            // clh_Name
            // 
            this.clh_Name.Text = "Name";
            this.clh_Name.Width = 347;
            // 
            // clh_id
            // 
            this.clh_id.Text = "ID";
            this.clh_id.Width = 77;
            // 
            // tbx_suchen_Tracks
            // 
            this.tbx_suchen_Tracks.Location = new System.Drawing.Point(69, 6);
            this.tbx_suchen_Tracks.Name = "tbx_suchen_Tracks";
            this.tbx_suchen_Tracks.Size = new System.Drawing.Size(366, 20);
            this.tbx_suchen_Tracks.TabIndex = 8;
            this.tbx_suchen_Tracks.TextChanged += new System.EventHandler(this.tbx_suchen_Tracks_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_tracks);
            this.tabControl1.Controls.Add(this.tp_waypoints);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 285);
            this.tabControl1.TabIndex = 9;
            // 
            // tp_tracks
            // 
            this.tp_tracks.Controls.Add(this.lbl_suchen_tracks);
            this.tp_tracks.Controls.Add(this.lv_Tracks);
            this.tp_tracks.Controls.Add(this.tbx_suchen_Tracks);
            this.tp_tracks.Location = new System.Drawing.Point(4, 22);
            this.tp_tracks.Name = "tp_tracks";
            this.tp_tracks.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tracks.Size = new System.Drawing.Size(438, 259);
            this.tp_tracks.TabIndex = 0;
            this.tp_tracks.Text = "Tracks";
            this.tp_tracks.UseVisualStyleBackColor = true;
            // 
            // lbl_suchen_tracks
            // 
            this.lbl_suchen_tracks.AutoSize = true;
            this.lbl_suchen_tracks.Location = new System.Drawing.Point(6, 9);
            this.lbl_suchen_tracks.Name = "lbl_suchen_tracks";
            this.lbl_suchen_tracks.Size = new System.Drawing.Size(47, 13);
            this.lbl_suchen_tracks.TabIndex = 9;
            this.lbl_suchen_tracks.Text = "Suchen:";
            // 
            // tp_waypoints
            // 
            this.tp_waypoints.Controls.Add(this.lbl_suchen_way);
            this.tp_waypoints.Controls.Add(this.lv_waypoints);
            this.tp_waypoints.Controls.Add(this.tbx_suchen_waypoints);
            this.tp_waypoints.Location = new System.Drawing.Point(4, 22);
            this.tp_waypoints.Name = "tp_waypoints";
            this.tp_waypoints.Padding = new System.Windows.Forms.Padding(3);
            this.tp_waypoints.Size = new System.Drawing.Size(438, 259);
            this.tp_waypoints.TabIndex = 1;
            this.tp_waypoints.Text = "Waypoints";
            this.tp_waypoints.UseVisualStyleBackColor = true;
            // 
            // lbl_suchen_way
            // 
            this.lbl_suchen_way.AutoSize = true;
            this.lbl_suchen_way.Location = new System.Drawing.Point(6, 9);
            this.lbl_suchen_way.Name = "lbl_suchen_way";
            this.lbl_suchen_way.Size = new System.Drawing.Size(47, 13);
            this.lbl_suchen_way.TabIndex = 12;
            this.lbl_suchen_way.Text = "Suchen:";
            // 
            // lv_waypoints
            // 
            this.lv_waypoints.CheckBoxes = true;
            this.lv_waypoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_waypoints.Location = new System.Drawing.Point(6, 32);
            this.lv_waypoints.Name = "lv_waypoints";
            this.lv_waypoints.Size = new System.Drawing.Size(429, 183);
            this.lv_waypoints.TabIndex = 10;
            this.lv_waypoints.UseCompatibleStateImageBehavior = false;
            this.lv_waypoints.View = System.Windows.Forms.View.Details;
            this.lv_waypoints.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lv_waypoints_ItemCheck);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 347;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 77;
            // 
            // tbx_suchen_waypoints
            // 
            this.tbx_suchen_waypoints.Location = new System.Drawing.Point(69, 6);
            this.tbx_suchen_waypoints.Name = "tbx_suchen_waypoints";
            this.tbx_suchen_waypoints.Size = new System.Drawing.Size(366, 20);
            this.tbx_suchen_waypoints.TabIndex = 11;
            this.tbx_suchen_waypoints.TextChanged += new System.EventHandler(this.tbx_suchen_waypoints_TextChanged);
            // 
            // lbl_wip
            // 
            this.lbl_wip.AutoSize = true;
            this.lbl_wip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wip.Location = new System.Drawing.Point(102, 370);
            this.lbl_wip.Name = "lbl_wip";
            this.lbl_wip.Size = new System.Drawing.Size(260, 25);
            this.lbl_wip.TabIndex = 10;
            this.lbl_wip.Text = "Vorgang wird ausgegührt!";
            this.lbl_wip.Visible = false;
            // 
            // GPX_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 396);
            this.Controls.Add(this.lbl_wip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_show_waypoints);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.Head_Menue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Head_Menue;
            this.Name = "GPX_Viewer";
            this.Text = "GPX Viewer";
            this.Head_Menue.ResumeLayout(false);
            this.Head_Menue.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_tracks.ResumeLayout(false);
            this.tp_tracks.PerformLayout();
            this.tp_waypoints.ResumeLayout(false);
            this.tp_waypoints.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Head_Menue;
        private System.Windows.Forms.ToolStripMenuItem datenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ToolStripMenuItem ordnerImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datenbankExportierenToolStripMenuItem;
        private System.Windows.Forms.Button btn_show_waypoints;
        private System.Windows.Forms.OpenFileDialog dlg_einzelne_Datei;
        private System.Windows.Forms.SaveFileDialog dlg_export;
        private System.Windows.Forms.FolderBrowserDialog dlg_browse_folder;
        private System.Windows.Forms.ListView lv_Tracks;
        private System.Windows.Forms.ColumnHeader clh_Name;
        private System.Windows.Forms.ColumnHeader clh_id;
        private System.Windows.Forms.TextBox tbx_suchen_Tracks;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_tracks;
        private System.Windows.Forms.TabPage tp_waypoints;
        private System.Windows.Forms.Label lbl_suchen_tracks;
        private System.Windows.Forms.Label lbl_suchen_way;
        private System.Windows.Forms.ListView lv_waypoints;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbx_suchen_waypoints;
        public System.Windows.Forms.Label lbl_wip;
    }
}

