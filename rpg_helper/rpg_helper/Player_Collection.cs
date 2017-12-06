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
        int playerCount;

        //Linked list to keep track of player
        List<Player> playerList = new List<Player>();
        //Track who's turn it is somehow
        int turnCounter;
        Player active_Player;

        public void endTurn()
        {
            //Do end turn clacs here
            //Active player = next player unless at end of list, then active player=first Player
        }

        public void deletePlayer(string playerName)
        {
           
        }

        //Generate player object and add it to the list
        public void addPlayer(Player p)
        {

        }

        public Player getPlayer(string playerName)
        {
            Player p = new Player();
            return p;
        }
    }
}
