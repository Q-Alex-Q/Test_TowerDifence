using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDifence.Model.Army.Interface
{
    interface ISoldier
    {
        public byte Armor { get; set; }
        public byte Damage { get; set; }
        public byte Speed { get; set; }
        public byte Delay { get; set; }
        public byte Cost { get; set; }
    }
}
