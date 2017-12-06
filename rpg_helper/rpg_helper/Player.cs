using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_helper
{
    class Player
    {
        string name;
        int strength;
        int constitution;
        int dexterity;
        int wisdom;
        int charisma;
        int speed;

        int health;
        //Use in menu?
        enum Race_options
        {
            Drawf,
            Elf,
            Human,
            Halfing
        };
        //Fill in addtional classes here
        enum Class_options
        {
            Acolyte,
            Folk_Hero,
            Warrior,
            Mage
        };
        enum appended_Skills
        {
            test,
            test2
        };
        Race_options races;
        Class_options playerClass;

        //Keeps track of extra skills
        List<appended_Skills> extraSkills = new List<appended_Skills>();
    }
}
