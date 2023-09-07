using System.Globalization;

namespace CourseRevisao.Entities
{
    internal class Salary
    {
        public double VHour { get; set; }
        public int QHour { get; set; }

        public Salary (int qHour, double vHour)
        {
            QHour = qHour;
            VHour = vHour;
        }

        public double VSalary()
        {
            double Result = QHour * VHour;
            return Result;
        }
    }
}
