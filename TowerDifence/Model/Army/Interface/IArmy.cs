using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDifence.Model.Army.Interface
{
    interface IArmy
    {
        public List<Recruit> Recruits { get; set; }
        public List<Bowman> Bowmans { get; set; }
        public List<Footman> Footmans { get; set; }
        public List<Horseman> Horsemans { get; set; }
    }
}
