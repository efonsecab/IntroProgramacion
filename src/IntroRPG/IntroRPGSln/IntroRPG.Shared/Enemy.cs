using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroRPG.Shared
{
    class Enemy
    {
        public Stats EnemyStats { get; set; }
        public TipoElemento Elemento { get; set; }
        public Enemy(Stats enemyStats)
        {
            this.EnemyStats = enemyStats;
        }

        public void SetRandomElement()
        {
            Array values = Enum.GetValues(typeof(TipoElemento));
            Random rnd = new Random();
            int rndPos = rnd.Next(0, values.Length);
            TipoElemento elemento = (TipoElemento)values.GetValue(rndPos);
            this.Elemento = elemento;
        }
    }
}
