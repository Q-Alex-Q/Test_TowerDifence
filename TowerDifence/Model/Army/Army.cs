using System;
using System.Collections.Generic;
using System.Text;
using TowerDifence.Model.Army.Interface;

namespace TowerDifence.Model.Army
{
    public class Army: IArmy
    {
        public Army()
        {
            Recruits = new List<Recruit>();
            Bowmans = new List<Bowman>();
            Footmans = new List<Footman>();
            Horsemans = new List<Horseman>();
        }
        public byte Difence { get; set; }
        public List<Recruit> Recruits { get; set; }
        public List<Bowman> Bowmans { get; set; }
        public List<Footman> Footmans { get; set; }
        public List<Horseman> Horsemans { get; set; }
    }
}
