namespace Classes;

class Program
{
    static void Main(string[] args)
    {
       Pessoa [] pessoa = new Pessoa[3];
        for (int i = 0; i < pessoa.Length; i++)
        {
            pessoa[i] = new Pessoa();
            Console.WriteLine($"Escreva o email da {i+1} pessoa:");
            pessoa[i].email = Console.ReadLine()!;
            Console.WriteLine($"Escreva o Nome da {i+1} pessoa:");
            pessoa[i].nome = Console.ReadLine()!;
            Console.WriteLine($"Escreva a idade da {i+1} pessoa:");
            pessoa[i].idade = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"A pessoa mais nova é : {Exercicio.Calcule(pessoa)[0].nome} com {Exercicio.Calcule(pessoa)[0].idade}");
        Console.WriteLine($"A pessoa mais velha é : {Exercicio.Calcule(pessoa)[1].nome} com {Exercicio.Calcule(pessoa)[1].idade}");
        

    }
}

