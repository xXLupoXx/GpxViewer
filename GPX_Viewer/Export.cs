using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;


namespace GPX_Viewer
{
    public class Export
    {
        List<string> sLines = new List<string>();
        Model m;
        string SQL;
        public Export(Model m)
        {
            this.m = m;
        }


        public void ExportGPX(List<int> ToExport)
        {
            m.con.Open();
            StreamWriter myFile = new StreamWriter(Path.Combine(Application.StartupPath,"test.gpx"));
            //Header
            myFile.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\" ?>\n");
            myFile.Write("<gpx xmlns=\"http://www.topografix.com/GPX/1/1\" creator=\"\" version=\"1.1\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd\">\n");


            //Track
            for (int i = 0; i < ToExport.Count; i++)
            {
                //Track aus DB
                SQL = String.Format("Select * From tbl_track WHERE ID_Track like '{0}'", ToExport[i]);
                m.cmd = new OleDbCommand(SQL, m.con);
                m.dr = m.cmd.ExecuteReader();
                m.dr.Read();
                myFile.Write("<trk>\n<name>"+(string)m.dr[1]+"</name>\n<trkseg>\n");

                //Trackpoints

                    //Trackpoint aus DB
                    SQL = String.Format("Select * From tbl_Trackpoint WHERE FS_ID_Track like '{0}'", ToExport[i]);
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.dr = m.cmd.ExecuteReader();

                    while (m.dr.Read())
                    {
                        myFile.Write(string.Format("<trkpt lat=\"{0}\" lon=\"{1}\">\n", m.dr[2].ToString().Replace(',', '.'), m.dr[1].ToString().Replace(',', '.')));
                        myFile.Write(string.Format("<ele>{0}</ele>\n", m.dr[4].ToString().Replace(',', '.')));
                        myFile.Write(string.Format("<time>{0}</time>\n", m.dr[3].ToString()));
                        myFile.Write("</trkpt>\n");
                    }

                //Trackpoints Ende

                myFile.Write("</trkseg>\n</trk>\n");
            }
            //Track Ende



            //Waypoints

                //MACHEN!!!

            //Waypoints ende
            //ende der Datei
            myFile.Write("</gpx>");
            myFile.Close();
            MessageBox.Show("Fertig!");
            m.con.Close();
        }
    }
}
