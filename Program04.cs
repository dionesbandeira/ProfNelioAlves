/*

using ProfNelioAlves;
using System;
using System.Globalization;

internal class Program04
{
    private static void Main(string[] args)
    {

        Funcionario func01 = new Funcionario();

        Console.WriteLine("Informe o nome do funconario: ");
        func01.nome = Console.ReadLine();

        Console.WriteLine("Informe o salario bruto: ");
        func01.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Informe o valor para desconto do imposto: ");
        func01.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Funcionário: " + func01);

        Console.WriteLine("Informe o percentual para aumentar o salario: ");
        double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        func01.AumentarSalario(percentual);
        Console.WriteLine("Dados atualizados: \nNome do Funcionario: " + func01);

    }

}


*/