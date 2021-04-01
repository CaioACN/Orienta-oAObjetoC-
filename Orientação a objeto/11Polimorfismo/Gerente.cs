using System;

class Gerente : Imposto
{
    //Método

    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("desconto gerente do vale alimentação R$"+(salario *0.15));
    }
    
}