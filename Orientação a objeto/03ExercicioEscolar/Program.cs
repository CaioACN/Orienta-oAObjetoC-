using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar objeto da classe Aluno

            Aluno a = new Aluno();
            a.nome = "Caio";
            a.nota1 = 9;
            a.nota2 = 9.5;
            a.mensagem();
            a.nome = "Vicente";
            a.nota1 = 4;
            a.nota2 = 2;
            a.mensagem();

        }
    }
}
