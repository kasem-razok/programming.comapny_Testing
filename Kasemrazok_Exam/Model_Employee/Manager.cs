using Kasemrazok_Exam.Interfaces;
using Kasemrazok_Exam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Kasemrazok_Exam.Model_Employee
{
    public  class Manager : Employee  , ICalculateAdditionalSalary , ICalculateAllOwance
    {
        public Manager(int Id, string Name, Decimal BasicSalaray , decimal Hours) : base(Id, Name, BasicSalaray , Hours)
        { }

        public decimal CalculateAdditionalSalary(decimal Hour)
        {
            return Hours * 6;
        }
        public decimal CalculateAllOwance()
        {
           return BasicSalaray * (5 / 100) + BasicSalaray + CalculateAdditionalSalary(Hours);
        }
        public override string ToString()
        {
            string result = "";
           result = base.ToString();
            result +=  $"\ncalcAllOwnce:{CalculateAllOwance}" ;
            return result;
        }
    }
}
