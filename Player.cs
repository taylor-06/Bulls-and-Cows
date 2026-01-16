namespace BullsAndCows
{
    public class Player
    {
        public string userName;
        public int timeElapsed;

        // Constructor for the player object.
        public Player(string userName, int timeElapsed)
        {
            this.userName = userName; // Gets the username
            this.timeElapsed = timeElapsed; // Gets the game time elapsed.
        }
    }
}