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
        private Hero hero;
        private Area area = new Area(11, 10, 50);

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            //Area area = new Area(11, 10, 50);

            area.DrawArea(foxDraw);

            Hero.SetHero(foxDraw);

        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            var foxDraw = new FoxDraw(canvas);
            area.DrawArea(foxDraw);

            if (e.Key == Key.Left)
            {
                Hero.MoveLeft(foxDraw);
            }

            if (e.Key == Key.Right)
            {
                Hero.MoveRight(foxDraw);
            }

            if (e.Key == Key.Up)
            {
                Hero.MoveUp(foxDraw);
            }

            if (e.Key == Key.Down)
            {
                Hero.MoveDown(foxDraw);
            }

        }

    }
}

