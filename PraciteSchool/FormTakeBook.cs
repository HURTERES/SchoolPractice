using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            if (BtnTakeCurrent.Text == "Взять выбранную книгу")
            {
                TbxFIO.Visible = true;
                TbxNumClass.Visible = true;
                panel1.BorderStyle = BorderStyle.FixedSingle;
                panel2.BorderStyle = BorderStyle.FixedSingle;
                DgvBooks.Enabled = false;
                BtnAccept.Visible = true;
                BtnTakeCurrent.Text = "Выбрать другую книгу";
            }
            else
            {
                TbxFIO.Visible = false;
                TbxNumClass.Visible = false;
                panel1.BorderStyle = BorderStyle.None;
                panel2.BorderStyle = BorderStyle.None;
                DgvBooks.Enabled = true;
                BtnAccept.Visible = false;
                BtnTakeCurrent.Text = "Взять выбранную книгу";
                TbxNumClass.ForeColor = Color.Black;
                TbxFIO.ForeColor = Color.Black;
            }
        }


        string TxtCon = "Data Source=213.155.192.79,3002;Initial Catalog=Practice_Library2024;Persist Security Info=True;User ID=u22vasiltsov;Password=etz7";
        private void FormTakeBook_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(TxtCon);
            Con.Open();
            SqlCommand Cmd = new SqlCommand("SELECT         Book.IdBook, Book.Title, Book.Author, Book.DatePublish\r\nFROM            Book INNER JOIN\r\n                         Request ON Book.IdBook = Request.IdBook INNER JOIN\r\n                         Status ON Request.IdStatus = Status.IdStatus where Status.Status='Хранится'", Con);
            SqlDataReader Res = Cmd.ExecuteReader();
            if(Res.HasRows)
                while(Res.Read())
                {
                    DgvBooks.Rows.Add(Res["IdBook"], Res["Title"], Res["Author"],Res["DatePublish"]);
                }
            Con.Close();

        }

        public static string IdBook1, Title1, Author1, DatePublish1;

        private void TbxNumClass_Leave(object sender, EventArgs e)
        {
            if (TbxNumClass.Text == "")
                TbxNumClass.Text = "Введите класс";
        }

        private void TbxFIO_Enter(object sender, EventArgs e)
        {
            if (TbxFIO.Text == "Введите ФИО")
                TbxFIO.Text = "";
            TbxFIO.ForeColor = Color.Black;
        }

        private void TbxFIO_Leave(object sender, EventArgs e)
        {
            if (TbxFIO.Text =="")
                TbxFIO.Text = "Введите ФИО";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void TbxNumClass_Enter(object sender, EventArgs e)
        {
            if (TbxNumClass.Text == "Введите класс")
                TbxNumClass.Text = "";
            TbxNumClass.ForeColor = Color.Black;
        }

        private void DgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DgvBooks.Rows[e.RowIndex];

                // Получаем значения ячеек выбранной строки
                IdBook1 = selectedRow.Cells["idBook"].Value.ToString();
                Title1 = selectedRow.Cells["Title"].Value.ToString();
                Author1 = selectedRow.Cells["Author"].Value.ToString();
                DatePublish1 = selectedRow.Cells["DatePublish"].Value.ToString();
                BtnTakeCurrent.Enabled = true;
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (TbxFIO.Text == "Введите ФИО" || TbxNumClass.Text == "Введите класс")
            {
                if(TbxFIO.Text== "Введите ФИО")
                    TbxFIO.ForeColor = Color.Red;
                if (TbxNumClass.Text == "Введите класс")
                    TbxNumClass.ForeColor = Color.Red;
            }
            else
            {
                if (!(ContainsNumberInRange(TbxNumClass.Text)))
                {
                    TbxNumClass.ForeColor= Color.Red;
                    return;
                }
                if (!TbxFIO.Text.Contains(" "))
                {
                    TbxFIO.ForeColor = Color.Red;
                    return;
                }

                int Day = DateTime.Now.Day;
                int Month = DateTime.Now.Month;
                int Year = DateTime.Now.Year;

                string Dt;
                    if (Month < 10)
                        Dt = $"{Day}-0{Month}-{Year}";
                    else
                        Dt = $"{Day}-{Month}-{Year}";
                using (SqlConnection Con = new SqlConnection(TxtCon))
                {
                    Con.Open();
                    string query = "UPDATE Request " +
               "SET IdStatus = 2, DateTaken = @DateTaken, FIO = @FIO " +
               "FROM Request " +
               "JOIN Book ON Request.IdBook = Book.IdBook " +
               "WHERE Book.IdBook = @IdBook1";
                    using (SqlCommand Cmd = new SqlCommand(query, Con))
                    {
                        Cmd.Parameters.AddWithValue("@DateTaken", Dt);
                        Cmd.Parameters.AddWithValue("@IdBook1", IdBook1);
                        Cmd.Parameters.AddWithValue("@FIO", TbxFIO.Text);
                        Cmd.ExecuteNonQuery();
                    }
                    Con.Close();
                }

                FormInforation Frm = new FormInforation();
                Frm.ShowDialog();
                this.Close();
            }
        }
        static bool ContainsNumberInRange(string text)
        {
            if (int.TryParse(text, out int number))
                return number >= 1 && number <= 11;
            else
                return false;
        }
    }
}
