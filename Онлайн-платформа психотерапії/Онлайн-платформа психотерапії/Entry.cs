using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Онлайн_платформа_психотерапії
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void Entry_Load(object sender, EventArgs e)
        {

        }

        private void ToMainForm_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
          //  this.Hide();
            form.ShowDialog();
        }
    }
}
