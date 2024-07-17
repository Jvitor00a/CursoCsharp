namespace Conversores
{
    public class Conversor
    {
        public void ConvertAndParse()
        {
            //int numero = int.Parse("1"); // Primeira forma de converter o tipo.    
            int numero = Convert.ToInt32("1");             
            Console.WriteLine(numero);
            bool verdadeiro = bool.Parse("true");
            Console.WriteLine(verdadeiro);
        }

        public void TryParse()
        {
            var numero = "123456";

            if(int.TryParse(numero, out int NumeroConvertido))
            {
                Console.WriteLine("!Numero foi convertido com sucesso!");
            }

            Console.WriteLine(NumeroConvertido);
        }
    }
}
