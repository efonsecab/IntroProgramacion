using IntroRPG.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroRPG.WindowsForms
{
    public partial class Form1 : Form
    {
        private IntroRPG.Shared.GameController objGC;
        private StringBuilder strLog = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            this.objGC = new Shared.GameController(100, 5);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            objGC.StartGame();
            SetTurnoActualUI();
            this.grpAtaques.Enabled = true;
            SetJugadorUI();
            SetStatsEnemigosUI();
            this.btnStart.Enabled = false;
        }

        private void SetJugadorUI()
        {
            this.txtHPJugador.Text = objGC.GetPlayerHP().ToString();
        }

        private void SetStatsEnemigosUI()
        {
            this.txtCantidadEnemigos.Text = objGC.GetCantidadEnemigos().ToString();
            this.txtHPEnemigo.Text = objGC.GetEnemyHP().ToString();
        }

        private void SetTurnoActualUI()
        {
            switch (this.objGC.TurnoActual)
            {
                case Shared.Turno.Jugador:
                    this.rdbTurnoJugador.Checked = true;
                    break;
                case Shared.Turno.Enemigo:
                    this.rdbTurnoEnemigo.Checked = true;
                    break;
            }
        }

        public void btnAtaque_Click(object sender, EventArgs e)
        {
            Button btnSender = sender as Button;
            Ataque objAtaque = null;
            int damage = 0;
            bool nuevoEnemigo = false;
            Nullable<TipoElemento> tipoDeElemento = null;
            if (btnSender == this.btnRayo)
                objAtaque = objGC.AtacarEnemigo(TipoElemento.Rayo, out damage, out nuevoEnemigo);
            if (btnSender == this.btnFuego)
                objAtaque = objGC.AtacarEnemigo(TipoElemento.Fuego, out damage, out nuevoEnemigo);
            if (btnSender == this.btnTierra)
                objAtaque = objGC.AtacarEnemigo(TipoElemento.Tierra, out damage, out nuevoEnemigo);
            if (btnSender == this.btnHielo)
                objAtaque = objGC.AtacarEnemigo(TipoElemento.Hielo, out damage, out nuevoEnemigo);
            if (btnSender == this.btnAgua)
                objAtaque = objGC.AtacarEnemigo(TipoElemento.Agua, out damage, out nuevoEnemigo);
            if (btnSender == this.btnViento)
                objAtaque = objGC.AtacarEnemigo(TipoElemento.Viento, out damage, out nuevoEnemigo);
            EscribirEnLog(string.Format("Ha atacado con {0}. Su enemigo pierde {1}HP", objAtaque.Tipo.ToString(), damage));
            if (nuevoEnemigo)
                EscribirEnLog("Ha encontrado un nuevo enemigo");
            this.grpAtaques.Enabled = false;
            SetStatsEnemigosUI();
            ValidarGameplayStatus();
            objGC.TurnoActual = Turno.Enemigo;
            SetTurnoActualUI();
            this.btnAtaqueEnemigo.Enabled = true;
            ValidarGameplayStatus();
        }

        private void ValidarGameplayStatus()
        {
            bool stopSession = false;
            switch (objGC.CurrentGameplayStatus)
            {
                case GameSessionStatus.PlayerWin:
                    EscribirEnLog("Felicidades! Ha ganado el juego");
                    stopSession = true;
                    break;
                case GameSessionStatus.GameOver:
                    EscribirEnLog("Lo sentimos. Ha sufrido una derrota");
                    stopSession = true;
                    break;
            }
            if (stopSession)
            {
                this.grpAtaques.Enabled = false;
            }
        }

        private void EscribirEnLog(string lineToAdd)
        {
            strLog.AppendLine(lineToAdd);
            this.txtLog.Text = strLog.ToString();
            this.txtLog.SelectionStart = this.txtLog.Text.Length;
            this.txtLog.ScrollToCaret();
        }

        private void ProcesarAtaqueEnemigo()
        {
            int damage = 0;
            Ataque objAtaque = objGC.AtacarJugador(out damage);
            EscribirEnLog(string.Format("Ha sido atacado con {0}. Pierde {1}HP", objAtaque.Tipo.ToString(), damage));
            objGC.TurnoActual = Turno.Jugador;
        }

        private void btnAtaqueEnemigo_Click(object sender, EventArgs e)
        {
            ProcesarAtaqueEnemigo();
            objGC.TurnoActual = Turno.Jugador;
            SetTurnoActualUI();
            this.grpAtaques.Enabled = true;
            SetJugadorUI();
            ValidarGameplayStatus();
            this.btnAtaqueEnemigo.Enabled = false;
        }
    }
}
