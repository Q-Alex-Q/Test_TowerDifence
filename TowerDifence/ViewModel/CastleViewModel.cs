using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TowerDifence.Model.Army;
using TowerDifence.Model.Castle;
using TowerDifence.Model.Castle.Buildings;

namespace TowerDifence.ViewModel
{
    class CastleViewModel: BaseViewModel
    {
        public CastleViewModel()
        {
            InitCastle();
            InitMap();
        }

        #region InitCastle
        private void InitCastle()
        {
            Castle castle = new Castle();
            IsAlive = castle.IsAlive;
            Coins = castle.Coins;
            People = castle.People;

            Army = castle.Army;

            TownHall = castle.TownHall;
            TownHallLvl = castle.TownHall.TownLvL;
            TownHallTaxLvl = castle.TownHall.TaxLvl;

            Wall = castle.Walls;
            WallLvl = castle.Walls.WallLvL;

            House = castle.House;
            HouseLvl = castle.House.HouseLvL;

            Barrak = castle.Barraks;
            BarrakLvl = castle.Barraks.BarakLvL;

            Tample = castle.Tample;
            TampleLvl = castle.Tample.TampleLvL;

        }
        #endregion


        #region 2D_Map

        public void InitMap()
        {
            ColumnHeaders = columnHeaders;
            RowHeaders = rowHeaders;
            Data2D = data2D;
        }

        private String[] _columnHeaders;
        public String[] ColumnHeaders
        {
            get { return _columnHeaders; }
            set { _columnHeaders = value; }
        }

        private String[] _rowHeaders;
        public String[] RowHeaders
        {
            get { return _rowHeaders; }
            set { _rowHeaders = value; }
        }

        private bool[,] _data2D;
        public bool[,] Data2D
        {
            get { return _data2D; }
            set { _data2D = value; }
        }


        String[] columnHeaders = { "A", "B", "C", "D", "E", "F" };
        String[] rowHeaders = { "1", "2", "3", "4", "5", "6" };
        bool[,] data2D = {
            { true, true, false, false, false, false },
            { true, true, false, false, false, false },
            { true, true, false, false, false, false },
            { true, true, false, false, false, false },
            { true, true, false, false, false, false },
            { true, true, false, false, false, false }
        };

        #endregion


        #region IsAlive
        private bool _IsAlive;
        public bool IsAlive
        {
            get { return _IsAlive; }
            set
            {
                _IsAlive = value;
                OnPropertyChanged(nameof(IsAlive));
            }
        }
        #endregion

        #region Coins
        private int _Coins;

        public int Coins
        {
            get { return _Coins; }
            set { _Coins = value;
                OnPropertyChanged(nameof(Coins));
            }
        }
        #endregion

        #region People
        private int _People;
        public int People
        {
            get { return _People; }
            set
            {
                _People = value;
                OnPropertyChanged(nameof(People));
            }
        }
        private ICommand _AddPeople_Command;
        public ICommand AddPeople_Command
        {
            get
            {
                return _AddPeople_Command ?? (_AddPeople_Command = new CommandHandler.CommandHandler(() => People++, () => CanAddPeople()));
            }
            set { _AddPeople_Command = value; }
        }

        public bool CanAddPeople()
        {
            return People < 5000;
        }
        #endregion

        #region CastleLvL
        //private int _CastleLvl;
        //public int CastleLvl
        //{
        //    get { return _CastleLvl; }
        //    set { _CastleLvl = value;
        //        OnPropertyChanged(nameof(CastleLvl));
        //    }
        //}

        //private ICommand _CastleLvlUp_Command;
        //public ICommand CastleLvlUp_Command
        //{
        //    get
        //    {
        //        return _CastleLvlUp_Command ?? (_CastleLvlUp_Command = new CommandHandler.CommandHandler(() => CastleLvl++, () => CanLvlUpCastle()));
        //    }
        //    set { _CastleLvlUp_Command = value; }
        //}

        //public bool CanLvlUpCastle()
        //{
        //    return CastleLvl < 10;
        //}
        #endregion


        #region Army

        private Army _Army;
        public Army Army
        {
            get { return _Army; }
            set { _Army = value;
                OnPropertyChanged(nameof(Army));
            }
        }

        #region AddRecruitCommand

