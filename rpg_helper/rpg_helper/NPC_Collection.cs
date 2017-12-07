using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_helper
{
    //Collection class for npcs, manages additional things like deleteing and searching for the main class.
    class NPC_Collection
    {
        public List<NPC> npc_List = new List<NPC>();
        public int npcCount;
        public NPC_Collection()
        {
            //Constructor here
            npcCount = 0;
        }

        public void addNPC(NPC npc)
        {
            npc_List.Add(npc);
            npcCount++;
        }

        public void deleteNPC(string  npcName)
        {
            npcCount--;
        }

        //Will need to be worked on later, gets a specific npc from the npc list.
        public NPC getNPC(string npcName)
        {
            NPC npc = new NPC();
            return npc;
        }
    }
}
