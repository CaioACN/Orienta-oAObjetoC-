using System;

abstract class Padrao
{

    //Métodos obrigatórios que pode ser públic(público) ou protected (protegido)

    public abstract void taxaEmprestimo(double valor);

    //Teremos as regras de negócio nas pessoas físicas e pessoas jurídicas.



    //Método opcionais
    public void calculoPoupança(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$" +(valor * taxa ));
    }
}