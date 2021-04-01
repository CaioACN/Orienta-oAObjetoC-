using System;

class Aluno
{
    // Cada aluno terá atributos

    public string nome;

    public double nota1, nota2;

    // Média
    public double media()
    {
        return ((nota1 + nota2)/2);
    }

    // Situação
    public string situação( double media){
        return media >= 7 ? "aprovado": "reprovado";
    }

    // Mensagem

    public void mensagem()
    {
        // Obter média
        double obterMedia = media();

        // Obter a situação
        string obterSituação = situação(obterMedia);

        // Mensagem
        Console.Write(nome + " está " + obterSituação + " com média " + obterMedia + ".\r\n");
     

    }
}