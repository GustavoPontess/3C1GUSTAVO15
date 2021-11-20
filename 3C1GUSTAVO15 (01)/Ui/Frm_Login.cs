using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

using _3C1GUSTAVO15__01_.Code.BLL;
using _3C1GUSTAVO15__01_.Code.DTO;
using _3C1GUSTAVO15__01_.Ui;

namespace _3C1GUSTAVO15__01_
{
    public partial class Form1 : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Frm_Loja Loja = new Frm_Loja();
                Loja.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLabEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //configurar o cliente gmail
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("11901225@aluno.cotemig.com.br", "sckzfkgfpelffgwd"),
                EnableSsl = true
            };

            loginDTO.Email = txtEmail.Text;
            string senha = loginBLL.RetornarSenha(loginDTO);

            client.Send("11901225@aluno.cotemig.com.br", $"{txtEmail.Text}", "Redefinição de Senha", $"Seu e-mail é {txtEmail} com senha {senha}");

            MessageBox.Show("E-mail e senha enviados com sucesso.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
