using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Numerics;
namespace Онлайн_платформа_психотерапії
{
    public partial class AddClient : Form
    {
        string connectionstring;
        
        
        SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet dataSet = null;
        private DataTable table = null;

        public AddClient(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;




        }

        private void AddClient_Load(object sender, EventArgs e)
        {
           
           Language_Box.DropDownStyle = ComboBoxStyle.DropDownList;
           GenderBox.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                SqlDataAdapter = new SqlDataAdapter("SELECT * FROM LanguageNames", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                table = new DataTable();
                SqlDataAdapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Language_Box.Items.Add(table.Rows[i][1]);
            }
            GenderBox.Items.Add("Жіноча");
            GenderBox.Items.Add("Чоловіча");





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        bool isValidEmail(string email)
        {
            if (email.Length == 0) return false;
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
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

        private void Create_btn_Click(object sender, EventArgs e)
        {
            string FName= FName_field.Text;
            string LName=LName_field.Text;
            string PatronymicName=Patronymic_field.Text;
            string Email=Mail_field.Text;
            int Date=0;
            int Month=0;
            int Year=0;
            bool isOk = true;


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

            int gender=0;
            int language=0;

            if (Language_Box.SelectedIndex!=-1)
            {
                language = Convert.ToInt32(table.Rows[Language_Box.SelectedIndex][0]);
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

            if (Date_fied.Text.Length==0|| Month_field.Text.Length==0|| Year_field.Text.Length==0||Date>31||Date<1||Month>12||Month<1||Year>2020||Year<1920)
            {
                MessageBox.Show("Дата народження некоректна", "Помилка");
                isOk = false;

            }

            if (!isValidEmail(Email))
            {
                MessageBox.Show("Email некоректний", "Помилка");
                isOk = false;
            }   
            if(!isValidName(FName))
            {

                MessageBox.Show("Ім'я некоректне", "Помилка");
                isOk = false;
            }
            if(!isValidName(LName))
            {

                MessageBox.Show("Прізвище некоректне", "Помилка");
                isOk = false;
            }  
            if(!isValidPatronymic(PatronymicName))
            {

                MessageBox.Show("По-батькові некоректне", "Помилка");
                isOk = false;
            }


            if(isOk==true)
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "EXEC AddClient '"+FName+"', '"+PatronymicName+"', '"+LName+"', "+gender+", '"+Month+"-"+Date+"-"+Year+"', "+language+", '"+Email+"'";
                    command.Connection = sqlConnection;
                    int num = command.ExecuteNonQuery();
                    MessageBox.Show("!Клієнта успішно створено!", "Увага");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Help");
                }


            }




            



        }



        private void Language_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Mail_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Month_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Year_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_fied_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
