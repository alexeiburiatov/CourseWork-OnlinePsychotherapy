using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Онлайн_платформа_психотерапії
{
    public partial class InputID : Form
    {
        public MainForm obj= null;
        public FormSupervisors obj1=null;
        public FormDoctors obj2 = null;
        public MeetingsClientsToDoctors obj3 = null;
        public MeetingsDoctorsToSuperv obj4 = null;

        public InputID(MainForm obj)
        {
            InitializeComponent();
            this.obj = obj;
            label1.Text = "Client ID";
        } 
        public InputID(FormSupervisors obj1)
        {
            InitializeComponent();
            this.obj1 = obj1;
            label1.Text = "Supervisor ID";
        }
        public InputID(FormDoctors obj2)
        {
            InitializeComponent();
            this.obj2 = obj2;
            label1.Text = "Doctor ID";
        }
        public InputID(MeetingsClientsToDoctors obj3)
        {
            InitializeComponent();
            this.obj3 = obj3;
            label1.Text = "Client ID";
        }
        public InputID(MeetingsDoctorsToSuperv obj4)
        {
            InitializeComponent();
            this.obj4 = obj4;
            label1.Text = "Doctor ID";
        }


        private void InputID_Load(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void SearchByID_btn_Click(object sender, EventArgs e)
        {
            bool isOk=true;

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

            if(isOk&&obj!=null)
            {

                obj.FindaPerson(Convert.ToInt32(buf));
                this.Close();
            }
            else if (isOk && obj1 != null)
            {

                obj1.FindaPerson(Convert.ToInt32(buf));
                this.Close();
            }
            else if (isOk && obj2 != null)
            {

                obj2.FindaPerson(Convert.ToInt32(buf));
                this.Close();
            }
            else if (isOk && obj3 != null)
            {

                obj3.FindaPerson(Convert.ToInt32(buf));
                this.Close();
            }
            else if (isOk && obj4 != null)
            {

                obj4.FindaPerson(Convert.ToInt32(buf));
                this.Close();
            }
            else
            {
                MessageBox.Show("Уведіть дані", "Помилка");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
