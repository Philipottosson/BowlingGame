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

        [Fact]
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

        [Fact]
        public void SpareTest()
        {
            Game bowlingGame = new Game();
            bowlingGame.roll(2);
            bowlingGame.roll(8); //10 + countBonus += 1
            bowlingGame.roll(2); // 2 * 2 14
            bowlingGame.roll(2); // 16

            Assert.Equal(16, bowlingGame.Score());
        }

        [Fact]
        public void StrikeTest()
        {
            Game bowlingGame = new Game();
            bowlingGame.roll(10); //10 + countBonus +=2
            bowlingGame.roll(4); // 4 * 2 = 8
            bowlingGame.roll(4); // 4 * 2 = 8
            Assert.Equal(26, bowlingGame.Score());
        }

        [Fact]
        public void Create_()
        {


        }

    }
}
    