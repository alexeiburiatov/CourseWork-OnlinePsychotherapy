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
    public partial class AddSupAndDoctMeeting : Form
    {

        string connectionstring;


        SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet dataSet = null;
        private DataTable table = null;
        public AddSupAndDoctMeeting(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
        }

        private void AddSupAndDoctMeeting_Load(object sender, EventArgs e)
        {
            DoctorBox.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                SqlDataAdapter = new SqlDataAdapter("EXEC SlctDoctorsIDName", sqlConnection);
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
                DoctorBox.Items.Add(table.Rows[i][1]);
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {

            if (DoctorBox.SelectedIndex != -1)
            {

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "EXEC AddSupAndDocMeeting " + Convert.ToInt32(table.Rows[DoctorBox.SelectedIndex][0]);
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
                MessageBox.Show("Виберіть лікаря", "Помилка");

            }


        }

        private void DoctorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
