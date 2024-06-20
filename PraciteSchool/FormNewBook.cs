using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraciteSchool
{
    public partial class FormNewBook : Form
    {
        public FormNewBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string day, month, year, generalDate;

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(FormTakeBook.TxtCon);
            Con.Open();
            using (SqlCommand Cmd = new SqlCommand("INSERT INTO AddBook (TitleNew, AuthorNew, DatePublishNew, PublisherNew) VALUES (@TitleNew, @AuthorNew, @DatePublishNew, @PublisherNew)", Con))
            {
                Cmd.Parameters.AddWithValue("@TitleNew", TbxTitle.Text);
                Cmd.Parameters.AddWithValue("@AuthorNew", TbxAuthor.Text);
                Cmd.Parameters.AddWithValue("@DatePublishNew", generalDate);
                Cmd.Parameters.AddWithValue("@PublisherNew", TbxPublisher.Text);
                Cmd.ExecuteNonQuery();
            }
            Con.Close();
            FormInforation Frm = new FormInforation();
            Frm.LblInformation.Text = "Заявка на поступление в состоянии " + "'В обработке'";
            Frm.ShowDialog();
            Thread.Sleep(500);
            this.Close();
        }

        private void TbxTitle_Enter(object sender, EventArgs e)
        {
            if (TbxTitle.Text == "Введите название")
                TbxTitle.Text = "";
        }

        private void TbxTitle_Leave(object sender, EventArgs e)
        {
            if (TbxTitle.Text.Trim() == "")
                TbxTitle.Text = "Введите название";
        }

        private void TbxAuthor_Enter(object sender, EventArgs e)
        {
            if (TbxAuthor.Text == "Введите автора")
                TbxAuthor.Text = "";
        }

        private void TbxAuthor_Leave(object sender, EventArgs e)
        {
            if (TbxAuthor.Text.Trim() == "")
                TbxAuthor.Text = "Введите автора";
        }

        private void TbxPublisher_Enter(object sender, EventArgs e)
        {
            if (TbxPublisher.Text == "Введите издателя")
                TbxPublisher.Text = "";
        }

        private void TbxPublisher_Leave(object sender, EventArgs e)
        {
            if (TbxPublisher.Text.Trim() == "")
                TbxPublisher.Text = "Введите издателя";
        }

        private void FormNewBook_Shown(object sender, EventArgs e)
        {
            Clock.Start();
            this.ActiveControl = null;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            day = selectedDate.Day.ToString();
            month = selectedDate.Month.ToString();
            year = selectedDate.Year.ToString();
            generalDate= day+"-"+month+"-"+year;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            if (TbxTitle.Text.Trim() != "" && TbxTitle.Text != "Введите название")
            {
                if (TbxAuthor.Text.Trim() != "" && TbxAuthor.Text != "Введите автора")
                {
                    if (TbxPublisher.Text.Trim() != "" && TbxPublisher.Text != "Введите издателя")
                    {
                        if (day != "" && month != "" && year != "")
                            BtnAccept.Enabled = true;
                    }  else BtnAccept.Enabled = false;

                } else BtnAccept.Enabled = false;

            }  else BtnAccept.Enabled = false;

        }
    }
}
