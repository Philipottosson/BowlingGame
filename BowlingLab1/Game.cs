using Microsoft.VisualBasic.CompilerServices;

namespace BowlingLab1
{
    /*public class Players
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int PinsLeft { get; set; }
        public int Frames { get; set; }

        public Players(string name)
        {
            this.Name = name;
            Points = 0;
            PinsLeft = 10;
            Frames = 0;
        }
    }*/
    public class Game
    {
        private int rolled;
        private int pinsLeft;
        private int pinsDown;
        private List<int> score = new List<int>();
        private int frames = 1;
        private bool spare;
        private bool strike;
        private int countForBonus;




        public void roll(int pins)
        {
            if (pins > pinsLeft)
            {
                throw new ArgumentException();
            }
            else if (pinsLeft == 10)
            {
                pinsLeft -= pins;
                Strike();
            }
            else
            {
                pinsLeft -= pins;
                Spare();
            }
        }

        private void Spare()
        {
            if (pinsLeft == 0)
            {
                spare = true;
                countForBonus += 1;
            }
        }

        private void Strike()
        {
            if (pinsLeft == 0)
            {
                strike = true;
                countForBonus += 2;
            }
        }


        public int Score()
        {

            int total = 0;
            foreach (var points in score )
            {
                total += points;
            }
            return total;
        }
    
    }
}
/*
 * Frames => 10
 * Pins => 10
 * ShotsPerRound => 1-2
 * ShotsLastRound => 2-3
 * Points for X => 10 + 0-20
 * Points for / => 10 + 0-10
 */

/*
Bowling Rules
The game consists of 10 frames. In each frame the player has two rolls to knock down 10 pins. 
The score for the frame is the total number of pins knocked down, plus bonuses for strikes and spares.

A spare is when the player knocks down all 10 pins in two rolls. The bonus for that frame is the number of pins knocked down by the next roll.

A strike is when the player knocks down all 10 pins on his first roll. 
The frame is then completed with a single roll. 
The bonus for that frame is the value of the next two rolls.

In the tenth frame a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame. 
However no more than three balls can be rolled in tenth frame.

Requirements
Write a class Game that has two methods

void roll(int) is called each time the player rolls a ball. 
The argument is the number of pins knocked down.
int score() returns the total score for that game.
*/