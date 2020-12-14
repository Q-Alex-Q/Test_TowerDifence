using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Army.Interface;

namespace TowerDifence.Model.Army
{
    public class Footman: ISoldier
    {
        public byte Armor { get; set; } = 6;
        public byte Damage { get; set; } = 8;
        public byte Speed { get; set; } = 1;
        public byte Delay { get; set; } = 3;
        public byte Cost { get; set; } = 20;
    }
}
