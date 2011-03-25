using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GPX_Viewer
{
    public class Controller
    {
        string SQL;
        int index = 0, intBuffer = 0;
        List<string> DataBuffer = new List<string>();
        string[,] ArrayBuffer;

        Model m = new Model();
        Import i;
        Export e;

        public Controller()
        {
            i = new Import(m);
            e = new Export(m);
            
        }

        public void ImportFolder(FolderBrowserDialog Ordner_Browser)
        {
            i.ImportGPX(Ordner_Browser,null);
           
        }

        public void ImportFile(FileDialog GPXFile)
        {
            i.ImportGPX(null, GPXFile);
           
        }

        public string[,] getTracks(string search) //Liest Daten für die clickbox aus
        {
            index = 0;
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
