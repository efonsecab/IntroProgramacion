using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungryBoy
{
    public partial class Form1 : Form
    {
        private const int TOTAL_ROWS = 20;
        private const int TOTAL_COLUMNS = 28;
        private Entidades.Casilla[,] maze =
            new Entidades.Casilla[TOTAL_ROWS, TOTAL_COLUMNS];
        private const int H = 15;
        private const int W = 15;
        PictureBox player = null;
        private ArrowDirection MovementDirection = ArrowDirection.Left;
        public Form1()
        {
            InitializeComponent();
            CreateMaze();
        }

        private void CreatePlayer(int f, int c)
        {
            player = new PictureBox();
            player.Image = Properties.Resources.HungryBoy;
            player.Size =
                new Size(W, H);
            Point imageLocation = maze[f, c].Imagen.Location;
            player.Location = imageLocation;
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(player);
            player.BringToFront();
        }

        private void CreateMaze()
        {
            int posX = 0;
            int posY = 0;
            int posAtString = 0;
            string cleanLevelMap = 
                Properties.Resources.Level1.
                Replace("\r\n",string.Empty);
            for (int f = 0; f < TOTAL_ROWS; f++)
            {
                for (int c = 0; c < TOTAL_COLUMNS; c++)
                {
                    char charAtPos = cleanLevelMap[posAtString];
                    PictureBox p = new PictureBox();
                    p.Margin =
                        new Padding(0, 0, 0, 0);
                    //p.Margin =
                    //    new Padding(0,0,0,0);
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Size = new Size(W, H);
                    p.Location =
                        new Point(posX, posY);
                    posX += W;
                    this.Controls.Add(p);
                    maze[f, c] = new Entidades.Casilla(charAtPos, p);
                    switch (charAtPos)
                    {
                        case 'P':
                            CreatePlayer(f, c);
                            break;
                        case 'o':
                            p.Image = Properties.Resources.rosekane_12;
                            break;
                        case 'O':
                            p.Image = Properties.Resources.rosekane_13;
                            break;
                        case 'I': break;
                        case 'B': break;
                        case 'Z': break;
                        case 'W':
                            p.Image = Properties.Resources.RedBrickTile;
                            break;
                        default:
                            bool a = false;
                            break;
                    }
                    posAtString += 1;
                }
                posY += H;
                posX = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool activateTimer = false;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    MovementDirection = ArrowDirection.Left;
                    activateTimer = true;
                    break;
                case Keys.Right:
                    MovementDirection = ArrowDirection.Right;
                    activateTimer = true;
                    break;
                case Keys.Up:
                    MovementDirection = ArrowDirection.Up;
                    activateTimer = true;
                    break;
                case Keys.Down:
                    MovementDirection = ArrowDirection.Down;
                    activateTimer = true;
                    break;
            }
            if (activateTimer == true)
                tmrPlayerMovement.Enabled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            Point currentPlayerLocation = player.Location;
            int unitsToMove = W;
            switch (MovementDirection)
            {
                case ArrowDirection.Left:
                    currentPlayerLocation =
                        new Point(currentPlayerLocation.X - unitsToMove, currentPlayerLocation.Y);
                    break;
                case ArrowDirection.Right:
                    currentPlayerLocation =
                        new Point(currentPlayerLocation.X + unitsToMove, currentPlayerLocation.Y);
                    break;
                case ArrowDirection.Up:
                    currentPlayerLocation =
                        new Point(currentPlayerLocation.X, 
                        currentPlayerLocation.Y - unitsToMove);
                    break;
                case ArrowDirection.Down:
                    currentPlayerLocation =
                        new Point(currentPlayerLocation.X, currentPlayerLocation.Y + unitsToMove);
                    break;
            }
            bool allowMovement = false;
            for (int f = 0; f < TOTAL_ROWS; f++)
            {
                for (int c = 0; c < TOTAL_COLUMNS; c++)
                {
                    PictureBox picBoxinPos = maze[f, c].Imagen;
                    if (player.Location == picBoxinPos.Location)
                    {
                        switch (MovementDirection)
                        {
                            case ArrowDirection.Left:
                                if ((c - 1) != 0 &&
                                    maze[f,c-1].Char != 'W')
                                    allowMovement = true;
                                break;
                            case ArrowDirection.Right:
                                if ((c + 1) != TOTAL_COLUMNS
                                    && maze[f,c+1].Char != 'W')
                                    allowMovement = true;
                                break;
                            case ArrowDirection.Up:
                                if ((f - 1) > 0 &&
                                    maze[f-1,c].Char != 'W')
                                    allowMovement = true;
                                break;
                            case ArrowDirection.Down:
                                if ((f + 1) != TOTAL_ROWS &&
                                    maze[f+1,c].Char != 'W')
                                    allowMovement = true;
                                break;
                        }
                    }
                }
            }
            if (allowMovement)
                player.Location = currentPlayerLocation;
        }
    }
}
