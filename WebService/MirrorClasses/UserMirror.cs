using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.MirrorClasses
{
    public class UserMirror
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public int TalentoHumano { get; set; }
    }
}
