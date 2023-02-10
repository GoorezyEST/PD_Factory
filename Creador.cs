using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_PD
{
    /*
    Factory class that creates an object of type 'BebidaEmbriagante' (either Cerveza or VinoTinto)
    based on the input.
    */
    public class Creador
    {
        // Constants to represent the type of 'BebidaEmbriagante' to create
        public const int VINO_TINTO = 1;
        public const int CERVEZA = 2;
        // Factory method that returns an object of type 'BebidaEmbriagante'
        public static BebidaEmbriagante CreadorBebida(int Tipo)
        {
            // Switch statement to create an object based on the input 'Tipo'
            switch (Tipo)
            {
                case VINO_TINTO:
                    return new VinoTinto();
                case CERVEZA:
                    return new Cerveza();
                default: return null;
            }
        }
    }
}
