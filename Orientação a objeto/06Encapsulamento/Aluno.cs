using System;

class Aluno
{

    //Atributos
    private double nota1, nota2;
    //As outras classes não terão acesso a nota1 e nota2, só a classe aluno terá acesso.

 //Média 
//As outras classes bão terão acesso ao método média, só a classe aluno terá acesso.
 private double media()
 {

     return ((nota1 + nota2)/2);
 }
//Mensagem pública
public void mensagem()
{
    Console.WriteLine("Informe a primeira nota: ");
    nota1 = Convert.ToInt32 (Console.ReadLine());

    Console.WriteLine("Informe a segunda nota: ");
    nota2 = Convert.ToInt32 (Console.ReadLine());
 
    Console.WriteLine("A média é "+media());
}


}