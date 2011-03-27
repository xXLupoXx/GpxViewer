namespace GPX_Viewer
{
    partial class Bearbeiten
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bearbeiten));
            this.lv_Trackpoints = new System.Windows.Forms.ListView();
            this.clh_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Trackpoints
            // 
            this.lv_Trackpoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_Name,
            this.clh_id});
            this.lv_Trackpoints.Location = new System.Drawing.Point(21, 48);
            this.lv_Trackpoints.Name = "lv_Trackpoints";
            this.lv_Trackpoints.Size = new System.Drawing.Size(429, 221);
            this.lv_Trackpoints.TabIndex = 8;
            this.lv_Trackpoints.UseCompatibleStateImageBehavior = false;
            this.lv_Trackpoints.View = System.Windows.Forms.View.Details;
            // 
            // clh_Name
            // 
            this.clh_Name.Text = "Breitengrad";
            this.clh_Name.Width = 150;
            // 
            // clh_id
            // 
            this.clh_id.Text = "Längengrad";
            this.clh_id.Width = 150;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(59, 22);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(391, 20);
            this.txb_Name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(188, 275);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(99, 76);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Speichern";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 357);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lv_Trackpoints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Trackpoints;
        private System.Windows.Forms.ColumnHeader clh_Name;
        private System.Windows.Forms.ColumnHeader clh_id;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
    }
}