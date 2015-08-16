using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class Jerarquia
    {
        public int JerarquiaId { get; set; }
        public int TalentoHumano { get; set; }
        public int JefeTalentoHumano { get; set; }
        public int DepartamentoId { get; set; }

        public void Copy(JerarquiaMirror jerarquiaMirror)
        {
            JerarquiaId = jerarquiaMirror.JerarquiaId;
            TalentoHumano = jerarquiaMirror.TalentoHumano;
            JefeTalentoHumano = jerarquiaMirror.TalentoHumano;
            DepartamentoId = jerarquiaMirror.DepartamentoId;
        }
    }
}