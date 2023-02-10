using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_PD
{
    /*
    Abstract base class representing a 'BebidaEmbriagante' with an abstract method
    'CuantoMeEmbriagaPorHora' to be overridden by concrete classes.
    */
    public abstract class BebidaEmbriagante
    {
        // Abstract method to be implemented by concrete classes
        public abstract int CuantoMeEmbriagaPorHora();
    }
}
