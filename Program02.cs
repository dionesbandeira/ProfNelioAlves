/*

using ProfNelioAlves;
using System.Globalization;

internal class Program02
{
    private static void Main(string[] args)
    {

        Funcionario Func01 = new Funcionario();
        Funcionario Func02 = new Funcionario();

        Console.WriteLine("Informe o Nome do Funcionario 01: ");
        Func01.nome = Console.ReadLine();
        Console.WriteLine("Informe o Salario do Funcionario 01: ");
        Func01.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Informe o Nome do Funcionario 02: ");
        Func02.nome = Console.ReadLine();
        Console.WriteLine("Informe o Salario do Funcionario 02: ");
        Func02.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        double salarioMedio = (Func01.salarioBruto + Func02.salarioBruto) / 2;


        Console.WriteLine("O Salario médio entre os funcionarios \n"+ Func01.nome+"\n"+ Func02.nome +"\né: "+salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

    }
}


*/