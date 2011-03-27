using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Threading.Tasks;

namespace GPX_Viewer
{
    public class Controller
    {
        string SQL,Zeit;
        int index = 0, intBuffer = 0;
        List<string> DataBuffer = new List<string>();
        string[,] ArrayBuffer;
        double[,] WegpunktBuffer;
        GPX_Viewer gw;
        string Track_Name, Wegpunkt_Name;

        Model m = new Model();
        Import i;
        Export e;

        public Controller( GPX_Viewer gw)
        {
            i = new Import(m);
            e = new Export(m);
            this.gw = gw;
        }

        public void ImportFolder(FolderBrowserDialog Ordner_Browser)
        {
            gw.lbl_wip.Visible = true;
                Parallel.Invoke(() =>
               {
                   i.ImportGPX(Ordner_Browser, null);
               }
                      );
                gw.lbl_wip.Visible = false;
            //i.ImportGPX(Ordner_Browser,null);
            
        }

        public void ImportFile(FileDialog GPXFile)
        {
            gw.lbl_wip.Visible = true;
            Parallel.Invoke(() =>
            {
                i.ImportGPX(null, GPXFile);
            }
      );
            gw.lbl_wip.Visible = false;
           
        }

        public string[,] getTracks(string search,int search_index) //Liest Daten für die clickbox aus
        {
            index = 0;
            
            if (search_index == 0)
            {
                m.con.Open();
                SQL = string.Format("Select count(Track_Name) From tbl_track WHERE Track_Name Like '%{0}%'", search);
                m.cmd = new OleDbCommand(SQL, m.con);
                m.dr = m.cmd.ExecuteReader();
                m.dr.Read();
                intBuffer = (int)m.dr[0];
                SQL = string.Format("Select Track_Name,ID_Track From tbl_track WHERE Track_Name Like '%{0}%'", search);
                m.cmd = new OleDbCommand(SQL, m.con);
                m.dr = m.cmd.ExecuteReader();
                ArrayBuffer = new string[intBuffer, 2];
                while (m.dr.Read())
                {
                    ArrayBuffer[index, 0] = (string)m.dr[0];
                    ArrayBuffer[index, 1] = m.dr[1].ToString();
                    //DataBuffer.Add((string)m.dr[0]);
                    index++;
                }
                m.con.Close();
                return ArrayBuffer;
            }
            else if (search_index == 1)
            {
                m.con.Open();
                //Alle Track IDs auslesen
                SQL = string.Format("Select FS_ID_Track,Zeit From tbl_trackpoint ORDER BY FS_ID_Track ASC");
                m.cmd = new OleDbCommand(SQL, m.con);
                m.dr = m.cmd.ExecuteReader();
                DataBuffer.Clear();
                while (m.dr.Read())
                {
                    if (!DataBuffer.Contains(m.dr[0].ToString()))
                    {
                        string[] split = m.dr[1].ToString().Split('T');
                        string[] split2 = split[0].Split('-');
                        Zeit = split2[2] + "." + split2[1] + "." + split2[0];
                        if (Zeit == search || (split2[2] + "." + split2[1]) == search || null == search || (split2[2] + ".") == search || (split2[2]) == search || search.Contains(split2[2] + "." + split2[1]))
                        {
                            DataBuffer.Add(m.dr[0].ToString());       
                        }
                    }
                }
                ArrayBuffer = new string[DataBuffer.Count, 2];
                for (index = 0; index < DataBuffer.Count; index++)
                {
                    SQL = string.Format("Select Track_Name From tbl_track WHERE ID_Track like {0}", DataBuffer[index]);
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.dr = m.cmd.ExecuteReader();
                    m.dr.Read();
                    ArrayBuffer[index, 0] = (string)m.dr[0];
                    ArrayBuffer[index, 1] = DataBuffer[index];
                }
                    m.con.Close();
                
                return ArrayBuffer;
            }
            else
            {
                ArrayBuffer = new string[0, 2];
                return ArrayBuffer;
            }
            
           
        }
        public string[,] getWaypoints(string search) //Liest Daten für die clickbox aus
        {
            index = 0;
            m.con.Open();
            SQL = string.Format("Select count(ID_Wegpunkt) From tbl_Wegpunkt WHERE Name Like '%{0}%'", search);

            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            m.dr.Read();
            intBuffer = (int)m.dr[0];
            SQL = string.Format("Select Name,ID_Wegpunkt From tbl_Wegpunkt WHERE Name Like '%{0}%'", search);
            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            ArrayBuffer = new string[intBuffer, 2];
            while (m.dr.Read())
            {
                ArrayBuffer[index, 0] = (string)m.dr[0];
                ArrayBuffer[index, 1] = m.dr[1].ToString();
                //DataBuffer.Add((string)m.dr[0]);
                index++;
            }
            m.con.Close();
            return ArrayBuffer;
        }
        
