using System;

class Variaveis
{


    static void Main(string[] args)
    {
        //inteiro
        int num;
        num = 6;
        Console.WriteLine("numero interiro " + num);

        //double
        double num2;
        num2 = 7.0 / 5;
        Console.WriteLine("numero double " + num2);
        //para ter o resultado da divisão com valor quebrado colocar ponto EX: 7 fica 7.0


        //Recebe double e converte para inteiro
        double num3;
        num3 = 3.5;
        int num4;
        num4 = (int)num3;

        Console.WriteLine("Recebe double e converte para inteiro " + num4);

        //float
        float num5 = 5.04f;
        Console.WriteLine("Float " + num5);

        //char
        char var = 'D';
        Console.WriteLine("char " + var);

        //string
        string var1 = "texto";
        Console.WriteLine("string " + var1);

        //boleano
        bool var2 = false;
        Console.WriteLine("boleano " + var2);
        var2 = true;
        Console.WriteLine("boleano " + var2);

       


    }


}

