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
using System.Data.OleDb;


namespace GPX_Viewer
{
    public class Import
    {
        enum GPX_Zustände { START, GPX, GPX_TRK, GPX_WPT, GPX_WPT_NAME, GPX_WPT_ELE, GPX_WPT_CMT, GPX_WPT_DESC, GPX_WPT_SYM,GPX_TRK_NAME, GPX_TRK_TRKSEG, GPX_TRK_TRKSEG_TRKPT, GPX_TRK_TRKSEG_TRKPT_TIME, GPX_TRK_TRKSEG_TRKPT_ELE };
        GPX_Zustände Zustand = GPX_Zustände.START;
        double akt_lat, akt_lon;
        Model m;
        int Anzahl_der_Tracks, ID_Track_var, debug = 0, Max_Index, Min_Index;
        string SQL;
        string Waypoint_Name = null;
        string Track_Name = null;
        string akt_Zeit, strBuf, cmt, desc, name, sym;
        double akt_ele;
        bool EintragGefunden = false;
        List<GPXDatenSpeicher> GPXList = new List<GPXDatenSpeicher>(); //Zwischenspeicher für GPX Daten
        List<int> IndexList = new List<int>(); //Index um verschiedene Traks zu finden
        List<ID_Track_Liste> IDListe = new List<ID_Track_Liste>(); // Liste der Track IDs

        public Import(Model m)
        {
            this.m = m;
        }

        public void ImportGPX(FolderBrowserDialog Ordner_Browser, FileDialog GPX_File)
        {

            m.con.Open();

            if (Ordner_Browser != null)
            {
                DirectoryInfo d = new DirectoryInfo(Ordner_Browser.SelectedPath);

                foreach (FileInfo f in d.GetFiles("*.gpx"))
                {
                    ImportFiles(f);
                }//ende foreach (FileInfo f in d.GetFiles("*.gpx*"))
            }
            else
            {
                FileInfo File = new FileInfo(GPX_File.FileName);
                ImportFiles(File);
            }
            m.con.Close();
        }
        public bool CheckDataBase(string Name, int Min_Index)
        {
            
            //false = keine Übereinstimmung


            SQL = String.Format("Select count(*) From tbl_track WHERE Track_Name_Import = '{0}'", Name);
            m.cmd = new OleDbCommand(SQL, m.con);
            m.dr = m.cmd.ExecuteReader();
            while (m.dr.Read())
            {
                try
                {
                    Anzahl_der_Tracks = int.Parse(m.dr[0].ToString());
                }
                catch
                {
                }
            }

            if (Anzahl_der_Tracks == 0)
            {

                return false;
            }
            else
            {
                for (int i = 0; i < Anzahl_der_Tracks; i++)
                {
                    SQL = String.Format("Select ID_Track From tbl_track WHERE Track_Name_Import = '{0}'", Name);
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.dr = m.cmd.ExecuteReader();
                    m.dr.Read();
                    ID_Track_var = int.Parse(m.dr[0].ToString());


                    SQL = String.Format("Select Längengrad, Breitengrad, FS_ID_Track From tbl_Trackpoint Where FS_ID_Track like '{0}' Order by ID_Trackpoint ASC", ID_Track_var);
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.dr = m.cmd.ExecuteReader();
                    while (m.dr.Read())
                    {

                        if (GPXList[Min_Index].Latitude != (double)m.dr[1] && GPXList[Min_Index].Longitude != (double)m.dr[0])
                            {
                                debug++;
                                return false;
                            }
                        Min_Index++;

                    }
                }
               
            }

            return true;
        }

