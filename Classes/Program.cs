namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        Pessoa [] pessoa = new Pessoa[3];
        bool emailValido = false, nomeValido = false, idadeValida = false;
        for (int i = 0; i < pessoa.Length; i++)
        {
            pessoa[i] = new Pessoa();
            do {
                Console.WriteLine($"Escreva o email da {i+1} pessoa:");
                pessoa[i].email = Console.ReadLine()!;
                if(Validacao.validaEmail(pessoa[i].email)) {
                    emailValido = true;
                }
            } while(!emailValido);

            do {
                Console.WriteLine($"Escreva o Nome da {i+1} pessoa:");
                pessoa[i].nome = Console.ReadLine()!;
                if(Validacao.validaNome(pessoa[i].nome)) {
                    nomeValido = true;
                }
            } while(!nomeValido);

            do {
                Console.WriteLine($"Escreva a idade da {i+1} pessoa:");
                pessoa[i].idade = int.Parse(Console.ReadLine()!);
                if(Validacao.validaIdade(pessoa[i].idade)) {
                    idadeValida = true;
                }
            } while(!idadeValida);
        }
        Console.WriteLine($"A pessoa mais nova é : {Exercicio.Calcule(pessoa)[0].nome} com {Exercicio.Calcule(pessoa)[0].idade}");
        Console.WriteLine($"A pessoa mais velha é : {Exercicio.Calcule(pessoa)[1].nome} com {Exercicio.Calcule(pessoa)[1].idade}");
        

    }
}

