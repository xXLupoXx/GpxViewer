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
        Bestaetigung bs;
        FolderBrowserDialog Ordner_Browser;
        string[,] buffer;
        string search;
        List<int> checked_items = new List<int>();
        public Boolean deleteSelected = false;
        // Boolean Success = false;


        Controller c = new Controller();

        public GPX_Viewer()
        {
            InitializeComponent();
            UpdateClickbox();
        }

        private void importierenToolStripMenuItem_Click(object sender, EventArgs e) // Importiert einzelne Datei
        {
            GPXSource = GetGPXSource();
            
            if (GPXSource != null)
            {
                c.ImportFile(GPXSource);
            }
            UpdateClickbox();
        }
        private FileDialog GetGPXSource() //Öffnet einzelne Datei
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
        private FolderBrowserDialog BrowseOrdner() //Öffnet den Ordnerbrowser
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
        private void ordnerImportierenToolStripMenuItem_Click(object sender, EventArgs e) //Ordnerimport
        {
            Ordner_Browser = BrowseOrdner();
            
            if (Ordner_Browser != null)
            {
                c.ImportFolder(Ordner_Browser);
            }// ende if (Ordner_Browser != null)
            UpdateClickbox();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            c.ExportFile(checked_items);
        }//ende private void ordnerImportierenToolStripMenuItem_Click(object sender, EventArgs e)


        private void UpdateClickbox() //Fügt daten in die Clickbox ein
        {
            lv_Tracks.Items.Clear();
            buffer = c.getTracks_Waypoints(search);

            for (int i = 0; i < buffer.Length / 2; i++)
            {
                
                ListViewItem listItem = new ListViewItem(buffer[i, 0]);
                listItem.SubItems.Add(buffer[i, 1]);
                if (checked_items.Contains(int.Parse(buffer[i, 1])))
                {
                    listItem.Checked = true;
                }
                else
                {
                    listItem.Checked = false;
                }
                lv_Tracks.Items.Add(listItem);

            }
        }

        private void lv_Namen_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //checked_items.Add(int.Parse(lv_Namen.CheckedItems[0].SubItems[0].Text));

            if (e.CurrentValue == CheckState.Unchecked && !checked_items.Contains(int.Parse(lv_Tracks.Items[e.Index].SubItems[1].Text)))
            {
                //MessageBox.Show(lv_Namen.Items[e.Index].SubItems[1].Text);
                checked_items.Add(int.Parse(lv_Tracks.Items[e.Index].SubItems[1].Text));
            }
            else if ((e.CurrentValue == CheckState.Checked))
            {
                //MessageBox.Show(int.Parse(lv_Tracks.Items[e.Index].SubItems[1].Text).ToString());
                checked_items.Remove(int.Parse(lv_Tracks.Items[e.Index].SubItems[1].Text));
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bs = new Bestaetigung(this);
            bs.ShowDialog();
           if(deleteSelected)
           {
             c.deleteTrack(checked_items);
             UpdateClickbox();
           }
           
        }

        private void tbx_suchen_Tracks_TextChanged(object sender, EventArgs e)
        {
            search = tbx_suchen_Tracks.Text;
            UpdateClickbox();
        }


        


    }
}
