namespace Онлайн_платформа_психотерапії
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.РоботаЗКлієнтамиStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.РоботаЗЛікарямиStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.РоботаІзСупервізорамиStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.обПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяВГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AllDataClients = new System.Windows.Forms.Button();
            this.ПоискКлиента = new System.Windows.Forms.Button();
            this.ДобавитьКлиента = new System.Windows.Forms.Button();
            this.РедактироватьДанныеКлиента = new System.Windows.Forms.Button();
            this.УдалитьКлиента_btn = new System.Windows.Forms.Button();
            this.SaveChanges_btn = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsMeetings = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorsMeetings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.РоботаЗКлієнтамиStripMenu,
            this.РоботаЗЛікарямиStripMenu,
            this.РоботаІзСупервізорамиStripMenu,
            this.toolStripMenuItem1,
            this.обПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // РоботаЗКлієнтамиStripMenu
            // 
            this.РоботаЗКлієнтамиStripMenu.Name = "РоботаЗКлієнтамиStripMenu";
            this.РоботаЗКлієнтамиStripMenu.Size = new System.Drawing.Size(125, 20);
            this.РоботаЗКлієнтамиStripMenu.Text = "Робота з клієнтами";
            this.РоботаЗКлієнтамиStripMenu.Click += new System.EventHandler(this.РоботаЗКлієнтамиStripMenu_Click);
            // 
            // РоботаЗЛікарямиStripMenu
            // 
            this.РоботаЗЛікарямиStripMenu.Name = "РоботаЗЛікарямиStripMenu";
            this.РоботаЗЛікарямиStripMenu.Size = new System.Drawing.Size(120, 20);
            this.РоботаЗЛікарямиStripMenu.Text = "Робота з лікарями";
            this.РоботаЗЛікарямиStripMenu.Click += new System.EventHandler(this.РоботаЗЛікарямиStripMenu_Click);
            // 
            // РоботаІзСупервізорамиStripMenu
            // 
            this.РоботаІзСупервізорамиStripMenu.Name = "РоботаІзСупервізорамиStripMenu";
            this.РоботаІзСупервізорамиStripMenu.Size = new System.Drawing.Size(154, 20);
            this.РоботаІзСупервізорамиStripMenu.Text = "Робота із супервізорами";
            this.РоботаІзСупервізорамиStripMenu.Click += new System.EventHandler(this.РоботаІзСупервізорамиStripMenu_Click);
            // 
            // обПрограммеToolStripMenuItem
            // 
            this.обПрограммеToolStripMenuItem.Name = "обПрограммеToolStripMenuItem";
            this.обПрограммеToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.обПрограммеToolStripMenuItem.Text = "Про програму";
            this.обПрограммеToolStripMenuItem.Click += new System.EventHandler(this.обПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяВГлавноеМенюToolStripMenuItem,
            this.выйтиИзПрограммыToolStripMenuItem});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem.Text = "Вийти";
            // 
            // вернутьсяВГлавноеМенюToolStripMenuItem
            // 
            this.вернутьсяВГлавноеМенюToolStripMenuItem.Name = "вернутьсяВГлавноеМенюToolStripMenuItem";
            this.вернутьсяВГлавноеМенюToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.вернутьсяВГлавноеМенюToolStripMenuItem.Text = "Повернутися в головне меню";
            this.вернутьсяВГлавноеМенюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяВГлавноеМенюToolStripMenuItem_Click);
            // 
            // выйтиИзПрограммыToolStripMenuItem
            // 
            this.выйтиИзПрограммыToolStripMenuItem.Name = "выйтиИзПрограммыToolStripMenuItem";
            this.выйтиИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.выйтиИзПрограммыToolStripMenuItem.Text = "Вийти з програми";
            this.выйтиИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПрограммыToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(0, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(984, 594);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AllDataClients
            // 
            this.AllDataClients.BackColor = System.Drawing.Color.Transparent;
            this.AllDataClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllDataClients.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllDataClients.Location = new System.Drawing.Point(12, 42);
            this.AllDataClients.Name = "AllDataClients";
            this.AllDataClients.Size = new System.Drawing.Size(134, 56);
            this.AllDataClients.TabIndex = 8;
            this.AllDataClients.Text = "База даних";
            this.AllDataClients.UseVisualStyleBackColor = false;
            this.AllDataClients.Click += new System.EventHandler(this.AllDataClients_Click);
            // 
            // ПоискКлиента
            // 
            this.ПоискКлиента.BackColor = System.Drawing.Color.Transparent;
            this.ПоискКлиента.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ПоискКлиента.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПоискКлиента.Location = new System.Drawing.Point(586, 42);
            this.ПоискКлиента.Name = "ПоискКлиента";
            this.ПоискКлиента.Size = new System.Drawing.Size(134, 56);
            this.ПоискКлиента.TabIndex = 9;
            this.ПоискКлиента.Text = "Пошук";
            this.ПоискКлиента.UseVisualStyleBackColor = false;
            this.ПоискКлиента.Click += new System.EventHandler(this.ПоискКлиента_Click);
            // 
            // ДобавитьКлиента
            // 
            this.ДобавитьКлиента.BackColor = System.Drawing.Color.Transparent;
            this.ДобавитьКлиента.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ДобавитьКлиента.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДобавитьКлиента.Location = new System.Drawing.Point(306, 42);
            this.ДобавитьКлиента.Name = "ДобавитьКлиента";
            this.ДобавитьКлиента.Size = new System.Drawing.Size(134, 56);
            this.ДобавитьКлиента.TabIndex = 10;
            this.ДобавитьКлиента.Text = "Додати";
            this.ДобавитьКлиента.UseVisualStyleBackColor = false;
            this.ДобавитьКлиента.Click += new System.EventHandler(this.ДобавитьКлиента_Click);
            // 
            // РедактироватьДанныеКлиента
            // 
            this.РедактироватьДанныеКлиента.BackColor = System.Drawing.Color.Transparent;
            this.РедактироватьДанныеКлиента.Cursor = System.Windows.Forms.Cursors.Hand;
            this.РедактироватьДанныеКлиента.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.РедактироватьДанныеКлиента.Location = new System.Drawing.Point(152, 42);
            this.РедактироватьДанныеКлиента.Name = "РедактироватьДанныеКлиента";
            this.РедактироватьДанныеКлиента.Size = new System.Drawing.Size(148, 56);
            this.РедактироватьДанныеКлиента.TabIndex = 11;
            this.РедактироватьДанныеКлиента.Text = "Редагувати";
            this.РедактироватьДанныеКлиента.UseVisualStyleBackColor = false;
            this.РедактироватьДанныеКлиента.Click += new System.EventHandler(this.РедактироватьДанныеКлиента_Click);
            // 
            // УдалитьКлиента_btn
            // 
            this.УдалитьКлиента_btn.BackColor = System.Drawing.Color.Transparent;
            this.УдалитьКлиента_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.УдалитьКлиента_btn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.УдалитьКлиента_btn.Location = new System.Drawing.Point(446, 42);
            this.УдалитьКлиента_btn.Name = "УдалитьКлиента_btn";
            this.УдалитьКлиента_btn.Size = new System.Drawing.Size(134, 56);
            this.УдалитьКлиента_btn.TabIndex = 12;
            this.УдалитьКлиента_btn.Text = "Видалити";
            this.УдалитьКлиента_btn.UseVisualStyleBackColor = false;
            this.УдалитьКлиента_btn.Click += new System.EventHandler(this.УдалитьКлиента_btn_Click);
            // 
            // SaveChanges_btn
            // 
            this.SaveChanges_btn.BackColor = System.Drawing.Color.Transparent;
            this.SaveChanges_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveChanges_btn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges_btn.Location = new System.Drawing.Point(845, 48);
            this.SaveChanges_btn.Name = "SaveChanges_btn";
            this.SaveChanges_btn.Size = new System.Drawing.Size(127, 44);
            this.SaveChanges_btn.TabIndex = 13;
            this.SaveChanges_btn.Text = "Зберегти";
            this.SaveChanges_btn.UseVisualStyleBackColor = false;
            this.SaveChanges_btn.Visible = false;
            this.SaveChanges_btn.Click += new System.EventHandler(this.SaveChanges_btn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientsMeetings,
            this.DoctorsMeetings});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem1.Text = "Зустрічі";
            // 
            // ClientsMeetings
            // 
            this.ClientsMeetings.Name = "ClientsMeetings";
            this.ClientsMeetings.Size = new System.Drawing.Size(209, 22);
            this.ClientsMeetings.Text = "Клієнтів із лікарями";
            this.ClientsMeetings.Click += new System.EventHandler(this.ClientsMeetings_Click);
            // 
            // DoctorsMeetings
            // 
            this.DoctorsMeetings.Name = "DoctorsMeetings";
            this.DoctorsMeetings.Size = new System.Drawing.Size(209, 22);
            this.DoctorsMeetings.Text = "Лікарів із супервізорами";
            this.DoctorsMeetings.Click += new System.EventHandler(this.DoctorsMeetings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.SaveChanges_btn);
            this.Controls.Add(this.УдалитьКлиента_btn);
            this.Controls.Add(this.РедактироватьДанныеКлиента);
            this.Controls.Add(this.ДобавитьКлиента);
            this.Controls.Add(this.ПоискКлиента);
            this.Controls.Add(this.AllDataClients);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клієнти";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem РоботаЗКлієнтамиStripMenu;
        private System.Windows.Forms.ToolStripMenuItem РоботаЗЛікарямиStripMenu;
        private System.Windows.Forms.ToolStripMenuItem РоботаІзСупервізорамиStripMenu;
        private System.Windows.Forms.ToolStripMenuItem обПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяВГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button AllDataClients;
        private System.Windows.Forms.Button ПоискКлиента;
        private System.Windows.Forms.Button ДобавитьКлиента;
        private System.Windows.Forms.Button РедактироватьДанныеКлиента;
        private System.Windows.Forms.Button УдалитьКлиента_btn;
        private System.Windows.Forms.Button SaveChanges_btn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClientsMeetings;
        private System.Windows.Forms.ToolStripMenuItem DoctorsMeetings;
    }
}