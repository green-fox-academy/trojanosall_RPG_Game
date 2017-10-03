using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    foxDraw.AddImage("./asset/wall.png", i * 50, j * 50);
                }
            }

            for (int k = 0; k < 10; k++)
            {
                for (int l = 1; l < 3; l++)
                {
                    foxDraw.AddImage("./asset/floor.png", k * 50, l * 150);
                }
            }

            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 11; n++)
                {
                    foxDraw.AddImage("./asset/floor.png", m * 150, n * 50);
                }
            }
        }
    }
}
