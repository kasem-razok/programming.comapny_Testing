using Kasemrazok_Exam.Interfaces;
using Kasemrazok_Exam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasemrazok_Exam.Model_Employee
{
    public class Devloper : Employee, ICalculateAdditionalSalary, ICalculateBonus
    {
        public Devloper() { }
        public Devloper(int Id, string Name, Decimal BasicSalaray, decimal Hours) : base(Id, Name, BasicSalaray, Hours)
        { }

        public decimal CalculateAdditionalSalary(decimal Hour)
        {
            return Hours * 6;
        }


        public decimal CalculateBonus()
        {
            if (BasicSalaray == 0)
                throw new Exception("erorr for result calculatebonus zero");
            return BasicSalaray * (3 / 100)+BasicSalaray + CalculateAdditionalSalary(Hours);
        }

        public override string ToString()
        {
            string result = "";
            result = base.ToString();
            result += $"\nCalculateBonus:{CalculateBonus()}";
            return result;
        }

    }
}
