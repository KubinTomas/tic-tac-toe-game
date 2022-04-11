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
        public GamePanel()
        {
            InitializeComponent();

            this.Size = new Size(1000, 1000);
            this.StartPosition = FormStartPosition.CenterParent;
            this.pbCanvas.Size = this.ClientSize;
            this.pbCanvas.Location = new Point(0, 0);
            
            var shapeSize = new Size(50, 50);

            _gridService = new GridService();
            _map = _gridService.CreateGrid(this.pbCanvas.Size, shapeSize);

            this.pbCanvas.Refresh();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_map != null)
            {
                _gridService.DrawGrid(e.Graphics, _map);
            }
        }
    }
}
