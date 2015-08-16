using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.MirrorClasses
{
    public class DepartamentoMirror
    {
        public int DepartamentoId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
