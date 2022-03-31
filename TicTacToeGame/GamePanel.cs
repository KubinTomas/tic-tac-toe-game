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
        public GamePanel()
        {
            InitializeComponent();

            this.Size = new Size(1000, 1000); 
            this.StartPosition = FormStartPosition.CenterParent;
            this.pbCanvas.Size = this.ClientSize; 
            this.Location = new Point(0, 0); 
            var shapeSize = new Size(50, 50); 

            var gridService = new GridService(); 
            var grid = gridService.CreateGrid(this.pbCanvas.Size, shapeSize);

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