        // Jan
        public string[,] getTrackPoints(int Id_Track) //Liest Daten für die clickbox aus
        {
            index = 0;
            m.con.Open();
            SQL = string.Format("Select count(ID_Trackpoint) From tbl_Trackpoint WHERE FS_ID_Track LIKE '{0}'", Id_Track);

            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            m.dr.Read();
            intBuffer = (int)m.dr[0];
            SQL = string.Format("Select Längengrad, Breitengrad From tbl_Trackpoint WHERE FS_ID_Track LIKE '{0}'", Id_Track);
            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            ArrayBuffer = new string[intBuffer, 2];
            while (m.dr.Read())
            {
                ArrayBuffer[index, 0] = (string)m.dr[0].ToString();
                ArrayBuffer[index, 1] = m.dr[1].ToString();
                //DataBuffer.Add((string)m.dr[0]);
                index++;
            }
            m.con.Close();
            return ArrayBuffer;
        }
        public string getTrackName(int ID_Track)
        {
            m.con.Open();
            SQL = string.Format("Select Track_Name From tbl_track WHERE ID_Track LIKE '{0}'", ID_Track);
            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            m.dr.Read();
            Track_Name = m.dr[0].ToString();
            m.con.Close();
            return Track_Name;
        }
        public string getWaypointName(int ID_Track)
        {
            m.con.Open();
            SQL = string.Format("Select Name From tbl_Wegpunkt WHERE ID_Wegpunkt LIKE '{0}'", ID_Track);
            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            m.dr.Read();
            Wegpunkt_Name = m.dr[0].ToString();
            m.con.Close();
            return Wegpunkt_Name;
        }
        public void setTrackName(string TrackName, int ID_Track)
        {
            m.con.Open();
            SQL = string.Format("UPDATE tbl_track SET Track_Name = '{0}'  WHERE ID_Track LIKE '{1}'", TrackName, ID_Track);
            m.cmd = new OleDbCommand(SQL, m.con);
            m.cmd.ExecuteNonQuery();
            m.con.Close();
            gw.UseUpdateClickbox();
        }
        public double[,] getWaypointLatLon(int ID_Track)
        {
            index = 0;
            m.con.Open();
            SQL = string.Format("Select count(ID_Wegpunkt) From tbl_Wegpunkt WHERE ID_Wegpunkt LIKE '{0}'", ID_Track);

            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            m.dr.Read();
            intBuffer = (int)m.dr[0];
            SQL = string.Format("Select Längengrad, Breitengrad From tbl_Wegpunkt WHERE ID_Wegpunkt LIKE '{0}'", ID_Track);
            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            WegpunktBuffer = new double[intBuffer, 2];
            while (m.dr.Read())
            {
                WegpunktBuffer[index, 0] = (double)m.dr[0];
                WegpunktBuffer[index, 1] = double.Parse(m.dr[1].ToString());
                //DataBuffer.Add((string)m.dr[0]);
                index++;
            }
            m.con.Close();
            return WegpunktBuffer;
        }
        // Jan ENDE

        public void deleteTrack(List<int> ToDel)
        {
            m.con.Open();
            if (ToDel.Count > 0)
            {
                for (int i = 0; i < ToDel.Count; i++)
                {
                    SQL = "DELETE * From tbl_Trackpoint WHERE FS_ID_Track like '" +ToDel[i].ToString()+ "'";
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.cmd.ExecuteNonQuery();

                    SQL = "DELETE * From tbl_track WHERE ID_Track like '" + ToDel[i].ToString() + "'";
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.cmd.ExecuteNonQuery();
                }
            }
            m.con.Close();
        }
        public void deleteWaypoint(List<int> ToDel)
        {
            m.con.Open();
            if (ToDel.Count > 0)
            {
                for (int i = 0; i < ToDel.Count; i++)
                {
                    SQL = "DELETE * From tbl_Wegpunkt WHERE ID_Wegpunkt like '" + ToDel[i].ToString() + "'";
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.cmd.ExecuteNonQuery();
                }
            }
            m.con.Close();
        }
        public void ExportFile(List<int> Export,List<int> Export_Waypoint)
        {
            e.ExportGPX(Export,Export_Waypoint);
        }         
    }
}
