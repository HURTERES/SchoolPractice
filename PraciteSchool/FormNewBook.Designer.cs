namespace PraciteSchool
{
    partial class FormNewBook
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxTitle = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbxAuthor = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TbxPublisher = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(51, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 2);
            this.panel2.TabIndex = 51;
            // 
            // TbxTitle
            // 
            this.TbxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TbxTitle.Location = new System.Drawing.Point(55, 132);
            this.TbxTitle.Multiline = false;
            this.TbxTitle.Name = "TbxTitle";
            this.TbxTitle.Size = new System.Drawing.Size(350, 34);
            this.TbxTitle.TabIndex = 50;
            this.TbxTitle.Text = "Введите название";
            this.TbxTitle.Enter += new System.EventHandler(this.TbxTitle_Enter);
            this.TbxTitle.Leave += new System.EventHandler(this.TbxTitle_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 79);
            this.panel3.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление книги в библиотеку";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(51, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 2);
            this.panel1.TabIndex = 54;
            // 
            // TbxAuthor
            // 
            this.TbxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxAuthor.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxAuthor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TbxAuthor.Location = new System.Drawing.Point(55, 200);
            this.TbxAuthor.Multiline = false;
            this.TbxAuthor.Name = "TbxAuthor";
            this.TbxAuthor.Size = new System.Drawing.Size(350, 34);
            this.TbxAuthor.TabIndex = 53;
            this.TbxAuthor.Text = "Введите автора";
            this.TbxAuthor.Enter += new System.EventHandler(this.TbxAuthor_Enter);
            this.TbxAuthor.Leave += new System.EventHandler(this.TbxAuthor_Leave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(51, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 2);
            this.panel4.TabIndex = 56;
            // 
            // TbxPublisher
            // 
            this.TbxPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPublisher.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPublisher.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TbxPublisher.Location = new System.Drawing.Point(55, 271);
            this.TbxPublisher.Multiline = false;
            this.TbxPublisher.Name = "TbxPublisher";
            this.TbxPublisher.Size = new System.Drawing.Size(350, 34);
            this.TbxPublisher.TabIndex = 55;
            this.TbxPublisher.Text = "Введите издателя";
            this.TbxPublisher.Enter += new System.EventHandler(this.TbxPublisher_Enter);
            this.TbxPublisher.Leave += new System.EventHandler(this.TbxPublisher_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(463, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Выберите дату издательства";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(518, 146);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 57;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.SystemColors.Window;
            this.BtnAccept.Enabled = false;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAccept.Location = new System.Drawing.Point(248, 331);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(394, 45);
            this.BtnAccept.TabIndex = 58;
            this.BtnAccept.Text = "Оставить заявку на поступление";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.BtnAccept);
            this.panel5.Controls.Add(this.TbxTitle);
            this.panel5.Controls.Add(this.monthCalendar1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.TbxAuthor);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.TbxPublisher);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(864, 389);
            this.panel5.TabIndex = 59;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(51, 232);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(349, 2);
            this.panel6.TabIndex = 59;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(51, 164);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(349, 2);
            this.panel7.TabIndex = 60;
            // 
            // FormNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(870, 396);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewBook";
            this.Shown += new System.EventHandler(this.FormNewBook_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox TbxTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TbxAuthor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox TbxPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}