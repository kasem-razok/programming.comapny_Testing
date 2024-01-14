using Kasemrazok_Exam.Model_Employee;

namespace Kasemrazok_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var devloper = new Devloper(1, "ahmad", 200, 6);
            var maintenance = new Maintenance(2, "salem", 188, 6);
            var manger = new Manager(3, "mohammad", 200, 6);
            Console.WriteLine(devloper);
            Console.WriteLine(maintenance); 
            Console.WriteLine(manger);  

            Console.ReadKey();
        }
    }
}
