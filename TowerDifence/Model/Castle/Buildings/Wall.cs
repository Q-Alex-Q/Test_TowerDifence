using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Castle.Buildings.Interfaces;

namespace TowerDifence.Model.Castle.Buildings
{
    public class Wall : IWall
    {
        public byte WallLvL { get; set; } = 1;

        public void WallLvlUp(uint coins)
        {
            if (WallLvL < 10)
            {
                WallLvL++;
            }
        }
    }
}
