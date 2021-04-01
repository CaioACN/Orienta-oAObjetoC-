using System;

namespace _01Conceitos
{
    class Program
    {
         static void Main(string[] args)
        {
          // Instanciar um objeto
          Pessoa obj = new Pessoa();
          obj.nome = "Caio";
          obj.idade = 35;
          obj.mensagem();
        }
    }
}
