using Reservaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaTiquetes
{
    public partial class frmReservacion : Form
    {
        public frmReservacion()
        {
            InitializeComponent();
        }

        List<Butaca> lstButacas =
            new List<Butaca>();
        private void frmReservacion_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<char, int>>
                lstMapeoLetras = 
                new List<KeyValuePair<char, int>>();
            int filas = 5;int columnas = 10;int buttonWidth = 40;
            int buttonHeight = 40;int x = 0;int y = 0;
            int offset = 5;
            char letraInicial = 'A';
            int iLetraInicial = (int)letraInicial;
            int iLetraFinal = iLetraInicial + filas-1;
            int iPos = 0;
            for (int i=iLetraInicial; i <= iLetraFinal; i++)
            {
                int posActual = iLetraFinal - i;
                char charActual = (Char)i;
                KeyValuePair<char, int> mapeoLetraActual =
                    new KeyValuePair<char, int>(charActual, iPos);
                iPos++;
                lstMapeoLetras.Add(mapeoLetraActual);
            }
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Button btnButaca = new Button();
                    btnButaca.Size =
                        new Size(buttonWidth, buttonHeight);
                    btnButaca.Location =
                        new Point(x, y);
                    btnButaca.BackColor = Color.Green;
                    btnButaca.Click += BtnButaca_Click;
                    x = x + buttonWidth + offset;
                    char letraFila = lstMapeoLetras[f].Key;
                    btnButaca.Text = letraFila + "-" + (c + 1);
                    btnButaca.Name = "btn_" + btnButaca.Text;
                    Butaca objButaca = 
                        new Butaca(btnButaca.Text);
                    lstButacas.Add(objButaca);

                    this.Controls.Add(btnButaca);
                }
                x = 0; y = y + buttonHeight + offset;
            }
        }

        private void BtnButaca_Click(object sender, EventArgs e)
        {
            Button btnSender = sender as Button;
            if (btnSender != null)
            {
                string posicionButaca = btnSender.Text;
                var butaca = 
                lstButacas.Where(p => 
                p.Posicion == posicionButaca).FirstOrDefault();
                butaca.Reservada = true;
                btnSender.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("El desarrollador metio la pata");
            }
        }
    }
}
