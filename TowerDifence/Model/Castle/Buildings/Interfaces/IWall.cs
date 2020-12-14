using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDifence.Model.Castle.Buildings.Interfaces
{
    public interface IWall
    {
        public byte WallLvL { get; set; }
        public void WallLvlUp(uint coins);
    }
}