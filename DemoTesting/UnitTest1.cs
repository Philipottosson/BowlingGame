using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;
using BowlingLab1;
using DemoTesting;


namespace DemoTesting
{
    public class UnitTest1
    {


        [Fact]
        public void Roll_One_Frame()
        {
            Game bowlingGame = new Game();
            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            Assert.Equal(5,bowlingGame.Score() );
        }

        [Fact]
        public void Roll_Game()
        {
            Game bowlingGame = new Game();

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            Assert.Equal(20,bowlingGame.Score());
        }

        [Fact]
        public void SpareTest()
        {
            Game bowlingGame = new Game();
            bowlingGame.Roll(2);
            bowlingGame.Roll(8); //10 + countBonus += 1
            bowlingGame.Roll(2); // 2 * 2 14
            bowlingGame.Roll(2); // 16

            Assert.Equal(16, bowlingGame.Score());
        }

        [Fact]
        public void StrikeTest()
        {
            Game bowlingGame = new Game();
            bowlingGame.Roll(10); //10 + countBonus +=2
            bowlingGame.Roll(4); // 4 * 2 = 8
            bowlingGame.Roll(4); // 4 * 2 = 8
            Assert.Equal(26, bowlingGame.Score());
        }
        [Fact]
        public void TestForSpareAtFrameTen()
        {
            Game bowlingGame = new Game();

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(3);

            bowlingGame.Roll(2);
            bowlingGame.Roll(8);

            bowlingGame.Roll(5);

            Assert.Equal(60, bowlingGame.Score());

        }

        [Fact]
        public void TestForStrikeAtFrameTen()
        {
            Game bowlingGame = new Game();

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(1);
            bowlingGame.Roll(1);

            bowlingGame.Roll(10); 

            bowlingGame.Roll(4);
            bowlingGame.Roll(6);

            Assert.Equal(38, bowlingGame.Score());

        }
        [Fact]

        public void TestForFrameEleven()
        {
            Game bowlingGame = new Game();

            Assert.Throws<ArgumentException>(() =>
            {
                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(1);
                bowlingGame.Roll(1);

                bowlingGame.Roll(10);

                bowlingGame.Roll(4);
                bowlingGame.Roll(6);

                bowlingGame.Roll(5);
            });

        }
        [Fact]
        public void TestIfElevenPinsHit() {
            Game bowlingGame = new Game();

            Assert.Throws<ArgumentException>(() => bowlingGame.Roll(11));
        }
        [Fact]
        public void TestIfElevenPinsHitOnTwoFrames()
        {
            Game bowlingGame = new Game();

            Assert.Throws<ArgumentException>(() =>
            {
                bowlingGame.Roll(6);
                bowlingGame.Roll(5);
            });
        }
    }
}
    