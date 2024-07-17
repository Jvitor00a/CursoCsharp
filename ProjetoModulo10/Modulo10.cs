namespace Strings
{
    public class TrabalhandoComStrings
    {
        public void ConverterLetrasMinusculas()
        {
            Console.Write("Favor digitar alguma coisa: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha.ToLower());
        }

        public void ConverterLetrasMaisculas()
        {
            Console.Write("Favor digitar alguma coisa: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha.ToUpper());
        }

        public void Subs()
        {
            Console.Write("Favor digitar alguma coisa: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha.Substring(0,6)); // Dois parâmentros, o primeiro onde inicia e o segundo onde termina.
        }

        public void AulaRange()
        {
            string nomeArquivo = "2024-07-08_Backup,bak";
            var ano = nomeArquivo[..4];// --> ".." Pega os primeiros caracteres.
            Console.WriteLine(ano);

            var extensao = nomeArquivo[^3]; //--> "^" Pega os ultimos caracteres.
            Console.WriteLine(extensao);

            var nome = nomeArquivo[11..^4]; //--> Dessa maneira você determina onde começa e onde termina.
            Console.WriteLine(ano);

            var apenasNome = nomeArquivo[..^4]; // --> Exclui os ultimos caracteres determinados.
            Console.WriteLine(apenasNome);

            var apenasNome = nomeArquivo[^4..]; // --> Exclui os primeiros caracteres determinados
            Console.WriteLine(apenasNome);


        }

        public void AulaContains()
        {
            string nomeArquivo = "2024-07-08_backup,bak";
            if (nomeArquivo.Contains("backup"))
            {
                Console.WriteLine("Palavra encontrada");
            }
            else 
            {
                Console.WriteLine("Não contem a Palavra");
            }
        }

        public void AulaTrim()
        {
            string teste = "**RAFAEL ALMEIDA**";
            Console.WriteLine("TRIM: " + teste.Trim('*'));
            Console.WriteLine("INICIO: " + teste.TrimStart('*'));
            Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
        }

        public void AulaStartWithEndWith()
        {
            string teste = "Curso Csharp";
            
            Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
            Console.WriteLine("FINAL: " + teste.EndsWith("Csharp02"));
        }

        public void AulaReplace()
        {
            string teste = "Curso Csharp";
            Console.WriteLine(teste);
            Console.WriteLine(teste.Replace("Csharp", "C#")); // --> Primeiro a palavra que vai ser substituida, Segundo oq vai substituir.
            
        }

        public void AulaLength()
        {
            string teste = Console.ReadLine();
            Console.WriteLine(teste);
            Console.WriteLine(teste.Length);
            
        }
    }
}