using System;
using System.Collections.Generic;
using System.Text;

namespace SA_Carlos
{
    class Cliente : Pessoa
    {
        public String telefone { get; set; }
        public String CPF { get; set; }

        public int codCliente { get; set; }

        public void realizaReserva(String CPF, String Telefone, DateTime Data, int mesa, int NPessoas, int metodoPagamento)
        {
            Reserva reserva = new Reserva();
            
        }
    }
}
