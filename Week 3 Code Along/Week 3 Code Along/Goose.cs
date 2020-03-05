using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_code_along
{
    class Goose
    {
        public string Name;
        public int Age;
        public int AttackDamage;

        public void Honk()
        {
            MessageBox.Show("Quack! My name is " + Name);
            MessageBox.Show("I am " + Age + "goose years old.");
        }

        public void Attack()
        {
            MessageBox.Show("I deal " + AttackDamage + "damage. You're gonna die.");
        }
    }
}
