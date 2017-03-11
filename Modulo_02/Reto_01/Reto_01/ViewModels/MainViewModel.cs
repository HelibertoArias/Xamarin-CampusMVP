using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_01.ViewModels
{
    public class MainViewModel 
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
            set { _food = value; }
        }

        public double FoodTax
        {
            get { return _foodTax; }
            set { _foodTax = value; }
        }

        public int TipPercent
        {
            get { return _tipPercent; }
            set { _tipPercent = value; }
        }

        public double TipAmount
        {
            get { return _tipAmount; }
            set { _tipAmount = value; }
        }

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        } 
        #endregion
        
        public MainViewModel()
        {
            Food = 0;
            FoodTax = 0;
            TipPercent = 10;
            TipAmount = 0;
            Total = 0;
        }



    }
}
