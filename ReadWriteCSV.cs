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
            string[] FileLines = File.ReadAllLines(CSVPath);
            int count = FileLines.Length;

            String myJSON = "{";
            //Now, lets step through the Array and build a JSON
            for (int i = 0; i < count; i++ )
            {
                MessageBox.Show(FileLines[i]);
            }



                return "";
        }

        public String toCSV(String MyMilageReport)
        {
            return "";
        }
    }
}
