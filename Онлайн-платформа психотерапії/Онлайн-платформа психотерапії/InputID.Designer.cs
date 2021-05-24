namespace Онлайн_платформа_психотерапії
{
    partial class InputID
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
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.SearchByID_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.MaximumSize = new System.Drawing.Size(200, 25);
            this.label1.MinimumSize = new System.Drawing.Size(150, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.textID.Location = new System.Drawing.Point(160, 56);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(134, 31);
            this.textID.TabIndex = 8;
            this.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // SearchByID_btn
            // 
            this.SearchByID_btn.BackColor = System.Drawing.Color.Transparent;
            this.SearchByID_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchByID_btn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByID_btn.Location = new System.Drawing.Point(160, 93);
            this.SearchByID_btn.Name = "SearchByID_btn";
            this.SearchByID_btn.Size = new System.Drawing.Size(134, 56);
            this.SearchByID_btn.TabIndex = 10;
            this.SearchByID_btn.Text = "Пошук";
            this.SearchByID_btn.UseVisualStyleBackColor = false;
            this.SearchByID_btn.Click += new System.EventHandler(this.SearchByID_btn_Click);
            // 
            // InputID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.SearchByID_btn);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "InputID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введіть ID";
            this.Load += new System.EventHandler(this.InputID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button SearchByID_btn;
    }
}