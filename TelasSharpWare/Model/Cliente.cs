using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Cliente : Pessoa
    {
        public Cliente(long id, String nome, long cpf, DateTime dataNascimento,
                       String email, String observacao, Status status, Endereco endereco) :
            base(id, nome, cpf, dataNascimento, email, observacao, status, endereco)
        {

        }
    }
}
