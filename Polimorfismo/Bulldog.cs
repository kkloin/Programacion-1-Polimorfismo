using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Bulldog : Perro
    {
        public override string Ladrar()
        {
            return "Bulldog ladrando";
        }
        public override string Dormir()
        {
            return "Bulldog durmiendo";
        }
        public override string Comer()
        {
            return "Bulldog comiendo";
        }
        public override string Jugar()
        {
            return "Bulldog jugando";
        }
        public override string Aullar()
        {
            return "Bulldog aullando";
        }
        public override string Saltar()
        {
            return "Bulldog saltando";
        }

    }
}
