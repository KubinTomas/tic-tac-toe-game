using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class PenService
    {
        public static Pen GetPen(Brush color, int width = 2)
        {
            return new Pen(color, width);
        }
    }
}
