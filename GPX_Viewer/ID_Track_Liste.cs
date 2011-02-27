using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPX_Viewer
{
    class ID_Track_Liste
    {
        public int ID;
        public string Name;

        public ID_Track_Liste(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public ID_Track_Liste()
        {
        }
    }
}
