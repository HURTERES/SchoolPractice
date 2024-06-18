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
    public partial class FormInforation : Form
    {
        public FormInforation()
        {
            InitializeComponent();
        }

        private void FormInforation_Load(object sender, EventArgs e)
        {
            TimerClose.Start();
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
