using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDifence.Model.Castle.Buildings.Interfaces
{
    public interface ITownHall
    {
        public byte TownLvL { get; set; } // Max - 10
        public byte TaxLvl { get; set; } // Min - 10% / Max - 28%
        public void TownLvlUp();
        public void TownTaxLvlUp();
    }
}
