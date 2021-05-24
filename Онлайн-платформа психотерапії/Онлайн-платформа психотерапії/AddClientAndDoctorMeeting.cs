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
    public partial class AddClientAndDoctorMeeting : Form
    {
        string connectionstring;


        SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet dataSet = null;
        private DataTable Doctortable = null;
        private DataTable Clienttable = null;
        private DataTable TherapyMethodtable = null;

        public AddClientAndDoctorMeeting(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
        }





        private void AddClientAndDoctorMeeting_Load(object sender, EventArgs e)
        {
            DoctorBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ClientBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TherapyMethodBox2.DropDownStyle = ComboBoxStyle.DropDownList;


            try
            {
                sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                SqlDataAdapter = new SqlDataAdapter("EXEC SlctDoctorsIDName", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                Doctortable = new DataTable();
                SqlDataAdapter.Fill(Doctortable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = 0; i < Doctortable.Rows.Count; i++)
            {
                DoctorBox1.Items.Add(Doctortable.Rows[i][1]);
            }
            //clientbox
            //therapymethod
            try
            {
                Clienttable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("EXEC SlctClientsIDName", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                SqlDataAdapter.Fill(Clienttable);
                for (int i = 0; i < Clienttable.Rows.Count; i++)
                {
                    ClientBox.Items.Add(Clienttable.Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {



                SqlDataAdapter = new SqlDataAdapter("SELECT * FROM TherapyTypes", sqlConnection);
                sqlBilder = new SqlCommandBuilder(SqlDataAdapter);
                dataSet = new DataSet();
                TherapyMethodtable = new DataTable();
                SqlDataAdapter.Fill(TherapyMethodtable);
                for (int i = 0; i < TherapyMethodtable.Rows.Count; i++)
                {
                    TherapyMethodBox2.Items.Add(TherapyMethodtable.Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void TherapyMethodBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoctorBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_btn_Click_1(object sender, EventArgs e)
        {
            if (ClientBox.SelectedIndex != -1 && TherapyMethodBox2.SelectedIndex != -1 && DoctorBox1.SelectedIndex != -1)
            {

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "EXEC AddMeetingsClient " + Convert.ToInt32(Clienttable.Rows[ClientBox.SelectedIndex][0]) + ", "
                        + Convert.ToInt32(Doctortable.Rows[DoctorBox1.SelectedIndex][0]) + ", " + Convert.ToInt32(TherapyMethodtable.Rows[TherapyMethodBox2.SelectedIndex][0]);
                    command.Connection = sqlConnection;
                    int num = command.ExecuteNonQuery();
                    MessageBox.Show("!Зустріч створена!", "Увага");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Help");
                }



            }
            else
            {
                MessageBox.Show("Виберіть необхідне зі списку", "Помилка");

            }
        }
    }
}
