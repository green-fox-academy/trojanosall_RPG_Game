using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG
{
    class Hero
    {
        public static string Type;
        public static int HP;
        public static int SP;
        public static int DP;
        public static int XCoordinate = 0;
        public static int YCoordinate = 0;
        public static int SideOfTile = 50;


        public static void SetHero(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./asset/hero-down.png", XCoordinate, YCoordinate);
        }

        public static void MoveRight(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./asset/hero-right.png", XCoordinate + SideOfTile, YCoordinate);
            XCoordinate += SideOfTile;
        }

        public static void MoveLeft(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./asset/hero-left.png", XCoordinate - SideOfTile, YCoordinate);
            XCoordinate -= SideOfTile;
        }

        public static void MoveDown(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./asset/hero-down.png", XCoordinate, YCoordinate + 50);
            YCoordinate += SideOfTile;
        }

        public static void MoveUp(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./asset/hero-up.png", XCoordinate, YCoordinate - 50);
            YCoordinate -= SideOfTile;
        }
    }
}
