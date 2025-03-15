using ToDoManagement.Implementation;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Caculate_performs_addition()
        {
            /*
// arrange
vaue a   1
value b   2
value c   3

// act
Calculate(a,b) 

// check
produces  c
 */
            //Arange
            var a = 1;
            var b = 2;
            var c = 3;
            var calculator = new Caculator();

            //act
            var result = calculator.Calculate(a, b);

            //Check
            Assert.Equal(c, result);
        }
    }
}
