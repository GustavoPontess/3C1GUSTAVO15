using System;
using System.Windows.Forms;

using _3C1GUSTAVO15__01_.Code.BLL;
using _3C1GUSTAVO15__01_.Code.DTO;

namespace _3C1GUSTAVO15__01_.Ui
{
    public partial class Frm_Loja : Form
    {

        LojaBLL medbll = new LojaBLL();
        LojaDTO meddto = new LojaDTO();
        public Frm_Loja()
        {
            InitializeComponent();
            dgv_Produtos.DataSource = medbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Nome = txt_Nome.Text;
            meddto.Categoria = txt_Categoria.Text;
            meddto.Preco = txt_Preco.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Produtos.DataSource = medbll.Listar();
            //limpar campos
            txt_ID.Clear();
            txt_Nome.Clear();
            txt_Categoria.Clear();
            txt_Preco.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.ID = int.Parse(txt_ID.Text);
            meddto.Nome = txt_Nome.Text;
            meddto.Categoria = txt_Categoria.Text;
            meddto.Preco = txt_Preco.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Editar(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Editado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Produtos.DataSource = medbll.Listar();
            //limpar campos
            txt_ID.Clear();
            txt_Nome.Clear();
            txt_Categoria.Clear();
            txt_Preco.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            //Preenchimento do objeto 
            meddto.ID = int.Parse(txt_ID.Text);
            meddto.Nome = txt_Nome.Text;
            meddto.Categoria = txt_Categoria.Text;
            meddto.Preco = txt_Preco.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Excluir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Excluido com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Produtos.DataSource = medbll.Listar();
            //limpar campos
            txt_ID.Clear();
            txt_Nome.Clear();
            txt_Categoria.Clear();
            txt_Preco.Clear();
        }

        private void dgv_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Nome.Text = dgv_Produtos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Categoria.Text = dgv_Produtos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Preco.Text = dgv_Produtos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
