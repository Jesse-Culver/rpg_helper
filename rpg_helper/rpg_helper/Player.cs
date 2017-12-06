using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_helper
{
    class Player
    {
        public string name
        {
            get;
            set;
        }
        public int id
        {
            get;
            set;
        }
        public int strength;
        public int constitution;
        public int dexterity;
        public int wisdom;
        public int charisma;
        public int speed;

        public int health;
        //Use in menu?
        public enum Race_options
        {
            Drawf,
            Elf,
            Human,
            Halfing
        };
        //Fill in addtional classes here
        public enum Class_options
        {
            Acolyte,
            Folk_Hero,
            Warrior,
            Mage
        };
        //This is extra skills like save modifiers and such
        public enum appended_Skills
        {
            test,
            test2
        };
        public Race_options races;
        public Class_options playerClass;

        //Keeps track of extra skills
        List<appended_Skills> extraSkills = new List<appended_Skills>();
    }
}
