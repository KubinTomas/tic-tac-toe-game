using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Cross : Shape
    {
        public Cross(Point location, Size size, Brush brush)
            : base(location, size, brush)
        {

        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Brushes.Black), Rectangle);

            graphics.DrawLine(PenService.GetPen(Brush), Location.X, Location.Y, Location.X + Size.Width, Location.Y + Size.Height);
            graphics.DrawLine(PenService.GetPen(Brush), Location.X + Size.Width, Location.Y, Location.X, Location.Y + Size.Height);
        }
    }
}
