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
using System.Data.SqlClient;
using Additional;


namespace Онлайн_платформа_психотерапії
{
    public partial class FormSupervisors : Form
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
        bool isValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
        bool isValidName(string name)
        {
            string pattern = "[а-яА-Я/'/-]{2,25}";
            Match isMatch = Regex.Match(name, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
        bool isValidPatronymic(string name)
        {
            string pattern = "[а-яА-Я/'/-]";
            Match isMatch = Regex.Match(name, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        private bool UpdateChanges()
        {
            int SupervisorID;
            string FName;
            string LName;
            string PatronymicName;
            string Email;
            string money;

            SupervisorID = Convert.ToInt32(dataGridView[0, 0].Value.ToString());
            FName = dataGridView[1, 0].Value.ToString();
            LName = dataGridView[3, 0].Value.ToString();
            PatronymicName = dataGridView[2, 0].Value.ToString();
            Email = dataGridView[8, 0].Value.ToString();
            money= dataGridView[7, 0].Value.ToString();

            if (!isValidEmail(Email))
            {
                MessageBox.Show("Email некоректний", "Помилка");
                return false;
            }
            if (FName.Length == 0 && LName.Length == 0 && Email.Length == 0)
            {
                MessageBox.Show("Пусті комірки!", "Помилка");
                return false;
            }
            if (!isValidName(FName))
            {
                MessageBox.Show("Ім'я некоректне", "Помилка");
                return false;
            }
            if (!isValidName(LName))
            {
                MessageBox.Show("Прізвище некоректне", "Помилка");
                return false;
            }
            if (PatronymicName.Length > 0)
            {
                if (!isValidPatronymic(PatronymicName))
                {
                    MessageBox.Show("По-батькові некоректне", "Помилка");
                    return false;
                }
            }
            if(Convert.ToInt32(money)<1){
                MessageBox.Show("Перевірте погодинну оплату", "Помилка");
                return false;
            }



            table.Reset();
            table = new DataTable();

            try
            {
                SqlDataAdapter = new SqlDataAdapter("EXEC UpdateDataSuperv '" + SupervisorID + "', '" + FName + "', '" + PatronymicName + "', '" + LName + "', '" + Convert.ToInt32(money) + "', '" + Email + "'", sqlConnection);
            }
            catch (Exception)
            {
                MessageBox.Show("Непередбачувана помилка", "Помилка");

                throw;
            }

            sqlBilder = new SqlCommandBuilder(SqlDataAdapter);


            addition.DeleteColumnsAtHeader(dataGridView);
            addition.ClearDataGrid(dataGridView);


            SqlDataAdapter.Fill(table);
            dataGridView.DataSource = table;






            return true;
        }

            public FormSupervisors()
        {
            InitializeComponent();
        }

        private void LoadDataBaseSuperv()
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("EXEC SlctAllSuperv", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                table = new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSupervisors_Load(object sender, EventArgs e)
        {
            dataGridViewManip();

            //підключення БД
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PsychologyOnline;
                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
        }

        public void FindaPerson(int number)
        {
            table.Reset();
            table = new DataTable();


            SqlDataAdapter = new SqlDataAdapter("EXEC SlctSupervByID " + number, sqlConnection);
            sqlBilder = new SqlCommandBuilder(SqlDataAdapter);


            addition.DeleteColumnsAtHeader(dataGridView);
            addition.ClearDataGrid(dataGridView);


            SqlDataAdapter.Fill(table);
            dataGridView.DataSource = table;


            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;


            dataGridView.ReadOnly = false;
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = false;
            dataGridView.Columns[2].ReadOnly = false;
            dataGridView.Columns[3].ReadOnly = false;
            dataGridView.Columns[4].ReadOnly = true;
            dataGridView.Columns[5].ReadOnly = true;
            dataGridView.Columns[6].ReadOnly = true;
            dataGridView.Columns[7].ReadOnly = false;
            dataGridView.Columns[8].ReadOnly = false;
        }

        public void DeletePerson(int number, int index)
        {


            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXEC DeleteSuperv " + number;
                command.Connection = sqlConnection;
                int num = command.ExecuteNonQuery();
                MessageBox.Show("!Супервізора успішно видалено!", "Увага");
                dataGridView.Rows.RemoveAt(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Help");
            }






        }

        public void FindaPersonWithoutEditingByID(int number)
        {
            table.Reset();
            table = new DataTable();


            SqlDataAdapter = new SqlDataAdapter("EXEC SlctSupervByID " + number, sqlConnection);
            sqlBilder = new SqlCommandBuilder(SqlDataAdapter);


            addition.DeleteColumnsAtHeader(dataGridView);
            addition.ClearDataGrid(dataGridView);


            SqlDataAdapter.Fill(table);
            dataGridView.DataSource = table;

        }

        public void FindaPersonWithoutEditingByName(string LName)
        {
            table.Reset();
            table = new DataTable();


            SqlDataAdapter = new SqlDataAdapter("EXEC SlctSupervByName " + LName, sqlConnection);
            sqlBilder = new SqlCommandBuilder(SqlDataAdapter);


            addition.DeleteColumnsAtHeader(dataGridView);
            addition.ClearDataGrid(dataGridView);


            SqlDataAdapter.Fill(table);
            dataGridView.DataSource = table;

        }


        private void РоботаЗКлієнтамиStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void РоботаЗЛікарямиStripMenu_Click(object sender, EventArgs e)
        {
            FormDoctors form = new FormDoctors();
            form.ShowDialog();
            this.Close();
        }

        private void РоботаІзСупервізорамиStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void AllDataSuperv_Click(object sender, EventArgs e)
        {

            if (dataWasSaved == false)
            {
                MessageBox.Show("Збережіть зміни!", "Увага");

            }
            else
            {
                dataGridViewManip();
                LoadDataBaseSuperv();
                dataGridView.ColumnHeadersVisible = true;
                SqlDataAdapter.Fill(table);
                SqlDataAdapter.Fill(dataSet, "DataSuperv");
                dataGridView.DataSource = table;
            }
        }



        private void УдалитьСупервизора_btn_Click(object sender, EventArgs e)
        {


            if (table != null)
            {

                int index = dataGridView.CurrentRow.Index;


                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити супервізора з бази з ID = " + dataGridView.CurrentRow.Cells[0].Value.ToString() + " ?", "Видалити з бази?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeletePerson(Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString()), index);

                }

            }
            else
            {
                MessageBox.Show("Завантажте базу даних", "Увага");
            }

        }

        private void ПоискСупервизора_Click(object sender, EventArgs e)
        {

            if (table != null)
            {
                SearchBy form = new SearchBy(this);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Завантажте базу даних", "Увага");
            }


        }

        private void SaveChanges_btn_Click_1(object sender, EventArgs e)
        {

            bool EverythingIsOK = UpdateChanges();
            if (!EverythingIsOK)
            {
                MessageBox.Show("Уведено некоректно дані. Перевірте!", "Увага");
            }
            else
            {
                dataWasSaved = true;
                MessageBox.Show("Дані успішно збережено!!", "Увага");
                dataGridView.ColumnHeadersVisible = false;
                SaveChanges_btn.Visible = false;
            }



        }

        private void ДобавитьСупервизора_Click(object sender, EventArgs e)
        {

            if (table != null)
            {
                AddSuperv form = new AddSuperv(connectionstring);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Завантажте базу даних", "Увага");
            }

        }



        private void РедактироватьДанныеСупервизора_Click(object sender, EventArgs e)
        {
            if (table != null)
            {
                InputID form = new InputID(this);
                form.ShowDialog();
                dataWasSaved = false;
                SaveChanges_btn.Visible = true;
                dataGridView.ColumnHeadersVisible = true;
            }
            else
            {
                MessageBox.Show("Завантажте базу даних", "Увага");
            }



        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void РоботаЗКлієнтамиStripMenu_Click_1(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            //this.Close();
            form.ShowDialog();

        }

        private void РоботаЗЛікарямиStripMenu_Click_1(object sender, EventArgs e)
        {
            FormDoctors form = new FormDoctors();
            form.ShowDialog();
            this.Close();

        }

        private void РоботаІзСупервізорамиStripMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void обПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Онлайн - платформа психотерапії \"Рука допомоги\" була створена з метою поліпшення стану людей, яким потрібна допомога психотерапевта. Ми робимо все можливе, щоб Вам стало краще. Дякуємо за довіру!", "Про програму:");


        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void вернутьсяВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Перейти до головного меню?", "До головного меню", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               // this.Hide();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ClientsMeetings_Click(object sender, EventArgs e)
        {
            MeetingsClientsToDoctors form = new MeetingsClientsToDoctors();
            form.ShowDialog();
        }

        private void DoctorsMeetings_Click(object sender, EventArgs e)
        {
            MeetingsDoctorsToSuperv form = new MeetingsDoctorsToSuperv();
            form.ShowDialog();
        }
    }
}
