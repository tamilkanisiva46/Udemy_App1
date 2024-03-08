using System;

namespace Udemy_App1.Armor.Cloth
{
    public class ClothRobe
    {
        private int armorpoints;

        public int Armorpoints
        {
            get
            {
                return armorpoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    armorpoints = value;
                }
                else
                {
                    armorpoints = 0;
                    Console.WriteLine("Inappropriate value! Armorpoints should be between 1 to 100");
                }
            }
        }

        public ClothRobe()
        {
            
        }
    }
}
