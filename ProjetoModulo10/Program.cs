using System;
using Strings;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            TrabalhandoComStrings();
            //AulaSubstring();
        }
        private static void TrabalhandoComStrings()
        {
        var trabalhandoComStrings = new Strings.TrabalhandoComStrings();
        //Converter em Minusculas.
        //trabalhandoComStrings.ConverterLetrasMinusculas();

        //Converter em Maisculas.
        //trabalhandoComStrings.ConverterLetrasMaisculas();

        //Metodo Range.
        //trabalhandoComStrings.AulaRange();

        //Metodo Contains.
        //trabalhandoComStrings.AulaContains();

        //Metodo Trim.
        //trabalhandoComStrings.AulaTrim();

        //Metodo Stars/End.
        //trabalhandoComStrings.AulaStartWithEndWith();

        //Metodo Replace.
        //trabalhandoComStrings.AulaReplace();

        //Metodo Lenght
        trabalhandoComStrings.AulaLength();
        }

        private static void AulaSubstring()
        {
            var substring = new Strings.TrabalhandoComStrings();
            substring.Subs();
        }
    }

}