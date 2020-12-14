using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Castle.Buildings.Interfaces;

namespace TowerDifence.Model.Castle.Buildings
{
    public class Barrak : IBarrak
    {
        public byte BarakLvL { get; set; } = 1;
    }
}
