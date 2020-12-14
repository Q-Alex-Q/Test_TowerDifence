using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Army.Interface;

namespace TowerDifence.Model.Army
{
    public class Horseman: ISoldier
    {
        public byte Armor { get; set; } = 7;
        public byte Damage { get; set; } = 20;
        public byte Speed { get; set; } = 3;
        public byte Delay { get; set; } = 4;
        public byte Cost { get; set; } = 48;
    }
}
