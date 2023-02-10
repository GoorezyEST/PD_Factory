namespace Factory_PD
{
    internal class Program
    {
        /*
        Main class that calls the Factory class 'Creador' to create an object of type 'BebidaEmbriagante'
        depending on the input, and displays the 'CuantoMeEmbriagaPorHora' result.
        */

        static void Main(string[] args)
        {
            // Call the factory to create an object of type 'BebidaEmbriagante' (either Cerveza or VinoTinto)
            BebidaEmbriagante oBebida = Creador.CreadorBebida(Creador.CERVEZA);
            // Display the result of 'CuantoMeEmbriagaPorHora' method
            Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
        }
    }
}