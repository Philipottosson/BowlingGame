using System;
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

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            Assert.Equal(20,bowlingGame.Score());
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
        public void TestForSpareAtFrameTen()
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
            bowlingGame.roll(8);

            bowlingGame.roll(5);

            Assert.Equal(60, bowlingGame.Score());

        }

        [Fact]
        public void TestForStrikeAtFrameTen()
        {
            Game bowlingGame = new Game();

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(1);
            bowlingGame.roll(1);

            bowlingGame.roll(10); //28

            bowlingGame.roll(4);
            bowlingGame.roll(6);

            Assert.Equal(38, bowlingGame.Score());

        }
        [Fact]

        public void TestForFrameEleven()
        {
            Game bowlingGame = new Game();

            Assert.Throws<ArgumentException>(() =>
            {
                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(1);
                bowlingGame.roll(1);

                bowlingGame.roll(10);

                bowlingGame.roll(4);
                bowlingGame.roll(6);

                bowlingGame.roll(5);
            });

        }
        [Fact]
        public void TestIfElevenPinsHit() {
            Game bowlingGame = new Game();

            Assert.Throws<ArgumentException>(() => bowlingGame.roll(11));
        }
        [Fact]
        public void TestIfElevenPinsHitOnTwoFrames()
        {
            Game bowlingGame = new Game();

            Assert.Throws<ArgumentException>(() =>
            {
                bowlingGame.roll(6);
                bowlingGame.roll(5);
            });
        }
    }
}
    