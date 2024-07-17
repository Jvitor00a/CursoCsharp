using System;
using Conversores;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AulaConvertParse();
            AulaTryParse();
        }

        public static void AulaConvertParse()
        {
            var conversores = new Conversor();
            conversores.ConvertAndParse();
        }

        public static void AulaTryParse()
        {
            var tryparse = new Conversor();
            tryparse.TryParse();
        }
    }
}
