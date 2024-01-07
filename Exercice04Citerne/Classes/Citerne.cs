using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice04Citerne.Classes
{
    internal class WaterTank
    {
        private int _fillLevel;
        private int _maxCapacity;
        private int _weightEmpty;

        public WaterTank()
        {

        }

        public WaterTank(int fillLevel, int maxCapacity, int weightEmpty) : this()
        {
            FillLevel = fillLevel;
            MaxCapacity = maxCapacity;
            WeightEmpty = weightEmpty;
        }

        public int FillLevel
        {
            get => _fillLevel;
            set
            {
                TotalFillLevels -= _fillLevel;
                _fillLevel = value;
                TotalFillLevels += _fillLevel;
            }
        }

        public int MaxCapacity { get => _maxCapacity; set => _maxCapacity = value; }

        public int WeightEmpty { get => _weightEmpty; set => _weightEmpty = value; }

        //public double Eau { get => _eau; set => _eau = value; }

        //public int Eau
        //{
        //    get => _eau;
        //    set
        //    {
        //        TotalFillLevels -= _eau;
        //        _eau = value;
        //        //TotalSalaires += value;
        //        TotalFillLevels += _eau;
        //    }
        //}
        //public int FillLevel { get => _fillLevel; set => _fillLevel = value; }
        public int TotalWeight { get => _weightEmpty + _fillLevel; }
        public static int TotalFillLevels { get; private set; } = 0;



        //public int TotalWeight()
        //{
        //    //Console.WriteLine($"Le poids total est de {_weightEmpty + _fillLevel} kg");
        //    //_poidsTotal = _poidsAVide + (_capacite * _niveauRemplissage);
        //    return 500;
        //}
        public int Fill(int amount)
        {
            if (amount <= 0)
                return 0;
            if (_fillLevel + amount > _maxCapacity)
            {
                int excessWater = _fillLevel + amount - _maxCapacity;
                FillLevel = _maxCapacity;
                return excessWater;
            }
            else
            {
                FillLevel += amount;
                return 0;
            }

        }
        public int Empty(int amount)
        {
            if (amount <= 0)
                return 0;
            if (_fillLevel - amount < 0)
            {
                int waterTaken = _fillLevel;
                FillLevel = 0;
                return waterTaken;
            }
            else
            {
                FillLevel -= amount;
                return amount;
            }

        }

        public void AffichageCiterne()
        {
            string[,] citerneAscii = {
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
            };
            int niveauCiterne = FillLevel == 1 ? 1 : (FillLevel * 8 / MaxCapacity);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(citerneAscii[niveauCiterne, i]);
            }
        }
    }
}
