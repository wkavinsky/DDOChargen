using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDO_Character_Generator
{
    class Character
    {
        private bool edited = false;
        static int maxlevel = 25; // Maximum Character Level
        private LevelUp[] levelup = new LevelUp[maxlevel];
        private int characterlevel = 0;
        private int basestrength = 0;
        private int basedexterity = 0;
        private int baseconstitution = 0;
        private int baseintelligence = 0;
        private int basewisdom = 0;
        private int basecharisma = 0;

 
        public void ResetCharacter()
        {
            edited = true;
        }

        public bool LoadCharacter()
        {
            return true;
        }

        public bool SaveCharacter()
        {
            return true;
        }

        public bool Edited()
        {
            return edited;
        }
    }
}
