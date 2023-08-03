using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Aluno
    {
        public string nome;
        public double n1 = 0.0;
        public double n2 = 0.0;
        public double n3 = 0.0;

        public double NotaFinal()
        {
            return (n1 + n2 + n3);
        }
        string StatusAluno()
        {
            if (NotaFinal() >= 60) { return "Aprovado"; }
            else { return "Reprovado"; }
        }
        //public bool StatusAluno() {
        //if (NotaFinal() <= 60) { return true; }
        //else { return false; }

        //}
        public double NotaRestante()
        {
            if (StatusAluno() == "Aprovado")
            { return 0.0; }
            else { return 60 - NotaFinal(); }
        }

        public override string ToString()
        {
            return nome;
        }

    }
}
