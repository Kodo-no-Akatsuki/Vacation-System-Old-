using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class Vacaciones
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

        public void Copy(VacacionesMirror vacacionesMirror)
        {
            VacacionesId = vacacionesMirror.VacacionesId;
            TalentoHumano = vacacionesMirror.TalentoHumano;
            Year = vacacionesMirror.Year;
            FechaSalida = vacacionesMirror.FechaSalida;
            FechaEntrada = vacacionesMirror.FechaEntrada;
            DiasSolicitados = vacacionesMirror.DiasSolicitados;
            FechaSolicitud = vacacionesMirror.FechaSolicitud;
            FechaAprobacion = vacacionesMirror.FechaAprobacion;
            EstatusId = vacacionesMirror.EstatusId;
        }
    }
}