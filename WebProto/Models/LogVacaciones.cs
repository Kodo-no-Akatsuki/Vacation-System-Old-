using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class LogVacaciones
    {
        public int LogId { get; set; }
        public int VacacionesId { get; set; }
        public int Modifico { get; set; }
        public int EstatusAnterior { get; set; }
        public int EstatusActual { get; set; }
        public DateTime FechaModificacion { get; set; }

        public void Copy(LogVacacionesMirror logMirror)
        {
            LogId = logMirror.LogId;
            VacacionesId = logMirror.VacacionesId;
            Modifico = logMirror.Modifico;
            EstatusAnterior = logMirror.EstatusAnterior;
            EstatusActual = logMirror.EstatusActual;
            FechaModificacion = logMirror.FechaModificacion;
        }
    }
}