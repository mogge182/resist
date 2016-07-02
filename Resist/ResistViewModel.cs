using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Resist.Annotations;
using Resist.Enums;
using Resist.Models;

namespace Resist
{
    internal class ResistViewModel : INotifyPropertyChanged


    {
        private int _manySpined;
        private int _manyHorned;
        private int _manyBarbed;
        private int _totalPhys;
        private int _totalFire;
        private int _totalCold;
        private int _totalPoison;
        private int _totalEnergy;
        private int _armorPhys;
        private int _armorFire;
        private int _armorCold;
        private int _armorPoison;
        private int _armorEnergy;
        private int _neededPhys = 70;
        private int _neededFire = 70;
        private int _neededCold = 70;
        private int _neededPoison = 70;
        private int _neededEnergy = 70;


        public ResistViewModel()
        {

        }

        public int ManySpined
        {
            get { return _manySpined; }
            set
            {
                _manySpined = value;
                CalculateResist();
            }
        }

        public int ManyHorned
        {
            get { return _manyHorned; }
            set
            {
                _manyHorned = value;
                CalculateResist();
            }
        }

        public int ManyBarbed
        {
            get { return _manyBarbed; }
            set
            {
                _manyBarbed = value;
                CalculateResist();
            }
        }

        public int TotalPhys
        {
            get { return _totalPhys; }
            set
            {
                _totalPhys = value;
                OnPropertyChanged();
            }
        }

        public int TotalFire
        {
            get { return _totalFire; }
            set
            {
                _totalFire = value;
                OnPropertyChanged();
            }
        }

        public int TotalCold
        {
            get { return _totalCold; }
            set
            {
                _totalCold = value;
                OnPropertyChanged();
            }
        }

        public int TotalPoison
        {
            get { return _totalPoison; }
            set
            {
                _totalPoison = value;
                OnPropertyChanged();
            }
        }

        public int TotalEnergy
        {
            get { return _totalEnergy; }
            set
            {
                _totalEnergy = value;
                OnPropertyChanged();
            }
        }

        public int ArmorPhys
        {
            get { return _armorPhys; }
            set
            {
                _armorPhys = value;
                CalculateResist();
            }
        }

        public int ArmorFire
        {
            get { return _armorFire; }
            set
            {
                _armorFire = value;
                CalculateResist();
            }
        }

        public int ArmorCold
        {
            get { return _armorCold; }
            set
            {
                _armorCold = value;
                CalculateResist();
            }
        }

        public int ArmorPoison
        {
            get { return _armorPoison; }
            set
            {
                _armorPoison = value;
                CalculateResist();
            }
        }

        public int ArmorEnergy
        {
            get { return _armorEnergy; }
            set
            {
                _armorEnergy = value;
                CalculateResist();
            }
        }

        public int NeededPhys
        {
            get { return _neededPhys; }
            set
            {
                _neededPhys = value;
                OnPropertyChanged();
            }
        }

        public int NeededFire
        {
            get { return _neededFire; }
            set
            {
                _neededFire = value;
                OnPropertyChanged();

            }
        }

        public int NeededCold
        {
            get { return _neededCold; }
            set
            {
                _neededCold = value;
                OnPropertyChanged();

            }
        }

        public int NeededPoison
        {
            get { return _neededPoison; }
            set
            {
                _neededPoison = value;
                OnPropertyChanged();

            }
        }

        public int NeededEnergy
        {
            get { return _neededEnergy; }
            set
            {
                _neededEnergy = value;
                OnPropertyChanged();
            }
        }

        public void CalculateResist()
        {
            var resist = new Resists();

            resist.Physical = (int) Spined.Physical*ManySpined + (int) Horned.Physical*ManyHorned +
                              (int) Barbed.Physical*ManyBarbed + ArmorPhys;
            resist.Fire = (int) Horned.Fire*ManyHorned + (int) Barbed.Fire*ManyBarbed+ArmorFire;
            resist.Cold = (int) Horned.Cold*ManyHorned + (int) Barbed.Cold*ManyBarbed + ArmorCold;
            resist.Poison = (int) Horned.Poison*ManyHorned + (int) Barbed.Poison*ManyBarbed + ArmorPoison;
            resist.Energy = (int) Horned.Energy*ManyHorned + (int) Barbed.Energy*ManyBarbed + ArmorEnergy;


            TotalPhys = resist.Physical;
            TotalFire = resist.Fire;
            TotalCold = resist.Cold;
            TotalPoison = resist.Poison;
            TotalEnergy = resist.Energy;

            NeededPhys = 70 - TotalPhys;
            NeededFire = 70 - TotalFire;
            NeededCold = 70 - TotalCold;
            NeededPoison = 70 - TotalPoison;
            NeededEnergy = 70 - TotalEnergy;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
