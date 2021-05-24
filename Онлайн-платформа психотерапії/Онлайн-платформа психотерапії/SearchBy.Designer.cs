namespace Онлайн_платформа_психотерапії
{
    partial class SearchBy
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
            this.SearchByID_btn = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByLName_btn = new System.Windows.Forms.Button();
            this.textLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_LName_btn = new System.Windows.Forms.RadioButton();
            this.radio_ID_btn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SearchByID_btn
            // 
            this.SearchByID_btn.BackColor = System.Drawing.Color.Transparent;
            this.SearchByID_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchByID_btn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByID_btn.Location = new System.Drawing.Point(288, 34);
            this.SearchByID_btn.Name = "SearchByID_btn";
            this.SearchByID_btn.Size = new System.Drawing.Size(84, 31);
            this.SearchByID_btn.TabIndex = 13;
            this.SearchByID_btn.Text = "Пошук";
            this.SearchByID_btn.UseVisualStyleBackColor = false;
            this.SearchByID_btn.Click += new System.EventHandler(this.SearchByID_btn_Click);
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.textID.Location = new System.Drawing.Point(148, 35);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(134, 31);
            this.textID.TabIndex = 12;
            this.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.MaximumSize = new System.Drawing.Size(130, 25);
            this.label1.MinimumSize = new System.Drawing.Size(130, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Прізвище: ";
            // 
            // SearchByLName_btn
            // 
            this.SearchByLName_btn.BackColor = System.Drawing.Color.Transparent;
            this.SearchByLName_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchByLName_btn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByLName_btn.Location = new System.Drawing.Point(288, 69);
            this.SearchByLName_btn.Name = "SearchByLName_btn";
            this.SearchByLName_btn.Size = new System.Drawing.Size(84, 31);
            this.SearchByLName_btn.TabIndex = 16;
            this.SearchByLName_btn.Text = "Пошук";
            this.SearchByLName_btn.UseVisualStyleBackColor = false;
            this.SearchByLName_btn.Click += new System.EventHandler(this.SearchByLName_btn_Click);
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.textLName.Location = new System.Drawing.Point(148, 69);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(134, 31);
            this.textLName.TabIndex = 15;
            this.textLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLName.TextChanged += new System.EventHandler(this.textLName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 41);
            this.label2.MaximumSize = new System.Drawing.Size(50, 25);
            this.label2.MinimumSize = new System.Drawing.Size(50, 25);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID: ";
            // 
            // radio_LName_btn
            // 
            this.radio_LName_btn.AutoSize = true;
            this.radio_LName_btn.Font = new System.Drawing.Font("Courier New", 11F);
            this.radio_LName_btn.Location = new System.Drawing.Point(173, 132);
            this.radio_LName_btn.Name = "radio_LName_btn";
            this.radio_LName_btn.Size = new System.Drawing.Size(134, 21);
            this.radio_LName_btn.TabIndex = 17;
            this.radio_LName_btn.TabStop = true;
            this.radio_LName_btn.Text = "за прізвищем";
            this.radio_LName_btn.UseVisualStyleBackColor = true;
            this.radio_LName_btn.CheckedChanged += new System.EventHandler(this.radio_LName_btn_CheckedChanged);
            // 
            // radio_ID_btn
            // 
            this.radio_ID_btn.AutoSize = true;
            this.radio_ID_btn.Font = new System.Drawing.Font("Courier New", 11F);
            this.radio_ID_btn.Location = new System.Drawing.Point(173, 109);
            this.radio_ID_btn.Name = "radio_ID_btn";
            this.radio_ID_btn.Size = new System.Drawing.Size(71, 21);
            this.radio_ID_btn.TabIndex = 18;
            this.radio_ID_btn.TabStop = true;
            this.radio_ID_btn.Text = "за ID";
            this.radio_ID_btn.UseVisualStyleBackColor = true;
            this.radio_ID_btn.CheckedChanged += new System.EventHandler(this.radio_ID_btn_CheckedChanged);
            // 
            // SearchBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.radio_ID_btn);
            this.Controls.Add(this.radio_LName_btn);
            this.Controls.Add(this.SearchByLName_btn);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchByID_btn);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "SearchBy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пошук за...";
            this.Load += new System.EventHandler(this.SearchBy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchByID_btn;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchByLName_btn;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_LName_btn;
        private System.Windows.Forms.RadioButton radio_ID_btn;
    }
}