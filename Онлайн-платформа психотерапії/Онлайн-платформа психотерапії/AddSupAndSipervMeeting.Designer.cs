namespace Онлайн_платформа_психотерапії
{
    partial class AddSupAndDoctMeeting
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
            this.DoctorBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Create_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoctorBox
            // 
            this.DoctorBox.Font = new System.Drawing.Font("Courier New", 10F);
            this.DoctorBox.FormattingEnabled = true;
            this.DoctorBox.Location = new System.Drawing.Point(9, 212);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.Size = new System.Drawing.Size(360, 24);
            this.DoctorBox.TabIndex = 98;
            this.DoctorBox.SelectedIndexChanged += new System.EventHandler(this.DoctorBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 11F);
            this.label13.Location = new System.Drawing.Point(31, 171);
            this.label13.MaximumSize = new System.Drawing.Size(130, 40);
            this.label13.MinimumSize = new System.Drawing.Size(130, 40);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(130, 40);
            this.label13.TabIndex = 97;
            this.label13.Text = "Лікар:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Create_btn
            // 
            this.Create_btn.BackColor = System.Drawing.Color.Transparent;
            this.Create_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_btn.Font = new System.Drawing.Font("Courier New", 11F);
            this.Create_btn.Location = new System.Drawing.Point(132, 261);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(134, 43);
            this.Create_btn.TabIndex = 96;
            this.Create_btn.Text = "Створити зустріч";
            this.Create_btn.UseVisualStyleBackColor = false;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // AddSupAndDoctMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.DoctorBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Create_btn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "AddSupAndDoctMeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати зустріч";
            this.Load += new System.EventHandler(this.AddSupAndDoctMeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DoctorBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Create_btn;
    }
}