using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosePrinciple.FalseExample
{
    public enum MenuType
    {
        Hamburger, Cheeseburger, DoubleBurger
    }

    public class BadMenu
    {
    public double GetTotalPrice(double amount, MenuType menuType)
        {
        double totalPrice = 0;

        if (menuType == MenuType.Hamburger)
        {
            totalPrice += amount * 18.50;
        }
        else if (menuType == MenuType.Cheeseburger)
        {
            totalPrice += amount * 21.50;
        }
        else if (menuType == MenuType.DoubleBurger)
        {
            totalPrice += amount * 27.75;
        }

        return totalPrice;
        }
    }
}
