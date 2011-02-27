using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace GPX_Viewer
{
    public partial class GPX_Viewer : Form
    {
        FileDialog GPXSource;
        FolderBrowserDialog Ordner_Browser;

        
        int PrimaryKey;
        Controller c = new Controller();

        public GPX_Viewer()
        {
            InitializeComponent();
        }

        private void importierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPXSource = GetGPXSource();
            if (GPXSource != null)
            {
                MessageBox.Show(GPXSource.FileName);
            }

        }
        private FileDialog GetGPXSource()
        {
            if (dlg_einzelne_Datei.ShowDialog() == DialogResult.OK)
            {
                return dlg_einzelne_Datei;
            }
            else
            {
                return null;
            }
        }
        private FolderBrowserDialog BrowseOrdner()
        {
            if (dlg_browse_folder.ShowDialog() == DialogResult.OK)
            {
                return dlg_browse_folder;
            }
            else
            {
                return null;
            }
        }
        private void ordnerImportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordner_Browser = BrowseOrdner();
            if (Ordner_Browser != null)
            {
                c.TestFunktion(Ordner_Browser);
            }// ende if (Ordner_Browser != null)
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            
        }//ende private void ordnerImportierenToolStripMenuItem_Click(object sender, EventArgs e)
    }
}
