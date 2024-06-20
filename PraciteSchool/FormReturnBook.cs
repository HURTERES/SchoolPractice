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
    public partial class FormReturnBook : Form
    {
        public FormReturnBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TbxFIO_Enter(object sender, EventArgs e)
        {

                if (TbxFIO.Text == "Введите ФИО")
                    TbxFIO.Text = "";
            TbxFIO.MouseLeave += TbxFIO_MouseLeave;
        }

        private void TbxFIO_MouseLeave(object sender, EventArgs e)
        {
            DgvBooks.Rows.Clear();
            SqlConnection Con = new SqlConnection(FormTakeBook.TxtCon);
            Con.Open();
            SqlCommand Cmd = new SqlCommand($"SELECT         Book.IdBook, Book.Title, Book.Author, Book.DatePublish\r\nFROM            Book INNER JOIN\r\n                         Request ON Book.IdBook = Request.IdBook INNER JOIN\r\n                         Status ON Request.IdStatus = Status.IdStatus where Status.Status='На руках' and FIO='{TbxFIO.Text.Trim()}'", Con);
            SqlDataReader Res = Cmd.ExecuteReader();
            if (Res.HasRows)
                while (Res.Read())
                {
                    DgvBooks.Rows.Add(Res["IdBook"], Res["Title"], Res["Author"], Res["DatePublish"]);
                }
            Con.Close();
        }

        private void TbxFIO_Leave(object sender, EventArgs e)
        {
                if (TbxFIO.Text.Trim() == "")
                    TbxFIO.Text = "Введите ФИО";
        }

        private void TbxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                TbxFIO_MouseLeave(null,null);

        }

        string IdBook1, Title1, Author1, DatePublish1;

        private void BtnReturnCurrent_Click(object sender, EventArgs e)
        {
            int Day = DateTime.Now.Day;
            int Month = DateTime.Now.Month;
            int Year = DateTime.Now.Year;

            string Dt;
            if (Month < 10)
                Dt = $"{Day}-0{Month}-{Year}";
            else
                Dt = $"{Day}-{Month}-{Year}";
            using (SqlConnection Con = new SqlConnection(FormTakeBook.TxtCon))
            {
                Con.Open();
                string query = "UPDATE Request " +
           "SET IdStatus = 1, DateReturned = @DateReturned, FIO = @FIO " +
           "FROM Request " +
           "JOIN Book ON Request.IdBook = Book.IdBook " +
           "WHERE Book.IdBook = @IdBook1";
                using (SqlCommand Cmd = new SqlCommand(query, Con))
                {
                    Cmd.Parameters.AddWithValue("@DateReturned", Dt);
                    Cmd.Parameters.AddWithValue("@IdBook1", IdBook1);
                    Cmd.Parameters.AddWithValue("@FIO", TbxFIO.Text);
                    Cmd.ExecuteNonQuery();
                }
                Con.Close();
            }

            FormInforation Frm = new FormInforation();
            Frm.LblInformation.Text = "Вы можете вернуть книгу в библиотеку в течение следующих 5 рабочих дней.";
            TbxFIO_MouseLeave(null,null);
            Frm.ShowDialog();
            BtnReturnCurrent.Enabled = false;
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
                BtnReturnCurrent.Enabled = true;
            }
        }
    }
}
