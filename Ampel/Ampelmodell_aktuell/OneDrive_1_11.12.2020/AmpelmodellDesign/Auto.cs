using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpelmodellDesign
{
    public class Car
    {
        public enum Color { red = 0, redYellow, yellow, green };
        public enum ColorWalker { red = 0, green = 1 };
        public Car()
        {
        }

        public Color SwitchCar(Color currentColor)
        {
            switch (currentColor)
            {
                case Color.red:
                    currentColor = Color.redYellow;
                    break;
                case Color.redYellow:
                    currentColor = Color.green;
                    break;
                case Color.green:
                    currentColor = Color.yellow;
                    break;
                case Color.yellow:
                    currentColor = Color.red;
                    break;
                
            }
            return currentColor;
        }

        public ColorWalker SwitchWalker(ColorWalker currentColor)
        {

            switch (currentColor)
            {
                case ColorWalker.red:
                    currentColor = ColorWalker.green;
                    break;
                case ColorWalker.green:
                    currentColor = ColorWalker.red;
                    break;
            }
            return currentColor;
        }

        //CODE vorheriges Programm



    }
}