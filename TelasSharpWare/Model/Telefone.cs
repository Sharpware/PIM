using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Telefone
    {
        private String _numero;
        private TipoTelefone _tipoTelefone;

        public Telefone(String numero, TipoTelefone tipoTelefone)
        {
            _numero = numero;
            _tipoTelefone = tipoTelefone;
        }

        public string Numero
        {
            get
            {
                return _numero;
            }
        }

        public TipoTelefone TipoTelefone
        {
            get
            {
                return _tipoTelefone;
            }
        }
    }
}
