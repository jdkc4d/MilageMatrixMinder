using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
