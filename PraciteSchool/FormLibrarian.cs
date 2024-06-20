using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void BtnShowStore_Click(object sender, EventArgs e)
        {
            Flag = false;
            LblNoWords.Visible = false;
            DgvBooks.Columns["StoreWith"].Visible = false;
            DgvBooks.Rows.Clear();
            SqlConnection Con = new SqlConnection(FormTakeBook.TxtCon);
            Con.Open();
            SqlCommand Cmd = new SqlCommand("SELECT         Book.IdBook, Book.Title, Book.Author, Book.DatePublish, Book.Publisher \r\nFROM            Book INNER JOIN\r\n                         Request ON Book.IdBook = Request.IdBook INNER JOIN\r\n                         Status ON Request.IdStatus = Status.IdStatus where Status.Status='Хранится'", Con);
            SqlDataReader Res = Cmd.ExecuteReader();
            if (Res.HasRows)
            {
                while (Res.Read())
                    DgvBooks.Rows.Add(Res["IdBook"], Res["Title"], Res["Author"], Res["DatePublish"], Res["Publisher"]);
            }
            else LblNoWords.Visible = true;

            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShowOnHands_Click(object sender, EventArgs e)
        {
            Flag = false;
            LblNoWords.Visible = false;
            DgvBooks.Rows.Clear();
            SqlConnection Con = new SqlConnection(FormTakeBook.TxtCon);
            Con.Open();
            SqlCommand Cmd = new SqlCommand("SELECT         Book.IdBook, Book.Title, Book.Author, Book.DatePublish, Book.Publisher, Request.FIO \r\nFROM            Book INNER JOIN\r\n                         Request ON Book.IdBook = Request.IdBook INNER JOIN\r\n                         Status ON Request.IdStatus = Status.IdStatus where Status.Status='На руках'", Con);
            SqlDataReader Res = Cmd.ExecuteReader();
            if (Res.HasRows)
            {
                DgvBooks.Columns["StoreWith"].Visible = true;
                while (Res.Read())
                    DgvBooks.Rows.Add(Res["IdBook"], Res["Title"], Res["Author"], Res["DatePublish"], Res["Publisher"], Res["FIO"]);
            }
            else LblNoWords.Visible = true ;
            Con.Close();
        }

        bool Flag=false;
        private void BtnShowNewBook_Click(object sender, EventArgs e)
        {
            LblNoWords.Visible = false;
            DgvBooks.Columns["StoreWith"].Visible = false;
            DgvBooks.Rows.Clear();
            SqlConnection Con = new SqlConnection(FormTakeBook.TxtCon);
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from AddBook", Con);
            SqlDataReader Res = Cmd.ExecuteReader();
            if (Res.HasRows)
                while (Res.Read())
                {
                    DgvBooks.Rows.Add(Res["IdNewBook"], Res["TitleNew"], Res["AuthorNew"], Res["DatePublishNew"], Res["PublisherNew"]);
                }
            else LblNoWords.Visible = true;
            Con.Close();
            Flag = true;
        }

        string IdBook1, Title1, Author1, DatePublish1, Publisher1;

        private void BtnNewBook_Click(object sender, EventArgs e)
        {
            FormNewBook Frm = new FormNewBook();
            Frm.ShowDialog();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FormTakeBook.TxtCon))
            {
                Con.Open();
                string query = $"insert into Book (Title = @Title, Author = @Author, DatePublish = @DatePublish, Publisher = @Publisher) values ('{Title1}','{Author1}','{DatePublish1}', '{Publisher1}' )";

                using (SqlCommand Cmd = new SqlCommand("INSERT INTO Book (Title, Author, DatePublish, Publisher) VALUES (@Title, @Author, @DatePublish, @Publisher)", Con))
                {
                    Cmd.Parameters.AddWithValue("@Title", Title1);
                    Cmd.Parameters.AddWithValue("@Author", Author1);
                    Cmd.Parameters.AddWithValue("@DatePublish", DatePublish1);
                    Cmd.Parameters.AddWithValue("@Publisher", Publisher1);
                    Cmd.ExecuteNonQuery();
                }

                using (SqlCommand Cmd = new SqlCommand("INSERT INTO Request (IdBook, IdStatus) VALUES (@IdBook, @IdStatus)", Con))
                {
                    Cmd.Parameters.AddWithValue("@IdBook", IdBook1);
                    Cmd.Parameters.AddWithValue("@IdStatus", "1");
                    Cmd.ExecuteNonQuery();
                }

                using (SqlCommand Cmd = new SqlCommand($"delete from AddBook where IdNewBook={IdBook1}", Con))
                    Cmd.ExecuteNonQuery();

                using (SqlCommand selectCmd = new SqlCommand("SELECT * FROM AddBook", Con))
                {
                    using (SqlDataReader Res = selectCmd.ExecuteReader())
                    {
                        DgvBooks.Rows.Clear();
                        if (Res.HasRows)
                            while (Res.Read())
                                DgvBooks.Rows.Add(Res["IdNewBook"], Res["TitleNew"], Res["AuthorNew"], Res["DatePublishNew"], Res["PublisherNew"]);
                        else
                            LblNoWords.Visible = true;
                    }
                }
                Con.Close();
                BtnAccept.Visible = false;
            }

            FormInforation Frm = new FormInforation();
            Frm.LblInformation.Text = "Новая книга успешно авторизирована в системе";
            Frm.ShowDialog();
        }

        private void DgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DgvBooks.Rows[e.RowIndex];

                IdBook1 = selectedRow.Cells["idBook"].Value.ToString();
                Title1 = selectedRow.Cells["Title"].Value.ToString();
                Author1 = selectedRow.Cells["Author"].Value.ToString();
                DatePublish1 = selectedRow.Cells["DatePublish"].Value.ToString();
                Publisher1 = selectedRow.Cells["Publisher"].Value.ToString();
                if(Flag==true)
                BtnAccept.Visible = true;
                else BtnAccept.Visible = false;
            }
        }
    }
}
