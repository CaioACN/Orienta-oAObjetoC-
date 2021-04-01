using System;

class Pessoa 
{
    //Atributo nome

    private string nome;

    //Get (pegar o valor) e Set (enviar o valor)
    // Todo Get e Set é público

    public string Nome
    {
        get{return nome;}

        set{nome=value;}

    }
}