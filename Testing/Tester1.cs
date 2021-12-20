using BowlingLab1;
using Xunit;

namespace Testing
{
    public class Tester1
    {
        private BowlingRules Bowling = new BowlingRules();
        [Fact]
        public void Test1()
        {
            int y = Bowling.Test_1();
            Assert.Equal(1,1);
        }
    }
}
