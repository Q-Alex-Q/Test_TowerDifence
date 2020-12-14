using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Castle.Buildings.Interfaces;

namespace TowerDifence.Model.Castle.Buildings
{
    public class House: IHouse
    {
        public byte HouseLvL { get; set; } = 1;

        public void HouseLvlUp()
        {
            if (HouseLvL < 25)
            {
                HouseLvL++;
            }
        }
    }
}
