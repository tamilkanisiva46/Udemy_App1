using System;

namespace Udemy_App1.Weapon.Blunt
{
    public class Staff
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    damage = value;
                }
                else
                {
                    damage = 0;
                    Console.WriteLine("Inappropriate value! Damage should be between 1 to 100");
                }
            }
        }

        public Staff()
        {
            
        }

        public void Empower()
        {

        }
    }
}
