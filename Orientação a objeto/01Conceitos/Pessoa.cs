using System;

class Pessoa
{

    // Atributos da classe Pessoa
    public string nome;
    public int idade;

    // Métodos ou funções - O método vioid não tem armazenamento de dados, apenas teremos exibição da mensagem na tela.
    public void mensagem()
{
    Console.WriteLine("Olá "+nome+" você tem "+idade+" anos." );
}

}