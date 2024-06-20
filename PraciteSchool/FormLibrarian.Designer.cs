namespace PraciteSchool
{
    partial class FormLibrarian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnShowStore = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.BtnShowOnHands = new System.Windows.Forms.Button();
            this.BtnShowNewBook = new System.Windows.Forms.Button();
            this.BtnNewBook = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.IdBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePublish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblNoWords = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowStore
            // 
            this.BtnShowStore.BackColor = System.Drawing.SystemColors.Window;
            this.BtnShowStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowStore.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnShowStore.Location = new System.Drawing.Point(12, 85);
            this.BtnShowStore.Name = "BtnShowStore";
            this.BtnShowStore.Size = new System.Drawing.Size(364, 43);
            this.BtnShowStore.TabIndex = 51;
            this.BtnShowStore.Text = "Отобразить книги на хранении";
            this.BtnShowStore.UseVisualStyleBackColor = false;
            this.BtnShowStore.Click += new System.EventHandler(this.BtnShowStore_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1127, 79);
            this.panel3.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рабочее место библиотекаря";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvBooks.ColumnHeadersHeight = 30;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBook,
            this.Title,
            this.Author,
            this.DatePublish,
            this.Publisher,
            this.StoreWith});
            this.DgvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBooks.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvBooks.EnableHeadersVisualStyles = false;
            this.DgvBooks.GridColor = System.Drawing.Color.White;
            this.DgvBooks.Location = new System.Drawing.Point(12, 134);
            this.DgvBooks.MultiSelect = false;
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvBooks.RowHeadersVisible = false;
            this.DgvBooks.RowTemplate.Height = 30;
            this.DgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBooks.Size = new System.Drawing.Size(1103, 431);
            this.DgvBooks.TabIndex = 53;
            this.DgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBooks_CellClick);
            // 
            // BtnShowOnHands
            // 
            this.BtnShowOnHands.BackColor = System.Drawing.SystemColors.Window;
            this.BtnShowOnHands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowOnHands.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnShowOnHands.Location = new System.Drawing.Point(382, 85);
            this.BtnShowOnHands.Name = "BtnShowOnHands";
            this.BtnShowOnHands.Size = new System.Drawing.Size(364, 43);
            this.BtnShowOnHands.TabIndex = 54;
            this.BtnShowOnHands.Text = "Отобразить книги на руках";
            this.BtnShowOnHands.UseVisualStyleBackColor = false;
            this.BtnShowOnHands.Click += new System.EventHandler(this.BtnShowOnHands_Click);
            // 
            // BtnShowNewBook
            // 
            this.BtnShowNewBook.BackColor = System.Drawing.SystemColors.Window;
            this.BtnShowNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowNewBook.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnShowNewBook.Location = new System.Drawing.Point(752, 85);
            this.BtnShowNewBook.Name = "BtnShowNewBook";
            this.BtnShowNewBook.Size = new System.Drawing.Size(364, 43);
            this.BtnShowNewBook.TabIndex = 55;
            this.BtnShowNewBook.Text = "В обработке на поступление";
            this.BtnShowNewBook.UseVisualStyleBackColor = false;
            this.BtnShowNewBook.Click += new System.EventHandler(this.BtnShowNewBook_Click);
            // 
            // BtnNewBook
            // 
            this.BtnNewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNewBook.BackColor = System.Drawing.Color.Bisque;
            this.BtnNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewBook.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewBook.Location = new System.Drawing.Point(12, 571);
            this.BtnNewBook.Name = "BtnNewBook";
            this.BtnNewBook.Size = new System.Drawing.Size(397, 43);
            this.BtnNewBook.TabIndex = 56;
            this.BtnNewBook.Text = "Добавить заявку на поступление книг";
            this.BtnNewBook.UseVisualStyleBackColor = false;
            this.BtnNewBook.Click += new System.EventHandler(this.BtnNewBook_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccept.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAccept.Location = new System.Drawing.Point(815, 571);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(300, 43);
            this.BtnAccept.TabIndex = 57;
            this.BtnAccept.Text = "Подтвердить поступление";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Visible = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // IdBook
            // 
            this.IdBook.HeaderText = "№ Книги";
            this.IdBook.Name = "IdBook";
            this.IdBook.ReadOnly = true;
            this.IdBook.Width = 50;
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
            // Publisher
            // 
            this.Publisher.HeaderText = "Издатель";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 160;
            // 
            // StoreWith
            // 
            this.StoreWith.HeaderText = "На руках у";
            this.StoreWith.Name = "StoreWith";
            this.StoreWith.ReadOnly = true;
            this.StoreWith.Visible = false;
            this.StoreWith.Width = 120;
            // 
            // LblNoWords
            // 
            this.LblNoWords.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNoWords.Location = new System.Drawing.Point(322, 178);
            this.LblNoWords.Name = "LblNoWords";
            this.LblNoWords.Size = new System.Drawing.Size(506, 44);
            this.LblNoWords.TabIndex = 58;
            this.LblNoWords.Text = "Нет удовлетворяющих записей";
            this.LblNoWords.Visible = false;
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
            // FormLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 622);
            this.Controls.Add(this.LblNoWords);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnNewBook);
            this.Controls.Add(this.BtnShowNewBook);
            this.Controls.Add(this.BtnShowOnHands);
            this.Controls.Add(this.DgvBooks);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnShowStore);
            this.MinimumSize = new System.Drawing.Size(1143, 661);
            this.Name = "FormLibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLibrarian";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnShowStore;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Button BtnShowOnHands;
        private System.Windows.Forms.Button BtnShowNewBook;
        private System.Windows.Forms.Button BtnNewBook;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePublish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreWith;
        private System.Windows.Forms.Label LblNoWords;
    }
}