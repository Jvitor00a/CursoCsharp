namespace Modulo13;


public class TrabalhandoComArquivos
{
    public void AulaCriandoArquivos()
    {
        var escrever = new StreamWriter("Cadastro.txt", true); //--> Cria o arquivo, pode colocar o endereço total caso queira.
        Console.Write("Informe um nome:");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome: " + nome);
        escrever.WriteLine("----------------------------------");
        escrever.Close(); //--> fecha o arquivo
    }

    public void AulaLendoArquivos()
    {
        // ----------
        // Primeira maneira de ler um arquivo porém sem controle.
        //----------
        var conteudo = File.ReadAllText("Cadastro.txt");
        Console.WriteLine(conteudo);

        //----------
        // Dessa maneira se lê e tem controle de cada linha.
        //---------- 
        var ler = new StreamReader("Cadastro.txt");
        while (ler.EndOdStream)
        {
            var linha = ler.ReadLine();
            Console.Write(linha);
        }

        ler.Close();
    }

    public void AulaExcluindoArquivos()
    {
        
        if (File.Exists("Cadastro.txt"))
        {
            File.Delete("Cadastro.txt");
        }
    }
}