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
    public partial class FormLibrarian : Form
    {
        public FormLibrarian()
        {
            InitializeComponent();
        }

        private void BtnTakeBook_Click(object sender, EventArgs e)
        {
            // BtnSave (Книги на хранении)
            FormBooks Frm = new FormBooks();
            Frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BtnShowTaken (Просмотр книг на руках)
            FormBooks Frm = new FormBooks();
            Frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // BtnManage (Управление архивом)
            FormBooks Frm = new FormBooks();
            Frm.ShowDialog();
        }
    }
}
