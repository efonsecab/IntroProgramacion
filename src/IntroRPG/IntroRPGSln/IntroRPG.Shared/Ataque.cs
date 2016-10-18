using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroRPG.Shared
{
    public enum TipoElemento
    {
        Rayo,
        Fuego,
        Tierra,
        Hielo,
        Agua,
        Viento
    }
    public class Ataque
    {
        public TipoElemento Tipo { get; set; }
        public TipoElemento[] FuerteContra { get; set; }
        public TipoElemento[] DebilContra { get; set; }
        public int BaseDamage { get; set; }
        public int DamageModifier { get; set; }

        public Ataque(TipoElemento tipo, TipoElemento[] fuerteContra, TipoElemento[] debilContra,
            int basedmg, int dmgModifier)
        {
            this.Tipo = tipo;
            this.FuerteContra = fuerteContra;
            this.DebilContra = debilContra;
            this.BaseDamage = basedmg;
            this.DamageModifier = dmgModifier;
        }
        public string Nombre
        {
            get
            {
                return this.Tipo.ToString();
            }
        }
    }
}
