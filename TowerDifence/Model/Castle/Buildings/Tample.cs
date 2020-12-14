using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Castle.Buildings.Interfaces;

namespace TowerDifence.Model.Castle.Buildings
{
    public class Tample : ITample
    {
        public byte TampleLvL { get; set; } = 1;

        public void TampleLvlUp(uint coins)
        {
            if (TampleLvL < 10)
            {
                TampleLvL++;
            }
        }
    }
}
