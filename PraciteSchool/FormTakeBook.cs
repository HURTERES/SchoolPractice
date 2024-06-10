using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraciteSchool
{
    public partial class FormTakeBook : Form
    {
        public FormTakeBook()
        {
            InitializeComponent();
        }

        private void BtnTakeCurrent_Click(object sender, EventArgs e)
        {
            TbxFIO.Visible = true;
            TbxNumClass.Visible = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            DgvBooks.Enabled = false;
        }
    }
}
