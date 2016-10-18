using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ver https://msdn.microsoft.com/es-cr/library/dd30h2yb(v=vs.110).aspx
//Ver https://msdn.microsoft.com/en-us/library/system.windows.forms(v=vs.110).aspx
namespace IntroWinforms
{
    public partial class frmFormPrincipal : Form
    {
        public frmFormPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombreAMostrar = txtNombre.Text;
            DialogResult result = MessageBox.Show("¿Quiere mostrar el texto digitado?", "¿Continuar?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                MessageBox.Show("El nombre digitado es: " + nombreAMostrar, "Nombre digitado");
            else
                MessageBox.Show("Usted decidió no mostrar el nombre");
        }
    }
}
