using System;

class Pessoa
{
//Exemplo de três métodos com o mesmo nome "apresentar", no entanto com parêmetros diferentes.
    //Método 01 - sem parâmetro
    public void apresentar()
    {
Console.WriteLine("Olá!");
    }

    //Método 02 - um parâmetro (nome)
    public void apresentar(string nome) 
    {
        Console.WriteLine("Olá " + nome + "!");

    }

    //Método 03 - dois parâmetro (nome e idade)
    public void apresentar(string nome,int idade){
        Console.WriteLine("Olá "+nome+ " ,você tem " +idade+ " anos de idade.");


    }
}