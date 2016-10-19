namespace IntroRPG.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpTurno = new System.Windows.Forms.GroupBox();
            this.rdbTurnoJugador = new System.Windows.Forms.RadioButton();
            this.rdbTurnoEnemigo = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpAtaques = new System.Windows.Forms.GroupBox();
            this.btnRayo = new System.Windows.Forms.Button();
            this.btnFuego = new System.Windows.Forms.Button();
            this.btnTierra = new System.Windows.Forms.Button();
            this.btnHielo = new System.Windows.Forms.Button();
            this.btnAgua = new System.Windows.Forms.Button();
            this.btnViento = new System.Windows.Forms.Button();
            this.grpStatusJugador = new System.Windows.Forms.GroupBox();
            this.lblHPJugador = new System.Windows.Forms.Label();
            this.txtHPJugador = new System.Windows.Forms.TextBox();
            this.grpStatsEnemigos = new System.Windows.Forms.GroupBox();
            this.lblCantidadEnemigos = new System.Windows.Forms.Label();
            this.txtCantidadEnemigos = new System.Windows.Forms.TextBox();
            this.lblHPEnemigo = new System.Windows.Forms.Label();
            this.txtHPEnemigo = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnAtaqueEnemigo = new System.Windows.Forms.Button();
            this.grpTurno.SuspendLayout();
            this.grpAtaques.SuspendLayout();
            this.grpStatusJugador.SuspendLayout();
            this.grpStatsEnemigos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTurno
            // 
            this.grpTurno.Controls.Add(this.rdbTurnoEnemigo);
            this.grpTurno.Controls.Add(this.rdbTurnoJugador);
            this.grpTurno.Enabled = false;
            this.grpTurno.Location = new System.Drawing.Point(12, 12);
            this.grpTurno.Name = "grpTurno";
            this.grpTurno.Size = new System.Drawing.Size(200, 100);
            this.grpTurno.TabIndex = 0;
            this.grpTurno.TabStop = false;
            this.grpTurno.Text = "Turno Actual";
            // 
            // rdbTurnoJugador
            // 
            this.rdbTurnoJugador.AutoSize = true;
            this.rdbTurnoJugador.Location = new System.Drawing.Point(7, 20);
            this.rdbTurnoJugador.Name = "rdbTurnoJugador";
            this.rdbTurnoJugador.Size = new System.Drawing.Size(63, 17);
            this.rdbTurnoJugador.TabIndex = 0;
            this.rdbTurnoJugador.TabStop = true;
            this.rdbTurnoJugador.Text = "Jugador";
            this.rdbTurnoJugador.UseVisualStyleBackColor = true;
            // 
            // rdbTurnoEnemigo
            // 
            this.rdbTurnoEnemigo.AutoSize = true;
            this.rdbTurnoEnemigo.Location = new System.Drawing.Point(7, 44);
            this.rdbTurnoEnemigo.Name = "rdbTurnoEnemigo";
            this.rdbTurnoEnemigo.Size = new System.Drawing.Size(66, 17);
            this.rdbTurnoEnemigo.TabIndex = 1;
            this.rdbTurnoEnemigo.TabStop = true;
            this.rdbTurnoEnemigo.Text = "Enemigo";
            this.rdbTurnoEnemigo.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(239, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 100);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpAtaques
            // 
            this.grpAtaques.Controls.Add(this.btnViento);
            this.grpAtaques.Controls.Add(this.btnAgua);
            this.grpAtaques.Controls.Add(this.btnHielo);
            this.grpAtaques.Controls.Add(this.btnTierra);
            this.grpAtaques.Controls.Add(this.btnFuego);
            this.grpAtaques.Controls.Add(this.btnRayo);
            this.grpAtaques.Enabled = false;
            this.grpAtaques.Location = new System.Drawing.Point(12, 118);
            this.grpAtaques.Name = "grpAtaques";
            this.grpAtaques.Size = new System.Drawing.Size(185, 115);
            this.grpAtaques.TabIndex = 2;
            this.grpAtaques.TabStop = false;
            this.grpAtaques.Text = "Ataques";
            // 
            // btnRayo
            // 
            this.btnRayo.Location = new System.Drawing.Point(7, 19);
            this.btnRayo.Name = "btnRayo";
            this.btnRayo.Size = new System.Drawing.Size(75, 23);
            this.btnRayo.TabIndex = 0;
            this.btnRayo.Text = "Rayo";
            this.btnRayo.UseVisualStyleBackColor = true;
            this.btnRayo.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // btnFuego
            // 
            this.btnFuego.Location = new System.Drawing.Point(100, 19);
            this.btnFuego.Name = "btnFuego";
            this.btnFuego.Size = new System.Drawing.Size(75, 23);
            this.btnFuego.TabIndex = 1;
            this.btnFuego.Text = "Fuego";
            this.btnFuego.UseVisualStyleBackColor = true;
            this.btnFuego.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // btnTierra
            // 
            this.btnTierra.Location = new System.Drawing.Point(7, 48);
            this.btnTierra.Name = "btnTierra";
            this.btnTierra.Size = new System.Drawing.Size(75, 23);
            this.btnTierra.TabIndex = 3;
            this.btnTierra.Text = "Tierra";
            this.btnTierra.UseVisualStyleBackColor = true;
            this.btnTierra.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // btnHielo
            // 
            this.btnHielo.Location = new System.Drawing.Point(100, 48);
            this.btnHielo.Name = "btnHielo";
            this.btnHielo.Size = new System.Drawing.Size(75, 23);
            this.btnHielo.TabIndex = 3;
            this.btnHielo.Text = "Hielo";
            this.btnHielo.UseVisualStyleBackColor = true;
            this.btnHielo.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // btnAgua
            // 
            this.btnAgua.Location = new System.Drawing.Point(7, 77);
            this.btnAgua.Name = "btnAgua";
            this.btnAgua.Size = new System.Drawing.Size(75, 23);
            this.btnAgua.TabIndex = 3;
            this.btnAgua.Text = "Agua";
            this.btnAgua.UseVisualStyleBackColor = true;
            this.btnAgua.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // btnViento
            // 
            this.btnViento.Location = new System.Drawing.Point(100, 77);
            this.btnViento.Name = "btnViento";
            this.btnViento.Size = new System.Drawing.Size(75, 23);
            this.btnViento.TabIndex = 4;
            this.btnViento.Text = "Viento";
            this.btnViento.UseVisualStyleBackColor = true;
            this.btnViento.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // grpStatusJugador
            // 
            this.grpStatusJugador.Controls.Add(this.txtHPJugador);
            this.grpStatusJugador.Controls.Add(this.lblHPJugador);
            this.grpStatusJugador.Location = new System.Drawing.Point(381, 12);
            this.grpStatusJugador.Name = "grpStatusJugador";
            this.grpStatusJugador.Size = new System.Drawing.Size(126, 100);
            this.grpStatusJugador.TabIndex = 3;
            this.grpStatusJugador.TabStop = false;
            this.grpStatusJugador.Text = "Stats Jugador";
            // 
            // lblHPJugador
            // 
            this.lblHPJugador.AutoSize = true;
            this.lblHPJugador.Location = new System.Drawing.Point(7, 20);
            this.lblHPJugador.Name = "lblHPJugador";
            this.lblHPJugador.Size = new System.Drawing.Size(22, 13);
            this.lblHPJugador.TabIndex = 0;
            this.lblHPJugador.Text = "HP";
            // 
            // txtHPJugador
            // 
            this.txtHPJugador.Location = new System.Drawing.Point(36, 12);
            this.txtHPJugador.Name = "txtHPJugador";
            this.txtHPJugador.ReadOnly = true;
            this.txtHPJugador.Size = new System.Drawing.Size(84, 20);
            this.txtHPJugador.TabIndex = 1;
            // 
            // grpStatsEnemigos
            // 
            this.grpStatsEnemigos.Controls.Add(this.txtHPEnemigo);
            this.grpStatsEnemigos.Controls.Add(this.lblHPEnemigo);
            this.grpStatsEnemigos.Controls.Add(this.txtCantidadEnemigos);
            this.grpStatsEnemigos.Controls.Add(this.lblCantidadEnemigos);
            this.grpStatsEnemigos.Location = new System.Drawing.Point(530, 12);
            this.grpStatsEnemigos.Name = "grpStatsEnemigos";
            this.grpStatsEnemigos.Size = new System.Drawing.Size(200, 100);
            this.grpStatsEnemigos.TabIndex = 4;
            this.grpStatsEnemigos.TabStop = false;
            this.grpStatsEnemigos.Text = "Stats Enemigos";
            // 
            // lblCantidadEnemigos
            // 
            this.lblCantidadEnemigos.AutoSize = true;
            this.lblCantidadEnemigos.Location = new System.Drawing.Point(7, 16);
            this.lblCantidadEnemigos.Name = "lblCantidadEnemigos";
            this.lblCantidadEnemigos.Size = new System.Drawing.Size(53, 13);
            this.lblCantidadEnemigos.TabIndex = 0;
            this.lblCantidadEnemigos.Text = "Enemigos";
            // 
            // txtCantidadEnemigos
            // 
            this.txtCantidadEnemigos.Location = new System.Drawing.Point(66, 16);
            this.txtCantidadEnemigos.Name = "txtCantidadEnemigos";
            this.txtCantidadEnemigos.ReadOnly = true;
            this.txtCantidadEnemigos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadEnemigos.TabIndex = 1;
            // 
            // lblHPEnemigo
            // 
            this.lblHPEnemigo.AutoSize = true;
            this.lblHPEnemigo.Location = new System.Drawing.Point(10, 44);
            this.lblHPEnemigo.Name = "lblHPEnemigo";
            this.lblHPEnemigo.Size = new System.Drawing.Size(22, 13);
            this.lblHPEnemigo.TabIndex = 2;
            this.lblHPEnemigo.Text = "HP";
            // 
            // txtHPEnemigo
            // 
            this.txtHPEnemigo.Location = new System.Drawing.Point(66, 44);
            this.txtHPEnemigo.Name = "txtHPEnemigo";
            this.txtHPEnemigo.ReadOnly = true;
            this.txtHPEnemigo.Size = new System.Drawing.Size(100, 20);
            this.txtHPEnemigo.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(239, 122);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(491, 230);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // btnAtaqueEnemigo
            // 
            this.btnAtaqueEnemigo.Enabled = false;
            this.btnAtaqueEnemigo.Location = new System.Drawing.Point(19, 239);
            this.btnAtaqueEnemigo.Name = "btnAtaqueEnemigo";
            this.btnAtaqueEnemigo.Size = new System.Drawing.Size(168, 23);
            this.btnAtaqueEnemigo.TabIndex = 6;
            this.btnAtaqueEnemigo.Text = "Procesar Ataque Enemigo";
            this.btnAtaqueEnemigo.UseVisualStyleBackColor = true;
            this.btnAtaqueEnemigo.Click += new System.EventHandler(this.btnAtaqueEnemigo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnAtaqueEnemigo);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpStatsEnemigos);
            this.Controls.Add(this.grpStatusJugador);
            this.Controls.Add(this.grpAtaques);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpTurno);
            this.Name = "Form1";
            this.Text = "Intro RPG - Windows Forms Version";
            this.grpTurno.ResumeLayout(false);
            this.grpTurno.PerformLayout();
            this.grpAtaques.ResumeLayout(false);
            this.grpStatusJugador.ResumeLayout(false);
            this.grpStatusJugador.PerformLayout();
            this.grpStatsEnemigos.ResumeLayout(false);
            this.grpStatsEnemigos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTurno;
        private System.Windows.Forms.RadioButton rdbTurnoJugador;
        private System.Windows.Forms.RadioButton rdbTurnoEnemigo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpAtaques;
        private System.Windows.Forms.Button btnRayo;
        private System.Windows.Forms.Button btnViento;
        private System.Windows.Forms.Button btnAgua;
        private System.Windows.Forms.Button btnHielo;
        private System.Windows.Forms.Button btnTierra;
        private System.Windows.Forms.Button btnFuego;
        private System.Windows.Forms.GroupBox grpStatusJugador;
        private System.Windows.Forms.Label lblHPJugador;
        private System.Windows.Forms.TextBox txtHPJugador;
        private System.Windows.Forms.GroupBox grpStatsEnemigos;
        private System.Windows.Forms.Label lblCantidadEnemigos;
        private System.Windows.Forms.TextBox txtCantidadEnemigos;
        private System.Windows.Forms.Label lblHPEnemigo;
        private System.Windows.Forms.TextBox txtHPEnemigo;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnAtaqueEnemigo;
    }
}

