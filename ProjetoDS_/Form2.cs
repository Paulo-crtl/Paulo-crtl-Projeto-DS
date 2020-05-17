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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string Scpf, Snome, Ssenha, Ssenha2, SNusuario, Semail;
                Scpf = Cpf.Text; Snome = Nome.Text; Ssenha = Senha.Text; Ssenha2 = Csenha.Text; SNusuario = Nusuario.Text; Semail = Email.Text;
                if (string.IsNullOrWhiteSpace(Snome))
                {
                    throw new Exception("Nome vazio");
                }
                if (Scpf.Length != 11)
                {
                    throw new Exception("o CPF deve conter 11 digitos");
                }
                if (string.IsNullOrWhiteSpace(SNusuario))
                {
                    throw new Exception("Nom de de usuário vazio");
                }
                if (string.IsNullOrWhiteSpace(Semail))
                {
                    throw new Exception("Email vazio");
                }
                if (string.IsNullOrWhiteSpace(Ssenha))
                {
                    throw new Exception("Senha vazio");
                }
                if (string.IsNullOrWhiteSpace(Ssenha2))
                {
                    throw new Exception("Confirmar senha vazio");
                }
                if (Ssenha != Ssenha2)
                {
                    throw new Exception("As senhas não correspondem");
                }
                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 login = new Form1();
                login.ShowDialog();
                this.Close();
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
        private void Limpar_Click(object sender, EventArgs e)
        {
            Nome.Clear();
            Cpf.Clear();
            Email.Clear();
            Senha.Clear();
            Csenha.Clear();
            Nusuario.Clear();
        }
    }
}
