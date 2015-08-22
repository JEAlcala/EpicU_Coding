using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player _player;
        private Random _random;
        public int PlayerScore { get; private set; }
        public string PlayerName { get; private set; }
        public Game(string playerName, Random random)
        {
            // Creating and setting the private objects.
            _player = new Player();
            _player.Name = playerName;
            PlayerName = _player.Name;
            _random = random;
        }
        private void determineMultiplier(Darts darts)
        {
            /*
            Each dart can score from 1 to 20, or the bullseye.
            If the dart lands in the outer band, multiply the dart's score by two. 
            If the dart lands in the inner band, multiply the dart's score by three. 
            If the dart lands in the outer bullseye, it is scored as 25. 
            If the dart lands in the inner bullseye, it is scored as 50.
            */
            if (darts.IsInnerBullseye)
                PlayerScore += darts.Score * 50;
            else if (darts.IsOuterBullseye)
                PlayerScore += darts.Score * 25;
            else if (darts.IsTriple)
                PlayerScore += darts.Score * 3;
            else if (darts.IsDouble)
                PlayerScore += darts.Score * 2;
            else
                PlayerScore += darts.Score;
        }
        // Public methods.
        //
        public void ThrowDarts()
        {
            //Random random = new Random();
            Darts dartsGame = new Darts(_random);
            // Loop to represent the 3 darts each player gets to play with
            for (int i = 0; i < 3; i++)
            {
                dartsGame.Throw();
                determineMultiplier(dartsGame);
            }
        }
    }
}