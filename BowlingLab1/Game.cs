using Microsoft.VisualBasic.CompilerServices;

namespace BowlingLab1
{
    public class Game
    {
        private int _pinsLeft = 10;
        private int _pinsDown;
        private int _score;
        private int _nrThrow = 0;
        private int _frames = 1;
        private int _countBonus;

        public void Roll(int pins)
        {
            _pinsDown = pins;
            if (_pinsDown > _pinsLeft || _frames >= 12)
            {
                throw new ArgumentException();
            }

            ScoreCount();
            StrikeOrSpare();
            Reset();
        }

        private void StrikeOrSpare()
        {
            if (CheckIfStrike())
            {
                Strike(); 
            }
            else if (CheckIfSpare())
            {
                Spare();
            }
            else if (NoBonusLastFrame())
            {
                _countBonus = 0;
            }
        }

        private bool NoBonusLastFrame()
        {
            return _frames >= 9;
        }

        private bool CheckIfSpare()
        {
            return _pinsLeft == 0 && _nrThrow == 2 && _frames <= 9;
        }

        private bool CheckIfStrike()
        {
            return _pinsLeft == 0 && _nrThrow == 1 && _frames <= 9;
        }

        private void Spare()
        {
            _countBonus += 1;
        }

        private void Strike()
        { 
            _countBonus += 2;
        }

        private void Reset()
        {
            if (_nrThrow != 2 && _pinsLeft != 0) return;
            _nrThrow = 0;
            _pinsLeft = 10;
            _frames++;
        }

        public int Score()
        {
            return _score;
        }


        private void ScoreCount()
        {
            _nrThrow += 1;
            _pinsLeft -= _pinsDown;
            if (_countBonus > 0)
            {
                _score += (_pinsDown * 2);
                _countBonus -= 1;

            }
            else _score += _pinsDown;
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