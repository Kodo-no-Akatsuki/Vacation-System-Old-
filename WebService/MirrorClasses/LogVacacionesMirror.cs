using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.MirrorClasses
{
    public class LogVacacionesMirror
    {
        public int LogId { get; set; }
        public int VacacionesId { get; set; }
        public int Modifico { get; set; }
        public int EstatusAnterior { get; set; }
        public int EstatusActual { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
