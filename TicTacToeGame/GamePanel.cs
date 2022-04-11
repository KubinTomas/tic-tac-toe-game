using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class GamePanel : Form
    {
        private GridService _gridService;
        private Shape[,] _map;

        private int winCount = 5;

        private ShapeType shapeTurn = ShapeType.Cross;

        public GamePanel()
        {
            InitializeComponent();

            this.Size = new Size(1000, 1000);
            this.StartPosition = FormStartPosition.CenterParent;
            this.pbCanvas.Size = this.ClientSize;
            this.pbCanvas.Location = new Point(0, 0);

            _gridService = new GridService();
            _map = _gridService.CreateGrid(this.pbCanvas.Size, Shape.DefaultSize);

            this.pbCanvas.Refresh();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_map != null)
            {
                _gridService.DrawGrid(e.Graphics, _map);
            }
        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {
            var mouseArgs = (MouseEventArgs)e;
            // 40, 40 -> 0,0
            // 90, 25 -> 1,0
            // 90, 55 -> 1,1
            // 96/50 -> 1.92
            var i = mouseArgs.X / Shape.DefaultSize.Width;
            var j = mouseArgs.Y / Shape.DefaultSize.Height;

            var field = _map[i, j];

            if (!(field is EmptyField))
            {
                return;
            }

            Shape shape;

            if (shapeTurn == ShapeType.Cross)
            {
                shape = new Cross(field.Location, field.Size, Brushes.Red);
                shapeTurn = ShapeType.Circle;
            }
            else
            {
                shape = new Circle(field.Location, field.Size, Brushes.Blue);
                shapeTurn = ShapeType.Cross;
            }

            _map[i, j] = shape;

            this.pbCanvas.Refresh();

            //MessageBox.Show(string.Format("I: {0}, J: {1}", i, j));
        }

        private bool IsWinner(Point point, Shape playerShape)
        {
            var count = 0;
            for (int i = point.X - winCount; i < point.X + winCount; i++)
            {
                if (i >= 0 && i < _map.GetLength(0))
                {
                    var shape = _map[i, point.Y];
                    
                }
            }


            return false;
        }

    }
}
