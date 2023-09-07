using System.Globalization;

namespace CourseRevisao.Entities
{
    internal class Funcionario
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Salary Salary { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, string name, Salary salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"\nID Funcionário: {ID} \nNome Funcionário: {Name} \nSalario = U$ {Salary.VSalary().ToString("F2", CultureInfo.InvariantCulture)} ";
        }


    }
}
