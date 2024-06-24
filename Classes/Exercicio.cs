class Exercicio{
    public static Pessoa [] Calcule (Pessoa[] pessoa){
        Pessoa [] aux = [pessoa[0], pessoa[0]];
        // aux [0] = new Pessoa();
        // aux [1] = new Pessoa();
        // pessoa[0].idade = 0; 
        // pessoa[1].idade= 150;
        // for (int i = 0; i < pessoa.Length; i++)
        // {
            
        //     if(pessoa[i].idade > aux[0].idade)
        //         aux[0].idade = pessoa[i].idade;
        //     else if(pessoa[i].idade < aux[1].idade)
        //         aux[1].idade = pessoa[i].idade;
        // }
        for (int i = 1; i < pessoa.Length; i++){
            if(pessoa[i].idade > aux[1].idade) {
                aux[1] = pessoa[i];
            }

            if(pessoa[i].idade < aux[0].idade) {
                aux[0] = pessoa[i];
            }
        }
        return aux;
    }
}