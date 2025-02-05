using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1GUSTAVO15__01_.Code.DTO
{
    class LojaDTO
    {
        private int _ID;
        private string _Nome, _Categoria, _Preco;

        public string Nome { get => _Nome; set => _Nome = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
        public string Preco { get => _Preco; set => _Preco = value; }
        public int ID { get => _ID; set => _ID = value; }
    }
}
