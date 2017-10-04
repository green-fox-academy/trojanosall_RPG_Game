using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG
{
    class Skeleton
    {
        public static string Type;
        public static int HP;
        public static int SP;
        public static int DP;
        //public static int XCoordinate = 0;
        //public static int YCoordinate = 0;
        //public static int SideOfTile = 50;
        public static Random rnd = new Random();

        public static List<int> XCoordinateList = new List<int>{ 0, 150, 300 };
        public static List<int> YCoordinateList = new List<int>{ 150, 300 };
        

        public static void SetSkeleton(FoxDraw foxDraw)
        {
            int XRandomNumb = rnd.Next(XCoordinateList.Count);
            int YRandomNumb = rnd.Next(YCoordinateList.Count);
            int XCoordinate = XCoordinateList[XRandomNumb];
            int YCoordinate = YCoordinateList[YRandomNumb];
            foxDraw.AddImage("./asset/skeleton.png", XCoordinate, YCoordinate);
        }
        
    }
}