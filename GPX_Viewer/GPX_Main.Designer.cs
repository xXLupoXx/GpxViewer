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
            this.clb_Namen = new System.Windows.Forms.CheckedListBox();
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
            this.btn_search = new System.Windows.Forms.Button();
            this.dlg_einzelne_Datei = new System.Windows.Forms.OpenFileDialog();
            this.dlg_export = new System.Windows.Forms.SaveFileDialog();
            this.pgb_Fortschritt = new System.Windows.Forms.ProgressBar();
            this.dlg_browse_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.Head_Menue.SuspendLayout();
            this.SuspendLayout();
            // 
            // clb_Namen
            // 
            this.clb_Namen.FormattingEnabled = true;
            this.clb_Namen.Location = new System.Drawing.Point(12, 48);
            this.clb_Namen.Name = "clb_Namen";
            this.clb_Namen.Size = new System.Drawing.Size(341, 274);
            this.clb_Namen.TabIndex = 0;
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
            this.datenToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.datenToolStripMenuItem.Text = "Daten";
            // 
            // importierenToolStripMenuItem
            // 
            this.importierenToolStripMenuItem.Name = "importierenToolStripMenuItem";
            this.importierenToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.importierenToolStripMenuItem.Text = "Einzelne Datai Importieren";
            this.importierenToolStripMenuItem.Click += new System.EventHandler(this.importierenToolStripMenuItem_Click);
            // 
            // ordnerImportierenToolStripMenuItem
            // 
            this.ordnerImportierenToolStripMenuItem.Name = "ordnerImportierenToolStripMenuItem";
            this.ordnerImportierenToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ordnerImportierenToolStripMenuItem.Text = "Ordner Importieren";
            this.ordnerImportierenToolStripMenuItem.Click += new System.EventHandler(this.ordnerImportierenToolStripMenuItem_Click);
            // 
            // datenbankExportierenToolStripMenuItem
            // 
            this.datenbankExportierenToolStripMenuItem.Name = "datenbankExportierenToolStripMenuItem";
            this.datenbankExportierenToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.datenbankExportierenToolStripMenuItem.Text = "Datenbank Exportieren";
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
            this.überToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.überToolStripMenuItem.Text = "Über";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(359, 48);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(99, 47);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Exportieren";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(359, 277);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 45);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_show_waypoints
            // 
            this.btn_show_waypoints.Location = new System.Drawing.Point(359, 123);
            this.btn_show_waypoints.Name = "btn_show_waypoints";
            this.btn_show_waypoints.Size = new System.Drawing.Size(99, 47);
            this.btn_show_waypoints.TabIndex = 4;
            this.btn_show_waypoints.Text = "Wegpunkte anzeigen";
            this.btn_show_waypoints.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(359, 201);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 46);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Suchen";
            this.btn_search.UseVisualStyleBackColor = true;
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
            // pgb_Fortschritt
            // 
            this.pgb_Fortschritt.Location = new System.Drawing.Point(12, 335);
            this.pgb_Fortschritt.Name = "pgb_Fortschritt";
            this.pgb_Fortschritt.Size = new System.Drawing.Size(446, 23);
            this.pgb_Fortschritt.TabIndex = 6;
            this.pgb_Fortschritt.Visible = false;
            // 
            // GPX_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 370);
            this.Controls.Add(this.pgb_Fortschritt);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_show_waypoints);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.clb_Namen);
            this.Controls.Add(this.Head_Menue);
            this.MainMenuStrip = this.Head_Menue;
            this.Name = "GPX_Viewer";
            this.Text = "GPX Viewer";
            this.Head_Menue.ResumeLayout(false);
            this.Head_Menue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_Namen;
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
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.OpenFileDialog dlg_einzelne_Datei;
        private System.Windows.Forms.SaveFileDialog dlg_export;
        private System.Windows.Forms.ProgressBar pgb_Fortschritt;
        private System.Windows.Forms.FolderBrowserDialog dlg_browse_folder;
    }
}

