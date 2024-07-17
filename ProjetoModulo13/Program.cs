using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            TrabalhandoComArquivos();
        }

        private static void TrabalhandoComArquivos()
        {
            var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
            //trabalhandoComArquivos.AulaCriandoArquivos();
            //trabalhandoComArquivos.AulaLendoArquivos();
            trabalhandoComArquivos.AulaExcluindoArquivos();
        }
    }
}
