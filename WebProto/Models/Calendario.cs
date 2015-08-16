using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProto.Models
{
    public class Calendario
    {
        public int TalentoHumanoJefe { get; set; }
        public int TalentoHumanoEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoDiaId { get; set; }

        //public void Copy(Calendario)
    }
}