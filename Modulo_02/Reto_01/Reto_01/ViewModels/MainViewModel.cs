using Reto_01.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_01.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Attributes
        private double _food;

        private double _foodTax;

        private int _tipPercent;

        private double _tipAmount;

        private double _total;
        #endregion

        #region Properties

        public double Food
        {
            get { return _food; }
            set
            {
                _food = value;
                Recalculate();
                OnPropertyChanged();
            }
        }

        public double FoodTax
        {
            get { return _foodTax; }
            set
            {
                _foodTax = value;
                Recalculate();
                OnPropertyChanged();
            }
        }

        public int TipPercent
        {
            get { return _tipPercent; }
            set
            {
                _tipPercent = value;
                Recalculate();
                OnPropertyChanged();
            }
        }

        public double TipAmount
        {
            get { return _tipAmount; }
            set
            {
                _tipAmount = value;
                OnPropertyChanged();
            }
        }

        public double Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public MainViewModel()
        {
            Food = 0;
            FoodTax = 0;
            TipPercent = 0;
            TipAmount = 0;
            Total = 0;
        }

        public void Recalculate()
        {
            TipAmount = 0;
            Total = 0;

            if (Food > 0 && FoodTax > 0)
            {
                TipAmount = (Food * TipPercent) / 100;
                Total = TipAmount + FoodTax;
            }

        }



    }
}
