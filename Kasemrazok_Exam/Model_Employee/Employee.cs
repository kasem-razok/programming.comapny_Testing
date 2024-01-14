using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasemrazok_Exam.Model
{
    public  class Employee
    {

        public Employee() { }
        public Employee (int Id , string Name , Decimal BasicSalaray , decimal Hours)
        {
            this.Id = Id;
            this.Name = Name;   
            this.BasicSalaray = BasicSalaray;
            this.Hours = Hours;   

        }
        public decimal Hours { get; set; }   
        protected int Id {  get; set; } 
        protected string Name { get; set; } 
        protected decimal BasicSalaray { get; set; }

        public override string ToString()
        {
            string result = "";
            result = $"\nid:{Id}" + $"\nname:{Name}" + $"\nbasicsalary{BasicSalaray}";
            return result;
        }
    }
}
