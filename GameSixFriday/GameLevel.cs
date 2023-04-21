using System.Collections.Generic;

namespace GameSixFriday
{
    public class GameLevel
    {
        private int totalRooms;
        private Difficulty difficulty;
        private static int totFoes;
        private Dictionary<int, Foe> roomAndFoe = new Dictionary<int, Foe>();

        public GameLevel(int totalRooms, Difficulty difficulty)
        {
            this.totalRooms = totalRooms;
            this.difficulty = difficulty;
        }

        public void SetFoeInRoom(int room, Foe foe)
        {
            roomAndFoe.Add(room, foe);
            totFoes += 1;
        }

        public Difficulty GetDifficulty() => this.difficulty;
        public int GetNumRooms() => this.totalRooms;
        public int GetNumFoes() => totFoes;
    }
}