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
            CountBonuses();
        }

        private void CountBonuses()
        {
            if (_countBonus > 0)
            {
                _score += (_pinsDown * 2);
                _countBonus -= 1;
            }
            else _score += _pinsDown;
        }
    }
}