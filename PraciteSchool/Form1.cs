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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormLibrarian Frm = new FormLibrarian();
            Frm.ShowDialog();
        }

        private void BtnTakeBook_Click(object sender, EventArgs e)
        {
            FormTakeBook Frm = new FormTakeBook();
            Frm.ShowDialog();
        }
    }
}
