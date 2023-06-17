using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeQuartos {
    internal class Usuario {
        public string Nome // Propriedade para armazenar o nome do usuário
        {
            get; set;
        }
        public string Email // Propriedade para armazenar o email do usuário
        {
            get; set;
        }
        public int Quarto // Propriedade para armazenar o número do quarto alugado pelo usuário
        {
            get; set;
        }

        public Usuario()
        {
        }
    }