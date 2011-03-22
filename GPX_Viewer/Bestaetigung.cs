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
    public partial class Bestaetigung : Form
    {
        GPX_Viewer gv;
        public Bestaetigung(GPX_Viewer gv)
        {
            InitializeComponent();
            this.gv = gv;
        }

        private void btn_ja_Click(object sender, EventArgs e)
        {
            gv.deleteSelected = true;
            this.Close();
        }

        private void btn_nein_Click(object sender, EventArgs e)
        {
            gv.deleteSelected = false;
            this.Close();
        }
    }
}
