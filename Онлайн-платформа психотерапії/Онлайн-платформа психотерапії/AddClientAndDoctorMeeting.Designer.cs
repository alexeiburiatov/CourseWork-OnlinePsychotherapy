namespace Онлайн_платформа_психотерапії
{
    partial class AddClientAndDoctorMeeting
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
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Create_btn = new System.Windows.Forms.Button();
            this.DoctorBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TherapyMethodBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientBox
            // 
            this.ClientBox.Font = new System.Drawing.Font("Courier New", 10F);
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(12, 161);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(360, 24);
            this.ClientBox.TabIndex = 101;
            this.ClientBox.SelectedIndexChanged += new System.EventHandler(this.ClientBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 11F);
            this.label13.Location = new System.Drawing.Point(34, 118);
            this.label13.MaximumSize = new System.Drawing.Size(130, 40);
            this.label13.MinimumSize = new System.Drawing.Size(130, 40);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(130, 40);
            this.label13.TabIndex = 100;
            this.label13.Text = "Клієнт:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Create_btn
            // 
            this.Create_btn.BackColor = System.Drawing.Color.Transparent;
            this.Create_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_btn.Font = new System.Drawing.Font("Courier New", 11F);
            this.Create_btn.Location = new System.Drawing.Point(139, 406);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(134, 43);
            this.Create_btn.TabIndex = 99;
            this.Create_btn.Text = "Створити зустріч";
            this.Create_btn.UseVisualStyleBackColor = false;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click_1);
            // 
            // DoctorBox1
            // 
            this.DoctorBox1.Font = new System.Drawing.Font("Courier New", 10F);
            this.DoctorBox1.FormattingEnabled = true;
            this.DoctorBox1.Location = new System.Drawing.Point(12, 247);
            this.DoctorBox1.Name = "DoctorBox1";
            this.DoctorBox1.Size = new System.Drawing.Size(360, 24);
            this.DoctorBox1.TabIndex = 103;
            this.DoctorBox1.SelectedIndexChanged += new System.EventHandler(this.DoctorBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11F);
            this.label1.Location = new System.Drawing.Point(34, 204);
            this.label1.MaximumSize = new System.Drawing.Size(130, 40);
            this.label1.MinimumSize = new System.Drawing.Size(130, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(130, 40);
            this.label1.TabIndex = 102;
            this.label1.Text = "Лікар:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TherapyMethodBox2
            // 
            this.TherapyMethodBox2.Font = new System.Drawing.Font("Courier New", 10F);
            this.TherapyMethodBox2.FormattingEnabled = true;
            this.TherapyMethodBox2.Location = new System.Drawing.Point(12, 334);
            this.TherapyMethodBox2.Name = "TherapyMethodBox2";
            this.TherapyMethodBox2.Size = new System.Drawing.Size(360, 24);
            this.TherapyMethodBox2.TabIndex = 105;
            this.TherapyMethodBox2.SelectedIndexChanged += new System.EventHandler(this.TherapyMethodBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11F);
            this.label2.Location = new System.Drawing.Point(34, 291);
            this.label2.MaximumSize = new System.Drawing.Size(130, 40);
            this.label2.MinimumSize = new System.Drawing.Size(130, 40);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(130, 40);
            this.label2.TabIndex = 104;
            this.label2.Text = "Тип терапії:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddClientAndDoctorMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.TherapyMethodBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoctorBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Create_btn);
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "AddClientAndDoctorMeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати зустріч";
            this.Load += new System.EventHandler(this.AddClientAndDoctorMeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClientBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.ComboBox DoctorBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TherapyMethodBox2;
        private System.Windows.Forms.Label label2;
    }
}