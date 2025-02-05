using System.Data;


using _3C1GUSTAVO15__01_.Code.DAL;
using _3C1GUSTAVO15__01_.Code.DTO;

namespace _3C1GUSTAVO15__01_.Code.BLL
{
    class LojaBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Produtos";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(LojaDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Nome}','{medDto.Categoria}','{medDto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(LojaDTO medDto)
        {
            string editar = $"update {tabela} set nome = '{medDto.Nome}', categoria = '{medDto.Categoria}', preco = '{medDto.Preco}' where id = '{medDto.ID}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(LojaDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.ID}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
