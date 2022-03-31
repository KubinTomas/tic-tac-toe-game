using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class GridService
    {
        public void DrawGrid(Graphics graphics, Shape[,] grid)
        {

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j].Draw(graphics);
                }
            }
        }
        public Shape[,] CreateGrid(Size canvasSize, Size shapeSize, Brush brush)
        {
            var grid = new Shape[
                (int)Math.Floor((decimal)(canvasSize.Width / shapeSize.Width)),
                (int)Math.Floor((decimal)(canvasSize.Height / shapeSize.Height))
                ];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    var location = new Point(i * shapeSize.Width, j * shapeSize.Height);

                    grid[i, j] = new EmptyField(location, shapeSize, brush);
                }
            }

            return grid;
        }

        public Shape[,] CreateGrid(Size canvasSize, Size shapeSize)
        {
            return CreateGrid(canvasSize, shapeSize, Brushes.Black);
        }
    }
}
