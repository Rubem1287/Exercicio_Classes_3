using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Classes_3
{
    class Aluno
    {
        public string Nome;

        public double Nota1;

        public double Nota2;

        public double Nota3;


        public double Soma()
        {
            return (Nota1 + Nota2 + Nota3);
        }

        public double Falta()
        {
            double falta = 60 - (Nota1 + Nota2 + Nota3);

            return (falta);
        }

    }
}
