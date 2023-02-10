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
    class VinoTinto : BebidaEmbriagante
    {
        // Overridden method that returns the number 20
        public override int CuantoMeEmbriagaPorHora()
        {
            Console.WriteLine("Vino Tinto");
            return 20;
        }
    }
}
