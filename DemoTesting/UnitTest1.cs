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
            Assert.Equal(60,bowlingGame.Score());
        }

        [Fact]
        public void Create_()
        {


        }

    }
}
    