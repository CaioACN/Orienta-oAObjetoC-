using System;

    class Pessoa{


        public Pessoa()
        {
        // O Construtor é um tipo especial de método que usado para criar ou iniciar um objeto.
        // O Construtor é sempre público. Ele é executado assim que um objeto de determinado classe é instanciado.
    
        Console.WriteLine("Construtor excutado");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("olá " + nome);

    }
}
