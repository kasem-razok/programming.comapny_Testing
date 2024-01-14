using Kasemrazok_Exam.Model_Employee;

namespace Exam.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestingDecloper_Exceptions()
        {
            Devloper devlopers = new Devloper(1,"Kasem",0 , 6);
            Assert.Throws<Exception>(() => devlopers.CalculateBonus());
        }

        [Fact]
        public void TestingDevloper()
        {
            Devloper devlopers = new Devloper(1, "Kasem", 100, 6);
            devlopers.CalculateBonus();
            var acual = devlopers.CalculateBonus() ;
            decimal expected = 136m ;

           
            //Assert.Equal(expected , devlopers.CalculateBonus());
            Assert.Equal(expected, acual);
        }
    }
}