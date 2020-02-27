using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Restaurant
{
    class RestaurantStuff
    {
        public string Food;
        public string PropertyName;
        public int Tables;
        public string HeadChef;
        
        public void Welcome()
        {
            MessageBox.Show("Welcome to " + PropertyName + "!");
        }

        public void Cusine()
        {
            MessageBox.Show("We cook " + Food);
        }

        public void Seating()
        {
            MessageBox.Show("We have " + Tables + "tables.");
        }

        public void MainCook()
        {
            MessageBox.Show("Our head chef is " + HeadChef);
        }
    }
}
