using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroRPG.Shared
{
    public enum Turno
    {
        Jugador,
        Enemigo
    }
    public class GameController
    {
        private Player Player { get; set; }
        private List<Enemy> Enemies = new List<Enemy>();
        public Turno TurnoActual { get; set; }
        private List<Ataque> Ataques = new List<Ataque>();

        private Enemy TargetActual { get; set; }

        public object GetPlayerHP()
        {
            return this.Player.PlayerStats.HealthPoints;
        }

        public bool TieneTarget()
        {
            return (this.TargetActual != null);
        }

        public int GetEnemyHP()
        {
            return this.TargetActual.EnemyStats.HealthPoints;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialPlayerHealthPoints">initialPlayerHealthPoints must be higher than 100</param>
        /// <param name="totalEnemies"></param>
        public GameController(int initialPlayerHealthPoints, int totalEnemies)
        {
            Stats playerStats = new Stats();
            playerStats.HealthPoints = initialPlayerHealthPoints;
            this.Player = new Player(playerStats);
            Random rnd = new Random();
            for (int iPos = 0; iPos < totalEnemies; iPos++)
            {
                //el segundo parámetro es exclusivo
                int enemyHealthPoints = rnd.Next(100, initialPlayerHealthPoints + 1);
                Stats newEnemyStats = new Stats();
                newEnemyStats.HealthPoints = enemyHealthPoints;
                Enemy objNewEnemy = new Enemy(newEnemyStats);
                objNewEnemy.SetRandomElement();
                this.Enemies.Add(objNewEnemy);
            }
            Ataque objRayo = new Ataque(TipoElemento.Rayo,
                new TipoElemento[] { TipoElemento.Agua },
                new TipoElemento[] { TipoElemento.Tierra },
                5, 2);

            Ataque objFuego = new Ataque(TipoElemento.Fuego,
                new TipoElemento[] { TipoElemento.Hielo },
                new TipoElemento[] { TipoElemento.Viento },
                10, 5);

            Ataque objTierra = new Ataque(TipoElemento.Tierra,
                new TipoElemento[] { TipoElemento.Rayo },
                new TipoElemento[] { TipoElemento.Agua },
                7, 5);

            Ataque objHielo = new Ataque(TipoElemento.Hielo,
                new TipoElemento[] { TipoElemento.Viento },
                new TipoElemento[] { TipoElemento.Fuego },
                8, 4);

            Ataque objAgua = new Ataque(TipoElemento.Agua,
                new TipoElemento[] { TipoElemento.Tierra },
                new TipoElemento[] { TipoElemento.Rayo },
                8, 4);

            Ataque objViento = new Ataque(TipoElemento.Viento,
                new TipoElemento[] { TipoElemento.Fuego },
                new TipoElemento[] { TipoElemento.Viento },
                8, 4);

            Ataques.Add(objRayo);
            Ataques.Add(objFuego);
            Ataques.Add(objTierra);
            Ataques.Add(objHielo);
            Ataques.Add(objAgua);
            Ataques.Add(objViento);
        }

        public Ataque AtacarEnemigo(TipoElemento tipoDeElemento, out int damage)
        {
            Ataque objAtaque = ObtenerAtaque(tipodeAtaque: tipoDeElemento);
            damage = CalcularDmg(objAtaque);
            this.TargetActual.EnemyStats.HealthPoints -= damage;
            return objAtaque;
        }

        private int CalcularDmg(Ataque objAtaque)
        {
            int damage = objAtaque.BaseDamage;
            foreach (TipoElemento fuerteContra in objAtaque.FuerteContra)
            {
                if (fuerteContra == TargetActual.Elemento)
                {
                    //el ataque seleccionado es furte contra el elemento del enemigo
                    damage += objAtaque.DamageModifier;
                }
            }
            foreach (TipoElemento debilContra in objAtaque.DebilContra)
            {
                if (debilContra == TargetActual.Elemento)
                {
                    damage -= objAtaque.DamageModifier;
                }
            }

            return damage;
        }

        public Ataque AtacarJugador(out int damage)
        {
            Array values = Enum.GetValues(typeof(TipoElemento));
            Random rnd = new Random();
            int rndPos = rnd.Next(0, values.Length);
            TipoElemento elemento = (TipoElemento)values.GetValue(rndPos);
            Ataque objAtaque = ObtenerAtaque(elemento);
            damage = CalcularDmg(objAtaque);
            this.Player.PlayerStats.HealthPoints -= damage;
            return objAtaque;
        }

        private Ataque ObtenerAtaque(TipoElemento tipodeAtaque)
        {
            Ataque objAtaque = null;
            for(int iPos=0; iPos < this.Ataques.Count; iPos++)
            {
                if (this.Ataques[iPos].Tipo == tipodeAtaque)
                {
                    objAtaque = this.Ataques[iPos];
                    break;
                }
            }
            return objAtaque;
        }

        public void StartGame()
        {
            Random rnd = new Random();
            this.TurnoActual = Turno.Jugador;
            this.TargetActual = this.Enemies[rnd.Next(0, this.Enemies.Count)];
        }
    }
}
