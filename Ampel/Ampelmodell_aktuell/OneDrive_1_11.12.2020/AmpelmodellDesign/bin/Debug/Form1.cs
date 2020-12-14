using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmpelmodellDesign
{
    public partial class Form1 : Form
    {
        private Car car;
        public Form1()
        {
            InitializeComponent();
            car = new Car();
        }

        public void RotSetzen()
        {
            redLamp.BackColor = Color.Red;
        }


        private void programmStarten_Click(object sender, EventArgs e)
        {
            greenLamp.BackColor = Color.Green;
            redWalker.BackColor = Color.Red;
        }

        private void lblPress_Click(object sender, EventArgs e)
        {
            int i = 0;
            Car.Color color = Car.Color.red;
            Car.ColorWalker colorWalker= Car.ColorWalker.green;
            do
            {
                
                switch (color)
                {
                    case Car.Color.red:
                        Task.Delay(2000).Wait();
                        redLamp.BackColor = Color.Red;
                        greenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.White;

                        greenWalker.BackColor = Color.Green;
                        redWalker.BackColor = Color.White;
                        i++;
                        break;

                    case Car.Color.redYellow:
                        Task.Delay(2000).Wait();
                        redLamp.BackColor = Color.Red;
                        greenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.Yellow;

                        greenWalker.BackColor = Color.White;
                        redWalker.BackColor = Color.Red;
                        i++;
                        break;
                    case Car.Color.green:
                        Task.Delay(2000).Wait();
                        redLamp.BackColor = Color.White;
                        greenLamp.BackColor = Color.Green;
                        yellowLamp.BackColor = Color.White;

                        greenWalker.BackColor = Color.White;
                        redWalker.BackColor = Color.Red;
                        i++;
                        break;
                    case Car.Color.yellow:
                        Task.Delay(2000).Wait();
                        redLamp.BackColor = Color.White;
                        greenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.Yellow;

                        greenWalker.BackColor = Color.White;
                        redWalker.BackColor = Color.Red;
                        i++;
                        break;
                }
                color = car.SwitchCar(color);
                colorWalker = car.SwitchWalker(colorWalker);


            } while (i < 8);

            //redLamp.BackColor = Color.Red;
            //greenWalker.BackColor = Color.Green;
        }

        //Reset Button
        private void button1_Click(object sender, EventArgs e)
        {
            redLamp.BackColor = Color.White;
            greenLamp.BackColor = Color.White;
            yellowLamp.BackColor = Color.White;
            greenWalker.BackColor = Color.White;
            redWalker.BackColor = Color.White;
        }

        /*//Ampelauto Farben
            if (zustand == "rot")
            {
                redLamp.BackColor = Color.Red;
            }

            if (zustand == "gelb")
            {
                yellowLamp.BackColor = Color.Yellow;
            }

            if (zustand == "rotgelb")
            {
                yellowLamp.BackColor = Color.Yellow;
                redLamp.BackColor = Color.Red;
            }

            if (zustand == "gruen")
            {
                gruenLamp.BackColor = Color.Green;
            }

            //Ampelfussgaenger Farben
            if (zustandFußgaenger == "rot")
            {
                rotFußgaenger.BackColor = Color.Red;
            }

            if (zustandFußgaenger == "gruen")
            {
                gruenFussgaenger.BackColor = Color.Green;
            }*/

        /*

        case Car.Color.red:
                        Task.Delay(5000).Wait();
        redLamp.BackColor = Color.Red;
                        greenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.Yellow;

                        greenWalker.BackColor = Color.White;
                        redWalker.BackColor = Color.White;
                        break;
                        
                    case Car.Color.redYellow:
                        Task.Delay(5000).Wait();
        redLamp.BackColor = Color.Red;
                        greenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.Yellow;

                        greenWalker.BackColor = Color.White;
                        redWalker.BackColor = Color.Red;
                        break;
                    case Car.Color.green:
                        Task.Delay(5000).Wait();
        redLamp.BackColor = Color.White;
                        greenLamp.BackColor = Color.Green;
                        yellowLamp.BackColor = Color.White;

                        greenWalker.BackColor = Color.White;
                        redWalker.BackColor = Color.Red;
                        break;
                    case Car.Color.yellow:
                        Task.Delay(5000).Wait();
        redLamp.BackColor = Color.White;
                        greenLamp.BackColor = Color.White;
                        yellowLamp.BackColor = Color.Yellow;

                        greenWalker.BackColor = Color.White;
                        redWalker.BackColor = Color.Red;

                        break;*/


        private void gruenLamp_TextChanged(object sender, EventArgs e)
        {
        }

        private void yellowLamp_TextChanged(object sender, EventArgs e)
        {
        }

        private void redLamp_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }

}

