﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1GUSTAVO15__01_.Code.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _email, _senha;

        public int Id { get => _id; set => _id = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }

    }
}
