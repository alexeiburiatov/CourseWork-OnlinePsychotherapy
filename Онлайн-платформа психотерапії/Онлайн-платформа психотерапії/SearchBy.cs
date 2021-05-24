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


namespace Онлайн_платформа_психотерапії
{
    public partial class SearchBy : Form
    {
        public MainForm obj=null;
        public FormSupervisors obj1=null;
        public FormDoctors obj2 = null;

        public SearchBy(MainForm obj)
        {
            InitializeComponent();
            this.obj = obj;
        }     
        public SearchBy(FormSupervisors obj1)
        {
            InitializeComponent();
            this.obj1 = obj1;
        }  
        public SearchBy(FormDoctors obj2)
        {
            InitializeComponent();
            this.obj2 = obj2;
        }


        private void SearchBy_Load(object sender, EventArgs e)
        {
            radio_ID_btn.Checked = true;
            radio_LName_btn.Checked = false;
            SearchByID_btn.Enabled = true;
            textID.Enabled = true;
            SearchByLName_btn.Enabled = false;
            textLName.Enabled = false;
        }

        private void radio_ID_btn_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_ID_btn.Checked==true)
            {
                SearchByID_btn.Enabled = true;
                textID.Enabled = true;
                SearchByLName_btn.Enabled = false;
                textLName.Enabled = false;
            }
        }

        private void radio_LName_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_LName_btn.Checked == true)
            {
                SearchByID_btn.Enabled = false;
                textID.Enabled = false;
                SearchByLName_btn.Enabled = true;
                textLName.Enabled = true;
            }
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        bool isValidName(string name)
        {
            string pattern = "[а-яА-Я/'/-]{2,25}";
            Match isMatch = Regex.Match(name, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        private void SearchByID_btn_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            string buf = textID.Text;
            if (buf.Length > 0)
            {
                for (int i = 0; i < buf.Length; i++)
                {
                    if (buf[0] == '0')
                    {
                        MessageBox.Show("Ідентифікатор не може починатися з 0. Перевірте дані", "Помилка");
                        break;
                    }
                    if (buf[i] == '0' || buf[i] == '1' || buf[i] == '2' || buf[i] == '3' || buf[i] == '4' || buf[i] == '5' || buf[i] == '6' || buf[i] == '7' || buf[i] == '8' || buf[i] == '9')
                    {

                    }
                    else
                    {
                        isOk = false;
                        MessageBox.Show("Ідентифікатор повинен містити лише цифри.", "Помилка");
                        break;
                    }
                }
            }
            else isOk = false;

            if (isOk && obj != null)
            {

                obj.FindaPersonWithoutEditingByID(Convert.ToInt32(buf));
                this.Close();
            }
           else if (isOk && obj1 != null)
            {

                obj1.FindaPersonWithoutEditingByID(Convert.ToInt32(buf));
                this.Close();
            }
            else if (isOk && obj2 != null)
            {

                obj2.FindaPersonWithoutEditingByID(Convert.ToInt32(buf));
                this.Close();
            }
            else
            {
                MessageBox.Show("Уведіть дані", "Помилка");
            }
        }

        private void SearchByLName_btn_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            string buf = textLName.Text;
            if (buf.Length > 0)
            {
                if (!isValidName(buf))
                {
                    isOk = false;
                }
            }
            else isOk = false;

            if (isOk&& obj!=null)
            {

                obj.FindaPersonWithoutEditingByName(buf);
                this.Close();
            }
            else if (isOk && obj1 != null)
            {

                obj1.FindaPersonWithoutEditingByName(buf);
                this.Close();
            }
            else if (isOk && obj2 != null)
            {

                obj2.FindaPersonWithoutEditingByName(buf);
                this.Close();
            }
            else
            {
                MessageBox.Show("Уведіть дані", "Помилка");
            }
        }

        private void textLName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
