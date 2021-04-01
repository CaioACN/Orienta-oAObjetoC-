using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //intanciando o objeto Pessoa do exemplo 02Metodos

            Pessoa obj = new Pessoa();
            obj.apresentar();
            obj.apresentar("Diego");
            obj.apresentar("Caio",35);
           
        }
    }
}
