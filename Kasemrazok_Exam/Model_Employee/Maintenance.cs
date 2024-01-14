using Kasemrazok_Exam.Interfaces;
using Kasemrazok_Exam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasemrazok_Exam.Model_Employee
{
    public class Maintenance : Employee ,  ICalculateTotalSalary, ICalculateAdditionalSalary , ICalculateHardShip
    {
        public Maintenance(int Id, string Name, Decimal BasicSalaray , decimal Hours) : base(Id, Name, BasicSalaray , Hours)
        { }

        public decimal CalculateAdditionalSalary(decimal Hour)
        {
            return Hours * 6;
        }

        public decimal CalculateTotalSalary()
        {
            return (BasicSalaray * (5 / 100) + BasicSalaray + CalculateAdditionalSalary(Hours)) + CalculateHardShip() ;
        }

        public decimal CalculateHardShip()
        {
            return 100;
        }
        public override string ToString()
        {
            string result = "";
            result = base.ToString();
            result += $"\ncalcTotalsalary:{CalculateTotalSalary}";
            return result;
        }

    }
}
