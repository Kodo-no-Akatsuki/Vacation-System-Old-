using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.MirrorClasses
{
    public class VacacionesMirror
    {
        public int VacacionesId { get; set; }
        public int TalentoHumano { get; set; }
        public int Year { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int DiasSolicitados { get; set; }
        public int FechaSolicitud { get; set; }//En la BaseDatos esta como int
        public DateTime FechaAprobacion { get; set; }
        public int EstatusId { get; set; }
    }
}
