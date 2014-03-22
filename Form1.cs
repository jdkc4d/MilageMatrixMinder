using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Milage_Matrix_Minder
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_MilageMatrix_Click(object sender, EventArgs e)
        {
            if(ofd_MilageMatrix.ShowDialog() == DialogResult.OK)
            {
                tb_MilageMatrix.Text = ofd_MilageMatrix.FileName;
            }
            btn_MatrixMinderSubmit.Enabled = true;
        }

        private void btn_MatrixMinderSubmit_Click(object sender, EventArgs e)
        {
            //Process the CSV and turn into JSON
            ReadWriteCSV myCSV = new ReadWriteCSV();
            String JSON = myCSV.ToJSON(ofd_MilageMatrix.FileName);
            MessageBox.Show(JSON);
            //Save the matrix to a JSON file
            try
            {
                String CurrentDirectory = Directory.GetCurrentDirectory();
                StreamWriter NewFile = new StreamWriter(CurrentDirectory + "\\MilageMatrix.json");
                NewFile.Write(JSON);
                NewFile.Flush();
            }
            catch (UnauthorizedAccessException yikes)
            {
                MessageBox.Show("You have insufficient rights to save documents here.", "Unauthorized Access");
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //Check to see if there is a MilageMatrix file in the running directory, look for JSON, not csv
            //Check to see if there is an existing Milage Report in the running directory
            //Update Progress bar accordingly.


        }

        private void btn_ExportCSV_Click(object sender, EventArgs e)
        {
            //Build a file, to export the current report to a CSV
        }
    }
}
