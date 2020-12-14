using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDifence.Model.Castle.Buildings.Interfaces
{
    public interface ITample
    {
        public byte TampleLvL { get; set; }
        public void TampleLvlUp(uint coins);
    }
}
