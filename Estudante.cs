using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Estudante {
    
        public string nome { get; set; }
        public string email { get; set; }
        
        public Estudante() {

        }
        public Estudante(string nome, string email) {
            this.nome = nome;
            this.email = email;
        }

        public override string ToString() {

            return " Nome: "
                + this.nome
                + " E-mail: "
                + this.email;
        }

    }
}
