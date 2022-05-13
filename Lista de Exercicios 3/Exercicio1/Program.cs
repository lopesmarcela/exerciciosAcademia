﻿//1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
//(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
//Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

//Exemplo:
//Digite um número inteiro positivo: -8
//Valor incorreto!
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.

int num;
do
{
    Console.WriteLine("Digite um número inteiro positivo: ");
    num = int.Parse(Console.ReadLine());
    if (num < 0 )
    {
        Console.WriteLine("Valor incorreto!");
    }
} while (num < 0);

Console.WriteLine("Número digitado: "+num);
Console.Write("Números inteiros pares entre 1 e "+num+": ");
for (int i = 1; i < num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i+" ");
    }
}