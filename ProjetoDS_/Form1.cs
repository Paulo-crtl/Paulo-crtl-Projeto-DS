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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string Semail, Ssenha;
               Ssenha = Senha.Text; Semail = Email.Text;
                if (string.IsNullOrWhiteSpace(Semail))
                {
                    throw new Exception("Email vazio");
                }
                if (string.IsNullOrWhiteSpace(Ssenha))
                {
                    throw new Exception("Senha vazio");
                }
                MessageBox.Show("Login efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Email.Clear();
                Senha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void voltar_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja Voltar ?", "Retornar a HOME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form3 home = new Form3();
                home.ShowDialog();
                this.Close();
            }
        }

        private void cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 home = new Form2();
            home.ShowDialog();
            this.Close();
        }
    }
}
