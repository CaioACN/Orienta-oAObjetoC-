using System;

class Pessoa
{
    //Atributos da classe Pessoa serão protegidos, apenas a classe que é criado este atributo ou método podem utilizar e as classes herdem a classe pessoa

    protected string nome;
    
    protected int idade;

    //Método

    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: "+nome);
        Console.WriteLine("Idade: "+idade);
        

    }
}