        private int _RecruitersAmount;
        public int RecruitersAmount
        {
            get { return _RecruitersAmount; }
            set { _RecruitersAmount = value;
                OnPropertyChanged(nameof(RecruitersAmount));
            }
        }

        private ICommand _AddRecruit_Command;
        public ICommand AddRecruit_Command
        {
            get { return _AddRecruit_Command ?? (_AddRecruit_Command = new CommandHandler.CommandHandler(() => AddRecruiter(), () => CanAddRecruit())); }
            set { _AddRecruit_Command = value; }
        }
        private void AddRecruiter() { Coins -= 2; RecruitersAmount++; }
        public bool CanAddRecruit()
        {
            return Coins >= 2;
        }
        #endregion

        #region AddBowmanCommand

        private int _BowmansAmount;
        public int BowmansAmount
        {
            get { return _BowmansAmount; }
            set { _BowmansAmount = value;
                OnPropertyChanged(nameof(BowmansAmount));
            }
        }

        private ICommand _AddBowman_Command;
        public ICommand AddBowman_Command
        {
            get { return _AddBowman_Command ?? (_AddBowman_Command = new CommandHandler.CommandHandler(() => AddBowman(), () => CanAddBowman())); }
            set { _AddBowman_Command = value; }
        }
        private void AddBowman() { Coins -= 8; BowmansAmount++; }
        public bool CanAddBowman()
        {
            return Coins >= 8;
        }
        #endregion

        #region AddFootmanCommand

        private int _FootmansAmount;
        public int FootmansAmount
        {
            get { return _FootmansAmount; }
            set { _FootmansAmount = value;
                OnPropertyChanged(nameof(FootmansAmount));
            }
        }

        private ICommand _AddFootman_Command;
        public ICommand AddFootman_Command
        {
            get { return _AddFootman_Command ?? (_AddFootman_Command = new CommandHandler.CommandHandler(() => AddFootman(), () => CanAddFootman())); }
            set { _AddFootman_Command = value; }
        }
        private void AddFootman() { Coins -= 20; FootmansAmount++; }
        public bool CanAddFootman()
        {
            return Coins >= 20 && BarrakLvl >= 4;
        }
        #endregion

        #region AddHorsemanCommand

        private int _HorsemansAmount;
        public int HorsemansAmount
        {
            get { return _HorsemansAmount; }
            set { _HorsemansAmount = value;
                OnPropertyChanged(nameof(HorsemansAmount));
            }
        }

        private ICommand _AddHorseman_Command;
        public ICommand AddHorseman_Command
        {
            get { return _AddHorseman_Command ?? (_AddHorseman_Command = new CommandHandler.CommandHandler(() => AddHorseman(), () => CanAddHorseman())); }
            set { _AddHorseman_Command = value; }
        }

        private void AddHorseman() { Coins -= 20; HorsemansAmount++; }
        public bool CanAddHorseman()
        {
            return Coins >= 20 && BarrakLvl >= 7;
        }
        #endregion

        #endregion


        #region TownHall

        private TownHall _TownHall;
        public TownHall TownHall
        {
            get { return _TownHall; }
            set { _TownHall = value;
                OnPropertyChanged(nameof(TownHall));
            }
        }

        private byte _TownHallLvl;
        public byte TownHallLvl
        {
            get { return _TownHallLvl; }
            set { _TownHallLvl = value;
                OnPropertyChanged(nameof(TownHallLvl));
            }
        }

        private byte _TownHallTaxLvl;
        public byte TownHallTaxLvl
        {
            get { return _TownHallTaxLvl; }
            set { _TownHallTaxLvl = value;
                OnPropertyChanged(nameof(TownHallTaxLvl));
            }
        }

        private ICommand _TownHallLvlUp_Command;
        public ICommand TownHallLvlUp_Command
        {
            get { return _TownHallLvlUp_Command ?? (_TownHallLvlUp_Command = new CommandHandler.CommandHandler(() => TownHallLvlUp(), () => CanLvlUpTownHall())); }
            set { _TownHallLvlUp_Command = value; }
        }
        private void TownHallLvlUp() 
        {
            Coins -= TownHallLvl * 200;
            TownHallLvl++;
            TownHallTaxLvl += 2;
        }
        public bool CanLvlUpTownHall()
        {
            return TownHallLvl < 10 && Coins >= TownHallLvl * 200;
        }

