using System;

class Pessoa
{

    // Declaração dos atributos

    public double peso, altura;



    //Cálculo do IMC
      public double calculo()
      {
          return peso/(altura*altura);
      }

    //Situação da pessoa
      public string situacao(double imc)
      {
          string retorno;

       if( imc < 18.5){  
          retorno = "Abaixo do Peso.";
       }
       else if(imc < 25){
          retorno = "Peso normal.";
       }
       else if (imc < 30){
          retorno ="Acima do peso.";
       }
      else  if (imc < 35){
           retorno ="Obesidade I.";
       }
       else if (imc < 40){
           retorno = "Obesidade II.";
       }
       else{
          retorno ="Obesidade III.";
       }  

       return retorno;
     }

     //Mensagem 
     public void mensagem(){
         //obter cálculo
         double obterCalculo = calculo();
    //obter situação
    string obterSituação = situacao(obterCalculo);
    // Exibir mensagem
    Console.WriteLine("Seu IMC é de "+ obterCalculo);
    Console.WriteLine("Sua sitiação é "+ obterSituação);




     }
      


}