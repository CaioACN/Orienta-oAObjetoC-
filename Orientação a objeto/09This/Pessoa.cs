using System;

class Pessoa
{
    //Atributo 

    private string nome = "Caio Atributo da Classe";

    //Construtor 
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        //Imprime o parâmetro do classe pessoa
        Console.WriteLine(this.nome);
        //Imprime o atributo da classe pessoa
    }
}