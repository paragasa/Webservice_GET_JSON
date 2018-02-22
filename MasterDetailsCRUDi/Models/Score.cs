﻿
using System;
using SQLite;

namespace MasterDetailsCRUDi.Models
{
    public class Score : Entity<Item>
    {
        public int ScoreTotal { get; set; }

        // The Date the game played, and when the score was saved
        public DateTime GameDate { get; set; }

        // Tracks if auto battle is true, or if user battle = false
        public bool AutoBattle { get; set; }

        // The number of turns the battle took to finish
        
        // Missign property, to add as part of the SQL lecture...
        //public int TurnNumber { get; set; }

        // The count of monsters slain during battle
        public int MonsterSlainNumber { get; set; }

        // The total experience points all the characters received during the battle
        public int ExperienceGainedTotal { get; set; }

        // A list of all the characters at the time of death and their stats.  Needs to be in json format, so saving a string
        public string CharacterAtDeathList { get; set; }

        // All of the monsters killed and their stats. Needs to be in json format, so saving as a string
        public string MonstersKilledList { get; set; }

        // All of the items dropped and their stats. Needs to be in json format, so saving as a string
        public string ItemsDroppedList { get; set; }

        public Score()
        {
            GameDate = DateTime.Now;    // Set to be now by default.
            AutoBattle = false;         //assume user battle
            CharacterAtDeathList = null;
            MonstersKilledList = null;
            ItemsDroppedList = null;
        }

        public void Update(Score newData)
        {
            if (newData == null)
            {
                return;
            }

            // Update all the fields in the Data, except for the Id
            Name = newData.Name;
            ScoreTotal = ScoreTotal;
        }
    }
}