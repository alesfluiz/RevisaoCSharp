using System.Globalization;
using System;
using CourseRevisao.Entities;

namespace CourseRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario = new Funcionario();

            Console.Write("ID Funcionário: ");
            int nEmployee = int.Parse(Console.ReadLine());

            Console.Write("Nome  do Funcionário: ");
            string name = Console.ReadLine();

            Console.Write("Quantidade de horas trabalhadas: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Valor por hora: ");
            double vHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario = new Funcionario(nEmployee, name, new Salary(hours, vHours));

            Console.WriteLine(funcionario);
        }
    }
}