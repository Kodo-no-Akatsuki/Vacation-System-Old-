using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.MirrorClasses
{
    public class JerarquiaMirror
    {
        public int JerarquiaId { get; set; }
        public int TalentoHumano { get; set; }
        public int JefeTalentoHumano { get; set; }
        public int DepartamentoId { get; set; }
    }
}
