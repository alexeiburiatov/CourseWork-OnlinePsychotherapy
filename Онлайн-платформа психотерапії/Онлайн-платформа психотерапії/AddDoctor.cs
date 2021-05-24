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

namespace Онлайн_платформа_психотерапії
{
    public partial class AddDoctor : Form
    {

        string connectionstring;


        SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet dataSet = null;
        private DataTable Languagetable = null;
        private DataTable TherapyTypetable = null;
        private DataTable Supervisortable = null;

        public AddDoctor(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
        }


        bool isValidEmail(string email)
        {
            if (email.Length == 0) return false;
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isHorlyRateValid(string money)
        {
            if (money.Length == 0) return false;
            string pattern = "[0-10000]";
            Match isMatch = Regex.Match(money, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isBirthdayValid(string date)
        {
            if (date.Length == 0) return false;
            string pattern = "[0-2020]";
            Match isMatch = Regex.Match(date, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
        bool isValidName(string name)
        {
            if (name.Length == 0) return false;
            string pattern = "[а-яА-Я/'/-]{2,25}";
            Match isMatch = Regex.Match(name, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
        bool isValidPatronymic(string name)

        {
            if (name.Length == 0) return false;
            string pattern = "[а-яА-Я/'/-]";
            Match isMatch = Regex.Match(name, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }


        private void AddDoctor_Load(object sender, EventArgs e)
        {
            Language_Box.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SupervisorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TherapyType_Box.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                SqlDataAdapter = new SqlDataAdapter("SELECT * FROM LanguageNames", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                Languagetable = new DataTable();
                SqlDataAdapter.Fill(Languagetable);
                for (int i = 0; i < Languagetable.Rows.Count; i++)
                {
                    Language_Box.Items.Add(Languagetable.Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GenderBox.Items.Add("Жіноча");
            GenderBox.Items.Add("Чоловіча");

            try
            {
                TherapyTypetable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("SELECT * FROM TherapyMethods", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                SqlDataAdapter.Fill(TherapyTypetable);
                for (int i = 0; i < TherapyTypetable.Rows.Count; i++)
                {
                    TherapyType_Box.Items.Add(TherapyTypetable.Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {



                SqlDataAdapter = new SqlDataAdapter("EXEC SlctSupervsIDName", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                Supervisortable = new DataTable();
                SqlDataAdapter.Fill(Supervisortable);
                for (int i = 0; i < Supervisortable.Rows.Count; i++)
                {
                    SupervisorBox.Items.Add(Supervisortable.Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            string FName = FName_field.Text;
            string LName = LName_field.Text;
            string PatronymicName = Patronymic_field.Text;
            string Email = Mail_field.Text;
            int Date = 0;
            int Month = 0;
            int Year = 0;
            bool isOk = true;
            int money = 0;
            int supervisorID = 0;
            int therapyTypeID = 0;


            if (TherapyType_Box.SelectedIndex != -1)
            {
                therapyTypeID = Convert.ToInt32(TherapyTypetable.Rows[TherapyType_Box.SelectedIndex][0]);
            }
            else
            {
                MessageBox.Show("Виберіть тип терапії", "Помилка");
                isOk = false;
            }
            if (SupervisorBox.SelectedIndex != -1)
            {
                supervisorID = Convert.ToInt32(Supervisortable.Rows[SupervisorBox.SelectedIndex][0]);
            }
            else
            {
                MessageBox.Show("Виберіть супервізора", "Помилка");
                isOk = false;
            }
            if (!isHorlyRateValid(HourlyRate_field.Text))
            {
                MessageBox.Show("Погодинна оплата некоректна", "Помилка");
            }
            else
            {
                money = Convert.ToInt32(HourlyRate_field.Text);
            }

            if (!isBirthdayValid(Date_fied.Text)
                || !isBirthdayValid(Month_field.Text) || !isBirthdayValid(Year_field.Text))
            {
                MessageBox.Show("Дата народження некоректна", "Помилка");
            }
            else
            {
                Date = Convert.ToInt32(Date_fied.Text);
                Month = Convert.ToInt32(Month_field.Text);
                Year = Convert.ToInt32(Year_field.Text);
            }

            int gender = 0;
            int language = 0;

            if (Language_Box.SelectedIndex != -1)
            {
                language = Convert.ToInt32(Languagetable.Rows[Language_Box.SelectedIndex][0]);
            }
            else
            {
                MessageBox.Show("Виберіть мову спілкування", "Помилка");
                isOk = false;
            }

            if (GenderBox.SelectedIndex != -1)
            {
                gender = GenderBox.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Виберіть стать", "Помилка");
                isOk = false;
            }

            if (Date_fied.Text.Length == 0 || Month_field.Text.Length == 0 || Year_field.Text.Length == 0 || Date > 31 || Date < 1 || Month > 12 || Month < 1 || Year > 2020 || Year < 1920)
            {
                MessageBox.Show("Дата народження некоректна", "Помилка");
                isOk = false;

            }

            if (!isValidEmail(Email))
            {
                MessageBox.Show("Email некоректний", "Помилка");
                isOk = false;
            }
            if (!isValidName(FName))
            {

                MessageBox.Show("Ім'я некоректне", "Помилка");
                isOk = false;
            }
            if (!isValidName(LName))
            {

                MessageBox.Show("Прізвище некоректне", "Помилка");
                isOk = false;
            }
            if (!isValidPatronymic(PatronymicName))
            {

                MessageBox.Show("По-батькові некоректне", "Помилка");
                isOk = false;
            }


            if (isOk == true)
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "EXEC AddDoctor '" + FName + "', '" + PatronymicName + "', '" + LName + "', " + gender + ", '" + Month + "-" + Date + "-" + Year + "', " + language + ", '" + money + "', " + therapyTypeID + ", " + supervisorID +  ", '" + Email + "'";
                    command.Connection = sqlConnection;
                    int num = command.ExecuteNonQuery();
                    MessageBox.Show("!Лікаря успішно створено!", "Увага");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Help");
                }
            }



        }

        private void TherapyType_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HourlyRate_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Month_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Year_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Language_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mail_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void SupervisorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Patronymic_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void FName_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void LName_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_fied_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
