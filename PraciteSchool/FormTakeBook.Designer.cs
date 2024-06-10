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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTakeCurrent = new System.Windows.Forms.Button();
            this.PanelTake = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbxNumClass = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxFIO = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.PanelTake.SuspendLayout();
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
            this.DgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvBooks.ColumnHeadersHeight = 30;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DgvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBooks.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgvBooks.EnableHeadersVisualStyles = false;
            this.DgvBooks.GridColor = System.Drawing.Color.White;
            this.DgvBooks.Location = new System.Drawing.Point(8, 32);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvBooks.RowHeadersVisible = false;
            this.DgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBooks.Size = new System.Drawing.Size(698, 392);
            this.DgvBooks.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.label2.Location = new System.Drawing.Point(18, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Список предложенных книг:";
            // 
            // BtnTakeCurrent
            // 
            this.BtnTakeCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTakeCurrent.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTakeCurrent.Location = new System.Drawing.Point(736, 52);
            this.BtnTakeCurrent.Name = "BtnTakeCurrent";
            this.BtnTakeCurrent.Size = new System.Drawing.Size(322, 45);
            this.BtnTakeCurrent.TabIndex = 40;
            this.BtnTakeCurrent.Text = "Взять выбранную";
            this.BtnTakeCurrent.UseVisualStyleBackColor = true;
            this.BtnTakeCurrent.Click += new System.EventHandler(this.BtnTakeCurrent_Click);
            // 
            // PanelTake
            // 
            this.PanelTake.Controls.Add(this.panel2);
            this.PanelTake.Controls.Add(this.TbxFIO);
            this.PanelTake.Controls.Add(this.panel1);
            this.PanelTake.Controls.Add(this.TbxNumClass);
            this.PanelTake.Controls.Add(this.label2);
            this.PanelTake.Controls.Add(this.BtnTakeCurrent);
            this.PanelTake.Controls.Add(this.DgvBooks);
            this.PanelTake.Location = new System.Drawing.Point(12, 85);
            this.PanelTake.Name = "PanelTake";
            this.PanelTake.Size = new System.Drawing.Size(1078, 446);
            this.PanelTake.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(736, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 2);
            this.panel1.TabIndex = 42;
            // 
            // TbxNumClass
            // 
            this.TbxNumClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxNumClass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxNumClass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TbxNumClass.Location = new System.Drawing.Point(740, 133);
            this.TbxNumClass.Name = "TbxNumClass";
            this.TbxNumClass.Size = new System.Drawing.Size(318, 34);
            this.TbxNumClass.TabIndex = 41;
            this.TbxNumClass.Text = "Введите класс";
            this.TbxNumClass.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(736, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 2);
            this.panel2.TabIndex = 44;
            // 
            // TbxFIO
            // 
            this.TbxFIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxFIO.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFIO.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TbxFIO.Location = new System.Drawing.Point(740, 187);
            this.TbxFIO.Name = "TbxFIO";
            this.TbxFIO.Size = new System.Drawing.Size(318, 34);
            this.TbxFIO.TabIndex = 43;
            this.TbxFIO.Text = "Введите ФИО";
            this.TbxFIO.Visible = false;
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
            // 
            // FormTakeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelTake);
            this.Controls.Add(this.label1);
            this.Name = "FormTakeBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTakeBook";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.PanelTake.ResumeLayout(false);
            this.PanelTake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnTakeCurrent;
        private System.Windows.Forms.Panel PanelTake;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox TbxFIO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TbxNumClass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}