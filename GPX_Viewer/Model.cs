using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace GPX_Viewer
{
    public class Model
    {
        public OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path.Combine(Application.StartupPath,"GPX_Daten.mdb"));
        public OleDbCommand cmd;
        public OleDbDataReader dr;
    }
}