        #endregion

        #region Wall

        private Wall _Wall;
        public Wall Wall
        {
            get { return _Wall; }
            set { _Wall = value;
                OnPropertyChanged(nameof(Wall));
            }
        }

        private byte _WallLvl;
        public byte WallLvl
        {
            get { return _WallLvl; }
            set { _WallLvl = value;
                OnPropertyChanged(nameof(WallLvl));
            }
        }

        private ICommand _WallLvlUp_Command;
        public ICommand WallLvlUp_Command
        {
            get { return _WallLvlUp_Command ?? (_WallLvlUp_Command = new CommandHandler.CommandHandler(() => WallLvlUp(), () => CanLvlUpWall())); }
            set { _WallLvlUp_Command = value; }
        }
        private void WallLvlUp() 
        {
            Coins -= WallLvl * 500;
            WallLvl++;
            Army.Difence += 1; // Дописать поля .
        }
        public bool CanLvlUpWall()
        {
            return WallLvl < 10 && Coins >= WallLvl * 500;
        }

        #endregion

        #region House // Не полная логика

        private House _House;
        public House House
        {
            get { return _House; }
            set { _House = value;
                OnPropertyChanged(nameof(House));
            }
        }

        private byte _HouseLvl;
        public byte HouseLvl
        {
            get { return _HouseLvl; }
            set { _HouseLvl = value;
                OnPropertyChanged(nameof(HouseLvl));
            }
        }

        private ICommand _HouseLvlUp_Command;
        public ICommand HouseLvlUp_Command
        {
            get { return _HouseLvlUp_Command ?? (_HouseLvlUp_Command = new CommandHandler.CommandHandler(() => HouseLvlUp(), () => CanLvlUpHouse())); }
            set { _HouseLvlUp_Command = value; }
        }
        private void HouseLvlUp() { Coins -= HouseLvl * 150; HouseLvl++; }
        public bool CanLvlUpHouse()
        {
            return HouseLvl < 25 && Coins >= HouseLvl * 150 && People <= 5000;
        }

        #endregion

        #region Barrak // Не полная логика 

        private Barrak _Barrak;
        public Barrak Barrak
        {
            get { return _Barrak; }
            set { _Barrak = value;
                OnPropertyChanged(nameof(Barrak));
            }
        }

        private byte _BarrakLvl;
        public byte BarrakLvl
        {
            get { return _BarrakLvl; }
            set { _BarrakLvl = value;
            OnPropertyChanged(nameof(BarrakLvl)); 
            }
        }

        private ICommand _BarrakLvlUp_Command;
        public ICommand BarrakLvlUp_Command
        {
            get { return _BarrakLvlUp_Command ?? (_BarrakLvlUp_Command = new CommandHandler.CommandHandler(() => BarrakLvlUp(), () => CanLvlUpBarrak())); }
            set { _BarrakLvlUp_Command = value; }
        }
        private void BarrakLvlUp() { Coins -= BarrakLvl * 300; BarrakLvl++; }
        public bool CanLvlUpBarrak()
        {
            return BarrakLvl < 10 && Coins >= BarrakLvl * 300;
        }

        #endregion

        #region Tample // Не полная логика

        private Tample _Tample;

        public Tample Tample
        {
            get { return _Tample; }
            set { _Tample = value;
                OnPropertyChanged(nameof(Tample));
            }
        }

        private byte _TampleLvl;
        public byte TampleLvl
        {
            get { return _TampleLvl; }
            set { _TampleLvl = value;
                OnPropertyChanged(nameof(TampleLvl));
            }
        }

        private ICommand _TampleLvlUp_Command;
        public ICommand TampleLvlUp_Command
        {
            get { return _TampleLvlUp_Command ?? (_TampleLvlUp_Command = new CommandHandler.CommandHandler(() => TampleLvlUp(), () => CanLvlUpTample())); }
            set { _TampleLvlUp_Command = value; }
        }
        private void TampleLvlUp() { Coins -= TampleLvl * 750; TampleLvl++; }
        public bool CanLvlUpTample()
        {
            return TampleLvl < 9 && Coins >= TampleLvl * 750;
        }

        #endregion



    }
}