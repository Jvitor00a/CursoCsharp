namespace LinQ;

public class TrabalhandoComLinq
{

    //----------------
    //Metodo que procura algo que você queira em uma variavel ou local pre determinado
    //----------------
    public void AulaWhere()
    {
        /*
        string nomeCompleto = "João Vitor Alves";
        //--------
        //Metodo Func, usado para evitar repetição de código pois pode ser reaproveitada.
        //--------
        Func<char, bool> filtro = char => char == 'A'
        var resultado = nomeCompleto.Where(filtro);
        //--------
        // Metodo que não se reaproveita.
            //var resultado = nomeCompleto.Where(p => p == 'A'); 
        //--------

        var resultado = from c in nomeCompleto where c == 'V' select c; //--> Sintaxe de Consulta

        foreach(var letra in resultado)
        {
            Console.WriteLine(letra);
        }
        */

        var numeros = new int[] {1, 10, 15, 8, 55};
        var resultado = numeros.Where(p => p >= 10);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    //----------------
    //Metodo onde se ordena resultados em ordem alfabetica ou numerica.
    //----------------
    public void AulaOrdenacao()
    {
        /*
        var numeros = new int[] {1, 10, 15, 8, 55};

        var resultado = numeros.OrderBy(p => p);          
        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
        */
        
        var nomes = new string[] {"João", "Marcelo", "Mariana", "Joana"};

        var resultado = nomes.OrderBy(p => p);
        //-------
        // Metodo para fazer Decrescente / De tras pra frente.
        //-------
        var resultado2 = nomes.OrderByDescending(p => p); 
        foreach(var nome in resultado2)
        {
            Console.WriteLine(nome);
        }     
    }

    //----------------
    //Metodo onde você escolhe oque deseja ser selecionado.
    //----------------
    public void AulaTake()
    {
        var numeros = new int[] {1, 6, 4, 13, 9, 10, 7, 16,};

        var resultado = numeros.Where(p => p >= 10).Take(3).OrderByDescending(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }


    //----------------
    //Metodo onde se conta o número de elementos em um array.
    //----------------
    public void AulaCount()
    {
        var numeros = new int[] {1, 6, 4, 13, 9, 10, 7, 16,};

        //var resultado = numeros.Count();
        var resultado = numeros.Count(p => p >= 10);

        Console.WriteLine(resultado);
    }

    public void AulaFirstEFirstOrDefault()
    {
        var numeros = new int[] {1, 6, 4, 13, 9, 10, 7, 16,};

        //-------
        //Metodo que pega o primeiro elemento de seu Array, com ou sem especificação
        //-------
        var resultado = numeros.First(p => p > 15); //--> caso não haja um elemento com tal especificação, devolve uma EXCESSÃO.

        //-------
        //Metodo que pega o primeiro elemento de seu Array, com ou sem especificação
        //-------
        var resultado2 = numeros.FirstOrdefault(p => p > 15); //--> caso não haja um elemento com tal especificação, devolve o padrão (0/NULL)       

        Console.WriteLine(resultado);
        Console.WriteLine(resultado2);
    }
}