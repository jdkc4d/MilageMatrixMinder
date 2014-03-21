using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Milage_Matrix_Minder
{
    class ReadWriteCSV
    {
        //Files

        public String ToJSON(String CSVPath)
        {
            //Read the file into an array. One line per
            string[] Locations = File.ReadAllLines(CSVPath);
            int count = Locations.Length;

            String myJSON = "{";
            //Now, lets step through the Array and build a JSON
            for (int i = 0; i < count; i++ )
            {
                MessageBox.Show(Locations[i]);
                //Now I need to build an array out of the first line
                //Then step through each of the other lines and append to the JSON
            }



                return "";
        }

        public String toCSV(String MyMilageReport)
        {
            return "";
        }
    }
}
