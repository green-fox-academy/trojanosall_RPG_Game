using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GreenFox;

namespace RPG
{
    public class Area
    {
        public int RowNumber = 11;
        public int ColumbNumber = 10;
        public int SideOfTile = 50;

        public Area(int rowNumber, int columbNumber, int sideOfTile)
        {
            this.RowNumber = rowNumber;
            this.ColumbNumber = columbNumber;
            this.SideOfTile = sideOfTile;
        }

        public void DrawArea(FoxDraw foxDraw)
        {

            for (int i = 0; i < ColumbNumber; i++)
            {
                for (int j = 0; j < RowNumber; j++)
                {
                    foxDraw.AddImage("./asset/wall.png", i * SideOfTile, j * SideOfTile);
                }
            }

            for (int k = 0; k < ColumbNumber; k++)
            {
                for (int l = 1; l < 3; l++)
                {
                    foxDraw.AddImage("./asset/floor.png", k * SideOfTile, l * 3 * SideOfTile);
                }
            }

            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < RowNumber; n++)
                {
                    foxDraw.AddImage("./asset/floor.png", m * 3 * SideOfTile, n * SideOfTile);
                }
            }

        }

    }
}
