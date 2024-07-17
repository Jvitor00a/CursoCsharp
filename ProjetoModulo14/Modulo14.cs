namespace LinQ

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        string nomeCompleto = "João Vitor Alves";
        var resultado = nomeCompleto.Where(p => p == 'A');

        foreach(var letra in resultado)
    {
        Console.WriteLine(letra);
    }
    }
}