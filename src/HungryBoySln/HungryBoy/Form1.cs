using HungryBoy.Entidades;
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
        Player player = null;
        private ArrowDirection MovementDirection = ArrowDirection.Left;
        public int puntaje = 0;
        public Ghost RedGhost;
        public Form1()
        {
            InitializeComponent();
            CreateMaze();
            SetUIElements();
            tmrGhostMovement.Start();
        }

        private void SetUIElements()
        {
            this.lblScoreValue.Text =
                puntaje.ToString();
        }

        private void CreatePlayer(int f, int c)
        {
            player = new Player();
            player.Imagen = new PictureBox();
            player.Imagen.Image =
                Properties.Resources.HungryBoy;
            player.Imagen.Size = new Size(W, H);
            Point imageLocation =
                maze[f, c].Imagen.Location;
            player.FilaActual = f;
            player.ColumnaActual = c;
            player.Imagen.Location = imageLocation;
            player.Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(player.Imagen);
            player.Imagen.BringToFront();
        }

        private void CreateMaze()
        {
            int posX = 0;
            int posY = 0;
            int posAtString = 0;
            string cleanLevelMap =
                Properties.Resources.Level1.
                Replace("\r\n", string.Empty);
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
                        case 'R':
                            p.Image = Properties.Resources.rosekane_44;
                            maze[f, c].HasRedGhost = true;
                            RedGhost = new Ghost(f, c, p);
                            break;
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
            Point currentPlayerLocation =
                player.Imagen.Location;
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
                    if (player.Imagen.Location ==
                        picBoxinPos.Location)
                    {
                        switch (MovementDirection)
                        {
                            case ArrowDirection.Left:
                                if ((c - 1) != 0 &&
                                    maze[f, c - 1].Char != 'W')
                                {
                                    EvaluatePellet(f, c - 1);
                                    maze[f, c - 1].Char = 'P';
                                    player.FilaActual = f;
                                    player.ColumnaActual = c - 1;
                                    maze[f, c].Char = ' ';
                                    allowMovement = true;
                                }
                                break;
                            case ArrowDirection.Right:
                                if ((c + 1) != TOTAL_COLUMNS
                                    && maze[f, c + 1].Char != 'W')
                                {
                                    EvaluatePellet(f, c + 1);
                                    maze[f, c + 1].Char = 'P';
                                    player.FilaActual = f;
                                    player.ColumnaActual = c + 1;
                                    maze[f, c].Char = ' ';
                                    allowMovement = true;
                                }
                                break;
                            case ArrowDirection.Up:
                                if ((f - 1) > 0 &&
                                    maze[f - 1, c].Char != 'W')
                                {
                                    EvaluatePellet(f - 1, c);
                                    maze[f - 1, c].Char = 'P';
                                    player.FilaActual = f - 1;
                                    player.ColumnaActual = c;
                                    maze[f, c].Char = ' ';
                                    allowMovement = true;
                                }
                                break;
                            case ArrowDirection.Down:
                                if ((f + 1) != TOTAL_ROWS &&
                                    maze[f + 1, c].Char != 'W')
                                {
                                    EvaluatePellet(f + 1, c);
                                    maze[f + 1, c].Char = 'P';
                                    player.FilaActual = f + 1;
                                    player.ColumnaActual = c;
                                    maze[f, c].Char = ' ';
                                    allowMovement = true;
                                }
                                break;
                        }
                    }
                }
            }
            if (allowMovement)
                player.Imagen.Location = currentPlayerLocation;
        }

        private void EvaluatePellet(int f, int c)
        {
            switch (maze[f, c].Char)
            {
                case 'o':
                    puntaje = puntaje + 250;
                    maze[f, c].Imagen.Visible = false;
                    break;
                case 'O':
                    puntaje = puntaje + 500;
                    maze[f, c].Imagen.Visible = false;
                    break;
            }
            SetUIElements();
        }

        private void tmrGhostMovement_Tick(object sender, EventArgs e)
        {
            List<ArrowDirection> lstAvailableMovements
                = new List<ArrowDirection>();
            if (maze[RedGhost.FilaActual - 1,
                RedGhost.ColumnActual].Char != 'W')
            {
                lstAvailableMovements.Add(ArrowDirection.Up);
            }
            if (maze[RedGhost.FilaActual + 1,
                RedGhost.ColumnActual].Char != 'W')
            {
                lstAvailableMovements.Add(ArrowDirection.Down);
            }
            if (maze[RedGhost.FilaActual,
                RedGhost.ColumnActual - 1].Char != 'W')
            {
                lstAvailableMovements.Add(ArrowDirection.Left);
            }
            if (maze[RedGhost.FilaActual,
    RedGhost.ColumnActual + 1].Char != 'W')
            {
                lstAvailableMovements.Add(ArrowDirection.Right);
            }
            switch (RedGhost.MovementDiretion)
            {
                case ArrowDirection.Up:
                    if (maze[RedGhost.FilaActual-1, RedGhost.ColumnActual].Imagen.Location.Y !=
                        RedGhost.Imagen.Location.Y)
                    {
                        RedGhost.Imagen.Location
                            = new Point(RedGhost.Imagen.Location.X, RedGhost.Imagen.Location.Y - W);
                        RedGhost.Imagen.BringToFront();
                    }
                    if (maze[RedGhost.FilaActual - 1, RedGhost.ColumnActual].Imagen.Location.Y ==
    RedGhost.Imagen.Location.Y)
                    {
                        RedGhost.FilaActual -= 1;
                    }
                    break;
                case ArrowDirection.Down:
                    break;
                case ArrowDirection.Left:
                    break;
                case ArrowDirection.Right:
                    break;
            }
        }
    }
}
