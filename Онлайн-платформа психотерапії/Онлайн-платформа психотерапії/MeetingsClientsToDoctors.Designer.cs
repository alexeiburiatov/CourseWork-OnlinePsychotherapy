namespace Онлайн_платформа_психотерапії
{
    partial class MeetingsClientsToDoctors
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.РоботаЗКлієнтамиStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.РоботаЗЛікарямиStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.РоботаІзСупервізорамиStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsMeetings = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorsMeetings = new System.Windows.Forms.ToolStripMenuItem();
            this.обПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяВГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ДобавитьВстречуСКлиентом = new System.Windows.Forms.Button();
            this.ПоискВстречи = new System.Windows.Forms.Button();
            this.AllDataMeetingsClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(0, 126);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1284, 584);
            this.dataGridView.TabIndex = 27;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientsMeetings,
            this.DoctorsMeetings});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem1.Text = "Зустрічі";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
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
            // ДобавитьВстречуСКлиентом
            // 
            this.ДобавитьВстречуСКлиентом.BackColor = System.Drawing.Color.Transparent;
            this.ДобавитьВстречуСКлиентом.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ДобавитьВстречуСКлиентом.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДобавитьВстречуСКлиентом.Location = new System.Drawing.Point(152, 45);
            this.ДобавитьВстречуСКлиентом.Name = "ДобавитьВстречуСКлиентом";
            this.ДобавитьВстречуСКлиентом.Size = new System.Drawing.Size(134, 56);
            this.ДобавитьВстречуСКлиентом.TabIndex = 33;
            this.ДобавитьВстречуСКлиентом.Text = "Додати";
            this.ДобавитьВстречуСКлиентом.UseVisualStyleBackColor = false;
            this.ДобавитьВстречуСКлиентом.Click += new System.EventHandler(this.ДобавитьВстречуСКлиентом_Click);
            // 
            // ПоискВстречи
            // 
            this.ПоискВстречи.BackColor = System.Drawing.Color.Transparent;
            this.ПоискВстречи.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ПоискВстречи.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПоискВстречи.Location = new System.Drawing.Point(292, 45);
            this.ПоискВстречи.Name = "ПоискВстречи";
            this.ПоискВстречи.Size = new System.Drawing.Size(134, 56);
            this.ПоискВстречи.TabIndex = 32;
            this.ПоискВстречи.Text = "Пошук";
            this.ПоискВстречи.UseVisualStyleBackColor = false;
            this.ПоискВстречи.Click += new System.EventHandler(this.ПоискВстречи_Click);
            // 
            // AllDataMeetingsClients
            // 
            this.AllDataMeetingsClients.BackColor = System.Drawing.Color.Transparent;
            this.AllDataMeetingsClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllDataMeetingsClients.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllDataMeetingsClients.Location = new System.Drawing.Point(12, 45);
            this.AllDataMeetingsClients.Name = "AllDataMeetingsClients";
            this.AllDataMeetingsClients.Size = new System.Drawing.Size(134, 56);
            this.AllDataMeetingsClients.TabIndex = 31;
            this.AllDataMeetingsClients.Text = "База даних";
            this.AllDataMeetingsClients.UseVisualStyleBackColor = false;
            this.AllDataMeetingsClients.Click += new System.EventHandler(this.AllDataMeetingsSuperv_Click);
            // 
            // MeetingsClientsToDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.ДобавитьВстречуСКлиентом);
            this.Controls.Add(this.ПоискВстречи);
            this.Controls.Add(this.AllDataMeetingsClients);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "MeetingsClientsToDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зустрічі з клієнтами";
            this.Load += new System.EventHandler(this.MeetingsClientsToDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem РоботаЗКлієнтамиStripMenu;
        private System.Windows.Forms.ToolStripMenuItem РоботаЗЛікарямиStripMenu;
        private System.Windows.Forms.ToolStripMenuItem РоботаІзСупервізорамиStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClientsMeetings;
        private System.Windows.Forms.ToolStripMenuItem DoctorsMeetings;
        private System.Windows.Forms.ToolStripMenuItem обПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяВГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.Button ДобавитьВстречуСКлиентом;
        private System.Windows.Forms.Button ПоискВстречи;
        private System.Windows.Forms.Button AllDataMeetingsClients;
    }
}