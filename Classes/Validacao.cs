class Validacao{

    public static void Executar(Pessoa pessoa){
        string nome = pessoa.nome;
        string email = pessoa.email;
        int idade = pessoa.idade;
        validaNome(nome);

    }
     public static bool validaNome(string a){
        bool teste = false;
        int tam = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == ' ')
            {
                break;
            }
            tam++;
        }
        Console.WriteLine(a.Length);
        if (true)
        {
            
        }

        return teste;
     }
     public static bool validaEmail(string b){
        bool teste = false;

        if(b.IndexOf('@') >= 3 && b.Length >= 7){
            teste
        }

        if (true)
        {
            
        }

        return teste;
     }
     public static bool validaIdade(int c){
        bool teste = false;

        if (c > -1 && c < 151)
        {
            return true;
        }

        return teste;
     }
}
