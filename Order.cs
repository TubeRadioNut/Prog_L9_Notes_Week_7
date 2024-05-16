using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_L9_Notes_Week_7
{
    internal class Order
    {
        //Fields
        string _orderName;
        bool _isOverNight;
        bool _isPerishable;

        //Constructor
        public Order(string orderName, bool isOverNight, bool isPerishable)
        {
            _orderName = orderName;
            _isOverNight = isOverNight;
            _isPerishable = isPerishable;
        }

        //Properties
        public string OrderName { get => _orderName; set => _orderName = value; }
        public bool IsOverNight { get => _isOverNight; set => _isOverNight = value; }
        public bool IsPerishable { get => _isPerishable; set => _isPerishable = value; }

        //Methods

        public override string ToString()
        {
            string formattedString = "";
            formattedString += $"Name: {_orderName}\n";
            formattedString += $"Overnight Delivery: {_isOverNight}\n";
            formattedString += $"Perishable: {IsPerishable}";
            return formattedString;
        }
        
    }//end of class

}//end of namespace
