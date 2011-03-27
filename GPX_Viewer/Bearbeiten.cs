using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPX_Viewer
{
    public partial class Bearbeiten : Form
    {
        Controller C;
        int TrackID;
        string[,] buffer;
        double[,] bufferWay;
        string WhatIsIt;
        public Bearbeiten(Controller c, int TrackId, string WhatIsIt)
        {
            InitializeComponent();
            C = c;
            TrackID = TrackId;
            this.WhatIsIt = WhatIsIt;
            ListeFuellen(TrackID, this.WhatIsIt);
            InputFuellen(TrackID, this.WhatIsIt);
        }

        private void ListeFuellen(int TrackID, string WhatIsIt)
        {
            lv_Trackpoints.Items.Clear();
            if (WhatIsIt == "Track")
            {
                buffer = C.getTrackPoints(TrackID);
                for (int i = 0; i < buffer.Length / 2; i++)
                {
                    ListViewItem listItem = new ListViewItem(buffer[i, 0]);
                    listItem.SubItems.Add(buffer[i, 1]);
                    lv_Trackpoints.Items.Add(listItem);
                }
            }
            else
            {
                bufferWay = C.getWaypointLatLon(TrackID);
                for (int i = 0; i < bufferWay.Length / 2; i++)
                {
                    ListViewItem listItem = new ListViewItem(bufferWay[i, 0].ToString());
                    listItem.SubItems.Add(bufferWay[i, 1].ToString());
                    lv_Trackpoints.Items.Add(listItem);
                }
            }
        }
        private void InputFuellen(int TrackID, string WhatIsIt)
        {
            txb_Name.Text = "";
            if (WhatIsIt == "Track")
            {
                txb_Name.Text = C.getTrackName(TrackID);
            }
            else
            {
                txb_Name.Text = C.getWaypointName(TrackID);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            C.setTrackName(txb_Name.Text, TrackID);
            this.Close();
        }
    }
}
