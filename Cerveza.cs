using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_PD
{
    /*
    Concrete class that inherits from 'BebidaEmbriagante' and overrides the
    'CuantoMeEmbriagaPorHora' method.
    */

    class Cerveza : BebidaEmbriagante
    {
        // Overridden method that returns the number 5
        public override int CuantoMeEmbriagaPorHora()
        {
            Console.WriteLine("Cerveza");
            return 5;
        }
    }
}
