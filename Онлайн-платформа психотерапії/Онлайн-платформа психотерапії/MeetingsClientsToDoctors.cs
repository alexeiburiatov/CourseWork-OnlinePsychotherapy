using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Data.SqlClient;
using Additional;

namespace Онлайн_платформа_психотерапії
{
    public partial class MeetingsClientsToDoctors : Form
    {

        bool dataWasSaved = true;

        Func addition = new Func();

        SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet dataSet = null;
        private DataTable table = null;
        string connectionstring;
        private void dataGridViewManip()
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            addition.ClearDataGrid(dataGridView);
            dataGridView.ColumnHeadersVisible = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.RowHeadersVisible = true;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Gray;

        }
        public MeetingsClientsToDoctors()
        {
            InitializeComponent();

        }

        private void MeetingsClientsToDoctors_Load(object sender, EventArgs e)
        {
            dataGridViewManip();

            //підключення БД
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PsychologyOnline;
                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();


        }

        private void LoadDataBaseMeetingsClients()
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("EXEC SlctAllMeetings", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                table = new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FindaPerson(int number)
        {
            table.Reset();
            table = new DataTable();


            SqlDataAdapter = new SqlDataAdapter("EXEC SlctAllMeetingsByClientID " + number, sqlConnection);
            sqlBilder = new SqlCommandBuilder(SqlDataAdapter);


            addition.DeleteColumnsAtHeader(dataGridView);
            addition.ClearDataGrid(dataGridView);


            SqlDataAdapter.Fill(table);
            dataGridView.DataSource = table;

        }



        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void РоботаЗКлієнтамиStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void РоботаЗЛікарямиStripMenu_Click(object sender, EventArgs e)
        {
            FormDoctors form = new FormDoctors();
            form.ShowDialog();
           // this.Close();
        }

        private void РоботаІзСупервізорамиStripMenu_Click(object sender, EventArgs e)
        {
            FormSupervisors form = new FormSupervisors();
           // this.Hide();
            form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ClientsMeetings_Click(object sender, EventArgs e)
        {

        }

        private void DoctorsMeetings_Click(object sender, EventArgs e)
        {
            MeetingsDoctorsToSuperv form = new MeetingsDoctorsToSuperv();
            form.ShowDialog();
        }

        private void обПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Онлайн - платформа психотерапії \"Рука допомоги\" була створена з метою поліпшення стану людей, яким потрібна допомога психотерапевта. Ми робимо все можливе, щоб Вам стало краще. Дякуємо за довіру!", "Про програму:");

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вернутьсяВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Перейти до головного меню?", "До головного меню", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //this.Hide();
                Entry form = new Entry();
                form.ShowDialog();
            }
        }

        private void выйтиИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вийти з програми?", "Вихід", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void ДобавитьВстречуСКлиентом_Click(object sender, EventArgs e)
        {

            if (table != null)
            {
                AddClientAndDoctorMeeting form = new AddClientAndDoctorMeeting(connectionstring);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Завантажте базу даних", "Увага");
            }

        }

        private void ПоискВстречи_Click(object sender, EventArgs e)
        {
            if (table != null)
            {
                InputID form = new InputID(this);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Завантажте базу даних", "Увага");
            }
        }

        private void AllDataMeetingsSuperv_Click(object sender, EventArgs e)
        {
            if (dataWasSaved == false)
            {
                MessageBox.Show("Збережіть зміни!", "Увага");

            }
            else
            {
                dataGridViewManip();
                LoadDataBaseMeetingsClients();
                dataGridView.ColumnHeadersVisible = true;
                SqlDataAdapter.Fill(table);
                SqlDataAdapter.Fill(dataSet, "ClientsMeeting");
                dataGridView.DataSource = table;
            }
        }


    }
}
