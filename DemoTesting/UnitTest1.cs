using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;
using BowlingLab1;


namespace DemoTesting
{
    public class UnitTest1
    {
        //private BowlingRules Bowling = new BowlingLab1();


        [Fact]
        public void Roll_One_Frame()
        {
            Game bowlingGame = new Game();
            bowlingGame.roll(2);
            bowlingGame.roll(3);

            Assert.Equal(5,bowlingGame.Score() );
        }

        public void Roll_Game()
        {
            Game bowlingGame = new Game();

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            bowlingGame.roll(2);
            bowlingGame.roll(3);

            Assert.Equal(50,bowlingGame.Score());
        }
        [TestMethod]
        public void SpareTest()
        {
            Game bowlingGame = new Game();
            bowlingGame.roll(2);
            bowlingGame.roll(8);
            bowlingGame.roll(2);
            bowlingGame.roll(2);

            Assert.Equal(16, bowlingGame.Score());
        }

        [TestMethod]
        public void StrikeTest()
        {
            Game bowlingGame = new Game();
            bowlingGame.roll(10);
            bowlingGame.roll(4);
            bowlingGame.roll(4);
            Asset.Equal(26, bowlingGame.Score());
        }

        [Fact]
        public void Create_()
        {


        }

    }
}
    