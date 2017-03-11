using Reto_01.ViewModels.Base;

namespace Reto_01.Models
{
    public class TipCalModel : ViewModelBase
    {
        #region Attributes

        private double _food;

        private double _foodTax;

        private int _tipPercent;

        private double _tipAmount;

        private double _total;

        #endregion Attributes

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

        #endregion Properties

        public TipCalModel()
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