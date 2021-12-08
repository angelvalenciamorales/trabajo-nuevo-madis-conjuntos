using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Conjuntos
{
    public abstract class Conjunto
    {
        public HashSet<string> conjuntoA;
        public HashSet<string> conjuntoB;

        public Conjunto(HashSet<string>pConjuntoA,HashSet<string>pConjuntoB)
        {
            this.conjuntoA = pConjuntoA;
            this.conjuntoB = pConjuntoB;
        }

        public abstract HashSet<string> operarUnion();

        public abstract HashSet<string> operarInterseccion();

        public abstract HashSet<string> operarDiferenciaAB();

        public abstract HashSet<string> operarDiferenciaSimetrica();
    }
}