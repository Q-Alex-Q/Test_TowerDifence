using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDifence.Model.Castle.Buildings.Interfaces
{
    public interface IHouse
    {
        public byte HouseLvL { get; set; }
        public void HouseLvlUp();

    }
}
