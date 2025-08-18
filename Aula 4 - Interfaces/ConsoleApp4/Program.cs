using System;
using Microsoft.VisualBasic;

interface IVeiculo{

    //Atributos + Getters e Setters
    public string Nome
        {get; set;}

    //Métodos Vazios

    public void Ligar();
    public void Desligar();
}

class Aviao : IVeiculo{

    //Atributos + Getters e Setters
    public string Nome
        {get; set;} = "";
    
    private bool status = false;

    //Métodos
    public void Ligar(){
        Console.WriteLine($"Avião {Nome} está ligando. Bom voo.");
        status = true;
    }

    public void Desligar(){
        Console.WriteLine($"Avião {Nome} está desligando. Obrigado por voar.");
        status = false;
    }

    public string Info(){
        return "Status do Avião: " + status;
    }
}

class Program{
    public static void Main(string[] args){
        //Instanciação
        Aviao aviao_1 = new Aviao();
            //Atributos
            aviao_1.Nome = "Airbus";
            aviao_1.Ligar();
            Console.WriteLine(aviao_1.Info()); //agindo como getter

            aviao_1.Desligar();
            Console.WriteLine(aviao_1.Info());
    }
}