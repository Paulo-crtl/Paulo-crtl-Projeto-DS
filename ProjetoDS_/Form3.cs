using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void login_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 OutroForm = new Form1();
            OutroForm.ShowDialog();
            this.Close();
        }

        private void cadastro_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
            this.Close();
        }
    }
}
