using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Castle.Buildings;

namespace TowerDifence.Model.Castle.Interfaces
{
    public interface ICastle
    {
        public bool IsAlive { get; set; }
        public int Coins { get; set; }
        public int People { get; set; }

        public Army.Army Army { get; set; }

        public TownHall TownHall { get; set; }
        public Wall Walls { get; set; }
        public House House { get; set; }
        public Barrak Barraks { get; set; }
        public Tample Tample { get; set; }
    }
}
