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
            this.MilageMatrix = myCSV.ToJSON(ofd_MilageMatrix.FileName);
            //MessageBox.Show(MilageMatrix);
            //Save the matrix to a JSON file
            try
            {
                String CurrentDirectory = Directory.GetCurrentDirectory();
                StreamWriter NewFile = new StreamWriter(CurrentDirectory + "\\MilageMatrix.json");
                NewFile.Write(this.MilageMatrix);
                NewFile.Flush();
            }
            catch (UnauthorizedAccessException yikes)
            {
                MessageBox.Show("You have insufficient rights to save documents here.", "Unauthorized Access");
            }

            //I need a method to verify the file was created before continuing...
            if(CheckforJSONMatirx())
            {
                //Run code to populate drop downs
                Populate_Locations();
            }
            else
            {
                //Could not access the json file
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //Check to see if there is an existing Milage Report in the running directory
            if (CheckforJSONMatirx())
            {
                //Run code to populate drop downs
                Populate_Locations();
            }
            else
            {
                //Could not access the json file
            }
        }
        
        private Boolean CheckforJSONMatirx()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\MilageMatrix.json"))
            {
                tb_MilageMatrix.Text = "Matrix Loaded";
                tb_MilageMatrix.Enabled = false;

                //Enable the append features
                dtp_AddMilage.Enabled = true;
                cb_StartLocation.Enabled = true;
                cb_EndLocation.Enabled = true;
                btn_AppendMilageReport.Enabled = true;

                return true;
            }
            else return false;
        }

        private void btn_ExportCSV_Click(object sender, EventArgs e)
        {
            
        }
        private void Populate_Locations()
        {
            //We now have the json file Matrix. Next step is to utilize the json and populate the location drop downs
            cb_StartLocation.Items.Add("Start Location");
            cb_StartLocation.SelectedItem = "Start Location";
            cb_EndLocation.Items.Add("End Location");
            cb_EndLocation.SelectedItem = "End Location";
        }
    }
}