        private void ImportFiles(FileInfo f)
        {
            IndexList = new List<int>();
            GPXList = new List<GPXDatenSpeicher>();


            XmlTextReader xr = new XmlTextReader(f.FullName);
            #region Reader
            while (xr.Read())
            {
                if (Zustand == GPX_Zustände.START)
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "gpx")
                    {
                        Zustand = GPX_Zustände.GPX;
                    }// ende if (xr.NodeType == XmlNodeType.Element && xr.Name == "gpx")
                }//ende if (Zustand == GPX_Zustände.START)
                else if (Zustand == GPX_Zustände.GPX)
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "trk")
                    {
                        Zustand = GPX_Zustände.GPX_TRK;
                    }
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "wpt")
                    {
                        if (xr.HasAttributes)
                        {
                            while (xr.MoveToNextAttribute())
                            {
                                if (xr.Name == "lat") akt_lat = xr.ReadContentAsDouble();
                                if (xr.Name == "lon") akt_lon = xr.ReadContentAsDouble();
                            }
                        }
                        Zustand = GPX_Zustände.GPX_WPT;
                    }// ende if (xr.NodeType == XmlNodeType.Element && xr.Name == "wpt")

                } // ende else if (Zustand == GPX_Zustände.GPX)
                else if (Zustand == GPX_Zustände.GPX_TRK)
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "name")
                    {
                        Zustand = GPX_Zustände.GPX_TRK_NAME;
                    }
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "trkseg")
                    {
                        Zustand = GPX_Zustände.GPX_TRK_TRKSEG;
                    }
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "trk")
                    {
                        Zustand = GPX_Zustände.GPX;
                    }
                }// ende else if (Zustand == GPX_Zustände.GPX_TRK)
                else if (Zustand == GPX_Zustände.GPX_WPT)
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "ele")
                    {
                        Zustand = GPX_Zustände.GPX_WPT_ELE;
                    }
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "name")
                    {
                        Zustand = GPX_Zustände.GPX_WPT_NAME;
                    }
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "cmt")
                    {
                        Zustand = GPX_Zustände.GPX_WPT_CMT;
                    }
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "desc")
                    {
                        Zustand = GPX_Zustände.GPX_WPT_DESC;
                    }
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "sym")
                    {
                        Zustand = GPX_Zustände.GPX_WPT_SYM;
                    }
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "wpt")
                    {

                        SQL = "Insert Into tbl_Wegpunkt (Längengrad,Breitengrad,Ele,Name,CMT,DESC,sym) Values ('" + akt_lon + "','" + akt_lat + "','" + akt_ele + "','" + name + "','" + cmt + "','" + desc + "','" + sym + "')";
                        m.cmd = new OleDbCommand(SQL, m.con);
                        m.cmd.ExecuteNonQuery();
                       
                        Zustand = GPX_Zustände.GPX;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_WPT_ELE)
                {
                    strBuf = xr.ReadContentAsString().Replace('.', ',');
                    akt_ele = double.Parse(strBuf);
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "ele")
                    {
                        Zustand = GPX_Zustände.GPX_WPT;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_WPT_NAME)
                {
                    name = xr.ReadContentAsString();
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "name")
                    {
                        Zustand = GPX_Zustände.GPX_WPT;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_WPT_CMT)
                {
                    cmt = xr.ReadContentAsString();
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "cmt")
                    {
                        Zustand = GPX_Zustände.GPX_WPT;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_WPT_DESC)
                {
                    desc = xr.ReadContentAsString();
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "desc")
                    {
                        Zustand = GPX_Zustände.GPX_WPT;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_WPT_SYM)
                {
                    sym = xr.ReadContentAsString();
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "sym")
                    {
                        Zustand = GPX_Zustände.GPX_WPT;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_TRK_NAME)
                {
                    Track_Name = xr.ReadContentAsString();

                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "name")
                    {
                        Zustand = GPX_Zustände.GPX_TRK;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_TRK_TRKSEG)
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "trkpt")
                    {
                        if (xr.HasAttributes)
                        {
                            // Erst mal ALLE Attribute lesen!!
                            while (xr.MoveToNextAttribute())
                            {
                                if (xr.Name == "lat") akt_lat = xr.ReadContentAsDouble();
                                if (xr.Name == "lon") akt_lon = xr.ReadContentAsDouble();
                            }
                        }
                        Zustand = GPX_Zustände.GPX_TRK_TRKSEG_TRKPT;
                    }

                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "trkseg")
                    {
                        Zustand = GPX_Zustände.GPX_TRK;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_TRK_TRKSEG_TRKPT)
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "time")
                    {
                        Zustand = GPX_Zustände.GPX_TRK_TRKSEG_TRKPT_TIME;
                    }
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "ele")
                    {
                        Zustand = GPX_Zustände.GPX_TRK_TRKSEG_TRKPT_ELE;
                    }
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "trkpt")
                    {
                        GPXList.Add(new GPXDatenSpeicher(akt_lat, akt_lon, akt_Zeit, akt_ele, Track_Name));
                        Zustand = GPX_Zustände.GPX_TRK_TRKSEG;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_TRK_TRKSEG_TRKPT_TIME)
                {
                    akt_Zeit = xr.ReadContentAsString();
                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "time")
                    {
                        Zustand = GPX_Zustände.GPX_TRK_TRKSEG_TRKPT;
                    }
                }
                else if (Zustand == GPX_Zustände.GPX_TRK_TRKSEG_TRKPT_ELE)
                {
                    strBuf = xr.ReadContentAsString().Replace('.', ',');
                    akt_ele = double.Parse(strBuf);

                    if (xr.NodeType == XmlNodeType.EndElement && xr.Name == "ele")
                    {
                        Zustand = GPX_Zustände.GPX_TRK_TRKSEG_TRKPT;
                    }
                }

            }//ende while (xr.Read())
            #endregion

            strBuf = null;
            //Noch wegpunkt einlesen einbauen... (keine lust)

            for (int i = 0; i < GPXList.Count; i++)
            {
                if (strBuf != GPXList[i].Name)
                {
                    IndexList.Add(i);
                }
                strBuf = GPXList[i].Name;
            }

            for (int iLoop = 0; iLoop < IndexList.Count; iLoop++)
            {
                EintragGefunden = false;
                if (!EintragGefunden)
                {
                    Min_Index = IndexList[iLoop];
                    EintragGefunden = CheckDataBase(GPXList[IndexList[iLoop]].Name, Min_Index);
                    if (iLoop == (IndexList.Count - 1))
                    {
                        Max_Index = GPXList.Count;
                    }
                    else
                    {
                        Max_Index = IndexList[iLoop + 1];
                    }
                }
                else
                {
                    //MessageBox.Show("Gibbet schon");
                }

                if (!EintragGefunden)
                {


                    SQL = "Insert Into tbl_track (Track_Name, Track_Name_Import) Values ('" + GPXList[IndexList[iLoop]].Name + "','" + GPXList[IndexList[iLoop]].Name + "')";
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.cmd.ExecuteNonQuery();



                    System.Threading.Thread.Sleep(100);
                    SQL = "Select ID_Track From tbl_track Where Track_Name_Import = '" + GPXList[IndexList[iLoop]].Name + "'";
                    m.cmd = new OleDbCommand(SQL, m.con);
                    m.dr = m.cmd.ExecuteReader();
                    m.dr.Read();
                    ID_Track_var = (int)m.dr[0];
                    //MessageBox.Show(m.dr[0].ToString());



                    for (int i = Min_Index; i < Max_Index; i++)
                    {


                        SQL = "Insert Into tbl_Trackpoint (Längengrad,Breitengrad,Zeit,Ele,FS_ID_Track) Values ('" + GPXList[i].Longitude + "','" + GPXList[i].Latitude + "','" + GPXList[i].Zeit + "','" + GPXList[i].Ele + "','" + ID_Track_var + "')";
                        m.cmd = new OleDbCommand(SQL, m.con);
                        m.cmd.ExecuteNonQuery();


                    }

                    //MessageBox.Show("is drin" + debug.ToString());
                }
                else
                {
                    MessageBox.Show("is schon drin" + debug.ToString());
                }

            }
        }

    }
}