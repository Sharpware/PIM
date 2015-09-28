using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Endereco
    {
        private String _rua;
        private int _numero;
        private String _complemento;
        private int _cep;
        private String _bairro;
        private string _uf;
        private String _cidade;

        public Endereco(String rua, int numero, String complemento, int cep, String bairro, String uf, String cidade)
        {
            _rua = rua;
            _numero = numero;
            _complemento = complemento;
            _cep = cep;
            _bairro = bairro;
            _uf = uf;
            _cidade = cidade;
        }

        public string Rua
        {
            get
            {
                return _rua;
            }
        }

        public int Numero
        {
            get
            {
                return _numero;
            }
        }

        public string Complemento
        {
            get
            {
                return _complemento;
            }
        }

        public int Cep
        {
            get
            {
                return _cep;
            }
        }

        public string Bairro
        {
            get
            {
                return _bairro;
            }
        }

        public string Uf
        {
            get
            {
                return _uf;
            }
        }

        public string Cidade
        {
            get
            {
                return _cidade;
            }
        }

    }
}
