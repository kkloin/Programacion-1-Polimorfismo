using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Chihuahua : Perro
    {
        public override string Ladrar()
        {
            return "Chihuahua ladrando";
        }
        public override string Dormir()
        {
            return "Chihuahua durmiendo";
        }
        public override string Comer()
        {
            return "Chihuahua comiendo";
        }
        public override string Jugar()
        {
            return "Chihuahua jugando";
        }
        public override string Aullar()
        {
            return "Chihuahua aullando";
        }
        public override string Saltar()
        {
            return "Chihuahua saltando";
        }
    }
}
