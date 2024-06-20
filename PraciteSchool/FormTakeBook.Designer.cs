namespace PraciteSchool
{
    partial class FormTakeBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.IdBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePublish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTakeCurrent = new System.Windows.Forms.Button();
            this.PanelTake = new System.Windows.Forms.Panel();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxFIO = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbxNumClass = new System.Windows.Forms.RichTextBox();
            this.BsBooks = new System.Windows.Forms.BindingSource(this.components);
            this.practice_Library2024DataSet = new PraciteSchool.Practice_Library2024DataSet();
            this.bookTableAdapter = new PraciteSchool.Practice_Library2024DataSetTableAdapters.BookTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.PanelTake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practice_Library2024DataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Библиотека МБОУ СОШ \"№4\"";
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AllowUserToDeleteRows = false;
            this.DgvBooks.AllowUserToResizeColumns = false;
            this.DgvBooks.AllowUserToResizeRows = false;
            this.DgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBooks.ColumnHeadersHeight = 30;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBook,
            this.Title,
            this.Author,
            this.DatePublish});
            this.DgvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBooks.EnableHeadersVisualStyles = false;
            this.DgvBooks.GridColor = System.Drawing.Color.White;
            this.DgvBooks.Location = new System.Drawing.Point(368, 39);
            this.DgvBooks.MultiSelect = false;
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBooks.RowHeadersVisible = false;
            this.DgvBooks.RowTemplate.Height = 30;
            this.DgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBooks.Size = new System.Drawing.Size(698, 392);
            this.DgvBooks.TabIndex = 38;
            this.DgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBooks_CellClick);
            // 
            // IdBook
            // 
            this.IdBook.HeaderText = "IdBook";
            this.IdBook.Name = "IdBook";
            this.IdBook.ReadOnly = true;
            this.IdBook.Visible = false;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 180;
            // 
            // DatePublish
            // 
            this.DatePublish.HeaderText = "Публикация";
            this.DatePublish.Name = "DatePublish";
            this.DatePublish.ReadOnly = true;
            this.DatePublish.Width = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.label2.Location = new System.Drawing.Point(363, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Список предложенных книг:";
            // 
            // BtnTakeCurrent
            // 
            this.BtnTakeCurrent.BackColor = System.Drawing.SystemColors.Window;
            this.BtnTakeCurrent.Enabled = false;
            this.BtnTakeCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTakeCurrent.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTakeCurrent.Location = new System.Drawing.Point(12, 83);
            this.BtnTakeCurrent.Name = "BtnTakeCurrent";
            this.BtnTakeCurrent.Size = new System.Drawing.Size(322, 45);
            this.BtnTakeCurrent.TabIndex = 40;
            this.BtnTakeCurrent.Text = "Взять выбранную книгу";
            this.BtnTakeCurrent.UseVisualStyleBackColor = false;
            this.BtnTakeCurrent.Click += new System.EventHandler(this.BtnTakeCurrent_Click);
            // 
            // PanelTake
            // 
            this.PanelTake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTake.Controls.Add(this.BtnAccept);
            this.PanelTake.Controls.Add(this.panel2);
            this.PanelTake.Controls.Add(this.TbxFIO);
            this.PanelTake.Controls.Add(this.panel1);
            this.PanelTake.Controls.Add(this.TbxNumClass);
            this.PanelTake.Controls.Add(this.label2);
            this.PanelTake.Controls.Add(this.BtnTakeCurrent);
            this.PanelTake.Controls.Add(this.DgvBooks);
            this.PanelTake.Location = new System.Drawing.Point(12, 85);
            this.PanelTake.Name = "PanelTake";
            this.PanelTake.Size = new System.Drawing.Size(1069, 434);
            this.PanelTake.TabIndex = 41;
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAccept.Location = new System.Drawing.Point(89, 306);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(178, 41);
            this.BtnAccept.TabIndex = 45;
            this.BtnAccept.Text = "Подтвердить";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Visible = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 2);
            this.panel2.TabIndex = 44;
            // 
            // TbxFIO
            // 
            this.TbxFIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxFIO.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFIO.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TbxFIO.Location = new System.Drawing.Point(16, 218);
            this.TbxFIO.Name = "TbxFIO";
            this.TbxFIO.Size = new System.Drawing.Size(318, 34);
            this.TbxFIO.TabIndex = 43;
            this.TbxFIO.Text = "Введите ФИО";
            this.TbxFIO.Visible = false;
            this.TbxFIO.Enter += new System.EventHandler(this.TbxFIO_Enter);
            this.TbxFIO.Leave += new System.EventHandler(this.TbxFIO_Leave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 2);
            this.panel1.TabIndex = 42;
            // 
            // TbxNumClass
            // 
            this.TbxNumClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxNumClass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxNumClass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TbxNumClass.Location = new System.Drawing.Point(16, 164);
            this.TbxNumClass.Name = "TbxNumClass";
            this.TbxNumClass.Size = new System.Drawing.Size(318, 34);
            this.TbxNumClass.TabIndex = 41;
            this.TbxNumClass.Text = "Введите класс";
            this.TbxNumClass.Visible = false;
            this.TbxNumClass.Enter += new System.EventHandler(this.TbxNumClass_Enter);
            this.TbxNumClass.Leave += new System.EventHandler(this.TbxNumClass_Leave);
            // 
            // BsBooks
            // 
            this.BsBooks.DataMember = "Book";
            this.BsBooks.DataSource = this.practice_Library2024DataSet;
            // 
            // practice_Library2024DataSet
            // 
            this.practice_Library2024DataSet.DataSetName = "Practice_Library2024DataSet";
            this.practice_Library2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 79);
            this.panel3.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PraciteSchool.Properties.Resources.Escape;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 525);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 10);
            this.panel4.TabIndex = 44;
            // 
            // FormTakeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 535);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelTake);
            this.Name = "FormTakeBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTakeBook";
            this.Load += new System.EventHandler(this.FormTakeBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.PanelTake.ResumeLayout(false);
            this.PanelTake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practice_Library2024DataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnTakeCurrent;
        private System.Windows.Forms.Panel PanelTake;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox TbxFIO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TbxNumClass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource BsBooks;
        private Practice_Library2024DataSet practice_Library2024DataSet;
        private Practice_Library2024DataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePublish;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}