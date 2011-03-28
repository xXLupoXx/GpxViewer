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
        string ExportPath;
        public Export(Model m)
        {
            this.m = m;
        }


        public void ExportGPX(List<int> ToExport, List<int> ToExport_Waypoint)
        {
            m.con.Open();
            GPX_Viewer exportLocation = new GPX_Viewer();

            if (exportLocation.dlg_export.ShowDialog() == DialogResult.OK)
            {
                ExportPath = exportLocation.dlg_export.FileName;
                MessageBox.Show(ExportPath);
            }
            StreamWriter myFile = new StreamWriter(ExportPath);
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

                myFile.Write("</trkseg>\n</trk>\n\n");
            }
            //Track Ende



            //Waypoints
            for (int i = 0; i < ToExport_Waypoint.Count; i++)
            {
                //Waypoint aus DB
                SQL = String.Format("Select * From tbl_Wegpunkt WHERE ID_Wegpunkt like '{0}'", ToExport_Waypoint[i]);
                m.cmd = new OleDbCommand(SQL, m.con);
                m.dr = m.cmd.ExecuteReader();
                m.dr.Read();
                myFile.Write("<wpt lat=\"" + m.dr[2].ToString().Replace(',', '.') + "\" lon=\"" + m.dr[1].ToString().Replace(',', '.') + "\">\n");
                myFile.Write("<ele>" + m.dr[3].ToString().Replace(',', '.') + "</ele>\n");
                myFile.Write("<name>" + m.dr[4] + "</name>\n");
                myFile.Write("<cmt>" + m.dr[5] + "</cmt>\n");
                myFile.Write("<desc>" + m.dr[6] + "</desc>\n");
                myFile.Write("<sym>" + m.dr[7] + "</sym>\n");
                myFile.Write("<extensions>\n<gpxx:WaypointExtension xmlns:gpxx=\"http://www.garmin.com/xmlschemas/GpxExtensions/v3\">\n<gpxx:DisplayMode>SymbolAndName</gpxx:DisplayMode>\n</gpxx:WaypointExtension>\n</extensions>\n</wpt>\n\n");
            }

            //Waypoints ende
            //ende der Datei
            myFile.Write("</gpx>");
            myFile.Close();
            MessageBox.Show("Fertig!");
            m.con.Close();
        }
    }
}
