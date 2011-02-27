using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPX_Viewer
{
    public class Controller
    {


        Model m = new Model();
        Import i;

        public Controller()
        {
            i = new Import(m);
        }

        public void TestFunktion(FolderBrowserDialog Ordner_Browser)
        {
            i.ImportGPX(Ordner_Browser);
        }



         
    }
}
