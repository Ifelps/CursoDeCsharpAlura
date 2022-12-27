using System;


/*O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as 
 * regras de alíquota. Ele descobriu no site da receita o seguinte:

 De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
 De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
 De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.*/

double salario = 2800.01;

Console.WriteLine("Digite o Salario");
salario = double.Parse(Console.ReadLine());

if (salario >= 1900.0 && salario <= 2800.0)
{

    Console.WriteLine("O IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142");
}
else if (salario >= 2800.01 && salario <= 3751.0)
{

    Console.WriteLine("O IR é de 15% e pode deduzir R$ 350");
}
else if (salario >= 3751.01 && salario <= 4664.00)
{
    Console.WriteLine("O IR é de 22.5% e pode deduzir R$ 636");
}
else
{
    Console.WriteLine("Valor fora das regras ");
}


/*obs: Uma expressão usando && é verdadeira somente se ambos os 
 * operadores forem verdadeiros (não zero). Uma expressão usando || 
 * é falsa somente se ambos os operadores forem falsos (zero).*/
