using System;
using System.Collections.Generic;
using System.Text;

namespace SA_Carlos
{
    class Reserva
    {
        public int idReserva { get; set; }
        public DateTime dataReserva { get; set; }

        public List<int> mesa = new List<int>();
        public int nPessoas { get; set; }
        public String CPFReservista { get; set; }
    }
}