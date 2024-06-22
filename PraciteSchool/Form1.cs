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
            PanelLogin.Visible = true;
        }

        private void BtnTakeBook_Click(object sender, EventArgs e)
        {
            FormTakeBook Frm = new FormTakeBook();
            this.Hide();
            Frm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReturnBook Frm = new FormReturnBook();
            this.Hide();
            Frm.ShowDialog();
            this.Show();
        }

        private void Track_MouseUp(object sender, MouseEventArgs e)
        {
            LblPin.Text += Track.Value.ToString();
            if (LblPin.Text == "322")
            {
                LblPin.Text ="";
                PanelLogin.Visible = false;
                Track.Value = 0;
                FormLibrarian Frm = new FormLibrarian();
                Frm.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LblPin.Text = "";
            PanelLogin.Visible = false;
            Track.Value = 0;
        }
    }
}
