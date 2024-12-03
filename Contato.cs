using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica
{
    internal class Contato
    {
        // Contato.cs
        public class Contatos
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }

            public Contatos(string nome, string telefone)
            {
                Nome = nome;
                Telefone = telefone;
            }
        }
}
