using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Army.Interface;

namespace TowerDifence.Model.Army
{
    public class Recruit : ISoldier
    {
        public byte Armor { get; set; } = 2;
        public byte Damage { get; set; } = 2;
        public byte Speed { get; set; } = 1;
        public byte Delay { get; set; } = 1;
        public byte Cost { get; set; } = 2;
    }
}
