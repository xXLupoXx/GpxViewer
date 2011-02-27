using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPX_Viewer
{
    class GPXDatenSpeicher
    {
        public double Latitude;
        public double Longitude;
        public string Zeit;
        public double Ele;
        public string Name;

        public GPXDatenSpeicher(double Latitude, double Longitude, string Zeit, double Ele, string Name)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Zeit = Zeit;
            this.Ele = Ele;
            this.Name = Name;
        }

        public GPXDatenSpeicher()
        {
        }
    }
}
