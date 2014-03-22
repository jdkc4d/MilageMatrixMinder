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

            string[] headers = Locations[0].Split(',');
            String myJSON = "{";
            //Now, lets step through the Array and build a JSON
            for (int i = 1; i < count; i++ )
            {
                myJSON += "{";
                //MessageBox.Show(Locations[i]);
                //Then step through each of the other lines and append to the JSON
                String[] Office = Locations[i].Split(',');
                for (int j = 0; j < headers.Length; j++)
                {
                    myJSON += "\"" + headers[j]+"\":\"" + Office[j] + "\"";
                    if (j != headers.Length - 1) myJSON += ",";
                }
                myJSON += "}";
                if (i == count - 1)
                {
                    //At the end
                    myJSON += "}";
                }
                else myJSON += ",";
            }
            //MessageBox.Show(myJSON);
            return myJSON;
        }

        public String toCSV(String MyMilageReport)
        {
            return "";
        }
    }
}
