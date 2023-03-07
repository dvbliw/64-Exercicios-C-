using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio33
{
    internal class Aluno
    {
        private string numeroMatricula;
        private double notaProva;

        public void setAluno(string numeroMatricula, double notaProva)
        {
            this.numeroMatricula = numeroMatricula;
            this.notaProva = notaProva;
        }

        public double getNotaProva()
        {
            return notaProva;
        }
    }
}
