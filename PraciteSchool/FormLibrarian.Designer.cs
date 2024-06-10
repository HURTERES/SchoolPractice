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
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnShowTaken = new System.Windows.Forms.Button();
            this.BtnManage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.Location = new System.Drawing.Point(85, 124);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(380, 45);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Книги на хранении";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnTakeBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "Рабочее место библиотекаря";
            // 
            // BtnShowTaken
            // 
            this.BtnShowTaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowTaken.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnShowTaken.Location = new System.Drawing.Point(85, 204);
            this.BtnShowTaken.Name = "BtnShowTaken";
            this.BtnShowTaken.Size = new System.Drawing.Size(380, 45);
            this.BtnShowTaken.TabIndex = 7;
            this.BtnShowTaken.Text = "Просмотр книг на руках";
            this.BtnShowTaken.UseVisualStyleBackColor = true;
            this.BtnShowTaken.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnManage
            // 
            this.BtnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManage.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnManage.Location = new System.Drawing.Point(85, 291);
            this.BtnManage.Name = "BtnManage";
            this.BtnManage.Size = new System.Drawing.Size(380, 45);
            this.BtnManage.TabIndex = 8;
            this.BtnManage.Text = "Управление архивом";
            this.BtnManage.UseVisualStyleBackColor = true;
            this.BtnManage.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PraciteSchool.Properties.Resources.librarian;
            this.pictureBox2.Location = new System.Drawing.Point(558, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PraciteSchool.Properties.Resources.WindowSmall;
            this.pictureBox1.Location = new System.Drawing.Point(558, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(894, 589);
            this.Controls.Add(this.BtnManage);
            this.Controls.Add(this.BtnShowTaken);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Name = "FormLibrarian";
            this.Text = "FormLibrarian";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnShowTaken;
        private System.Windows.Forms.Button BtnManage;
    }
}