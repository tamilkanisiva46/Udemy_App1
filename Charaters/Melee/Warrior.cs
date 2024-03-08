﻿using System;
using Udemy_App1.Armor.Mail;
using Udemy_App1.Weapon.Sharp;

namespace Udemy_App1.Characters.Melee
{
    public class Warrior
    {
        private string name;
        private string faction;

        private int abilitypoints;
        private int healthpoints;
        private int level;
        private int damage;

        private Chainlink bodyArmor;
        private Axe weapon;

        public string Name 
        {
            get 
            {
                return name;       
            } 
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    name = value;
                }
                else
                {
                    name = "User";
                    Console.WriteLine("The name is too short or too long! It must between 2 and 8 charactor.");
                }

            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcaster") 
                {
                    faction = value;
                }
                else
                {
                    faction = "Melee";
                    Console.WriteLine("Inappropriate faction! Should be \"Melee\" or \"Spellcaster\"");
                }
                
            }
        }
        public int Abilitypoints
        {
            get
            {
                return abilitypoints;
            }
            set
            {
                if(value >=0 && value <= 10)
                {
                    abilitypoints = value;
                }
                else
                {
                    abilitypoints = 0;
                    Console.WriteLine("Inappropriate value! Abilitypoints should be between 0 to 10");
                }

            }
        }
        public int Healthpoints
        {
            get
            {
                return healthpoints;
            }
            set
            {
                if(value >=1 && value <= 120)
                {
                    healthpoints = value;
                }
                else
                {
                    healthpoints = 1;
                    Console.WriteLine("Inappropriate value! Healthpoints should be between 1 to 120");
                }

            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    level = 100;
                    Console.WriteLine("Inappropriate value! Level should be between 1 to 100");
                }
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    damage = value;
                }
                else
                {
                    damage = 1;
                    Console.WriteLine("Inappropriate value! Damage should be between 1 to 100");
                }
            }
        }

        public Chainlink BoadyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Axe Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Warrior()
        {
            
        }

        public void Strike()
        {

        }

        public void Execute() 
        {

        }

        public void SkinHarden()
        {

        }
    }
}
