class Validacao{

    public static void Executar(Pessoa pessoa){
        string nome = pessoa.nome;
        string email = pessoa.email;
        int idade = pessoa.idade;
        validaNome(nome);
    }
     public static bool validaNome(string _nome){
        bool teste = false;

        if (true)
        {
            
        }

        return teste;
     }
     public static bool validaEmail(string _email){
        bool teste = false;
        string[] emailSplitado = _email.Split('@');
        if(emailSplitado.Length > 1 && emailSplitado[0].Length >= 3 && emailSplitado[1].Length >= 3){
            teste = true;
        }

        return teste;
     }
     public static bool validaIdade(int _idade){
        bool teste = false;

        if (_idade > -1 && _idade < 151)
        {
            teste = true;
        }

        return teste;
     }
}
