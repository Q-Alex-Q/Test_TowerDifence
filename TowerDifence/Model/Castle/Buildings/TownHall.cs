using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Castle.Buildings.Interfaces;

namespace TowerDifence.Model.Castle.Buildings
{
    public class TownHall : ITownHall
    {
        public byte TownLvL { get; set; } = 1;
        public byte TaxLvl { get; set; } = 10;

        public void TownLvlUp()
        {
            if (TownLvL < 10)
            {
                TownLvL++;
            }
        }
        public void TownTaxLvlUp()
        {
            if (TaxLvl < 28)
            {
                TaxLvl++;
            }
        }
    }
}
