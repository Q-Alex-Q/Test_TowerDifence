using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TowerDifence.Model.Castle.Buildings;
using TowerDifence.Model.Castle.Interfaces;

namespace TowerDifence.Model.Castle
{
    class Castle: ICastle
    {
        public Castle()
        {
            IsAlive = true;
            Coins = 500;
            People = 100;

            Army = new Army.Army();

            TownHall = new TownHall();
            Walls = new Wall();
            House = new House();
            Barraks = new Barrak();
            Tample = new Tample();
        }

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
