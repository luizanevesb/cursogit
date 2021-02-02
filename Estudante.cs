using System;
using System.Collections.Generic;
using System.Text;

namespace Pensionato
{
    class Estudante
    {
        public string Nome;
        public string Email;

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
