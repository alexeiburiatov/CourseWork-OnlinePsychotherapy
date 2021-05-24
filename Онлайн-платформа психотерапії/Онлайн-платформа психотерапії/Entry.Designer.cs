namespace Онлайн_платформа_психотерапії
{
    partial class Entry
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(687, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ToMainForm
            // 
            this.ToMainForm.BackColor = System.Drawing.Color.Transparent;
            this.ToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToMainForm.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainForm.Location = new System.Drawing.Point(310, 184);
            this.ToMainForm.Name = "ToMainForm";
            this.ToMainForm.Size = new System.Drawing.Size(227, 83);
            this.ToMainForm.TabIndex = 7;
            this.ToMainForm.Text = "Увійти в систему";
            this.ToMainForm.UseVisualStyleBackColor = false;
            this.ToMainForm.Click += new System.EventHandler(this.ToMainForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 133);
            this.label1.MaximumSize = new System.Drawing.Size(595, 23);
            this.label1.MinimumSize = new System.Drawing.Size(595, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Онлайн-платформа психотерапії \"Рука допомоги\"";
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToMainForm);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(829, 477);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(829, 477);
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Онлайн-платформа психотерапії";
            this.Load += new System.EventHandler(this.Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ToMainForm;
        private System.Windows.Forms.Label label1;
    }
}

