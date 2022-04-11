using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Triangle : Shape
    {
        public Triangle(Point location, Size size, Brush brush)
            : base(location, size, brush)
        {

        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Brushes.Black), Rectangle);

            graphics.DrawLine(PenService.GetPen(Brush), Location.X, Location.Y + Size.Height, Location.X + Size.Width, Location.Y + Size.Height);
            graphics.DrawLine(PenService.GetPen(Brush), Location.X, Location.Y + Size.Height, Location.X + Size.Width / 2, Location.Y);
            graphics.DrawLine(PenService.GetPen(Brush), Location.X + Size.Width, Location.Y + Size.Height, Location.X + Size.Width / 2, Location.Y);
      
        }
    }
}
