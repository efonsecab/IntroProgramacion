using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP_ConsoleApp
{
    class Persona
    {
        public Persona(string tipoDeDocumento)
        {
            this.TipoDeDocumento = tipoDeDocumento;
        }
        private string _Id = string.Empty;
        public string Identificador
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }
        }
        public string TipoDeDocumento
        {
            get;
            private set;
        }
        public string Nombre;
        public string PrimerApellido;
        public string SegundoApellido;

        public string NombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", Nombre, PrimerApellido, SegundoApellido);
            }
        }
    }
}
