using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_helper
{
    //This is for holding all our player objects and tracking who's turn it is.
    class Player_Collection
    {
        public int playerCount;

        //Linked list to keep track of player
        public List<Player> playerList = new List<Player>();
        //Track who's turn it is somehow
        public int turnCounter;
        public Player active_Player;

        public Player_Collection()
        {
            Player p = new Player();
            p.name = "John";
            p.id = 0;
            playerList.Add(p);
            //Constructor hree
            playerCount = 1;
            turnCounter = 0;
            active_Player = null;
        }

        public void endTurn()
        {
            //Do end turn clacs here
            //Active player = next player unless at end of list, then active player=first Player
        }

        public void deletePlayer(string playerName)
        {
            playerCount--;
        }

        //Generate player object and add it to the list
        public void addPlayer(Player p)
        {
            //Add player to list, incriment count
            playerList.Add(p);
            playerCount++;

        }

        public Player getPlayer(string playerName)
        {
            Player p = new Player();
            return p;
        }
    }
}
