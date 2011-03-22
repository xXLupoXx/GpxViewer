namespace GPX_Viewer
{
    partial class Bestaetigung
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
            this.btn_ja = new System.Windows.Forms.Button();
            this.btn_nein = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ja
            // 
            this.btn_ja.Location = new System.Drawing.Point(12, 60);
            this.btn_ja.Name = "btn_ja";
            this.btn_ja.Size = new System.Drawing.Size(75, 23);
            this.btn_ja.TabIndex = 0;
            this.btn_ja.Text = "Ja";
            this.btn_ja.UseVisualStyleBackColor = true;
            this.btn_ja.Click += new System.EventHandler(this.btn_ja_Click);
            // 
            // btn_nein
            // 
            this.btn_nein.Location = new System.Drawing.Point(193, 60);
            this.btn_nein.Name = "btn_nein";
            this.btn_nein.Size = new System.Drawing.Size(75, 23);
            this.btn_nein.TabIndex = 1;
            this.btn_nein.Text = "Nein";
            this.btn_nein.UseVisualStyleBackColor = true;
            this.btn_nein.Click += new System.EventHandler(this.btn_nein_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wollen Sie die makierten Datensätze wirklich löchen?";
            // 
            // Bestaetigung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 95);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nein);
            this.Controls.Add(this.btn_ja);
            this.Name = "Bestaetigung";
            this.Text = "Bestaetigung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ja;
        private System.Windows.Forms.Button btn_nein;
        private System.Windows.Forms.Label label1;
    }
}