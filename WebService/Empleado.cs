using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.MirrorClasses;

namespace WebService
{
    public class Empleado
    {
        public UserMirror User { get; set; }
        public List<DepartamentoMirror> Departamento { get; set; }
        public List<JerarquiaMirror> Jerarquias { get; set; }
        public List<LogVacacionesMirror> LogVacaciones { get; set; }
        public List<PermisosMirror> Permisos { get; set; }
        public List<RolesMirror> Roles { get; set; }
        public List<StatusMirror> Status { get; set; }
        public List<TipoDiaMirror> TipoDia { get; set; }
        public List<VacacionesMirror> Vacaciones { get; set; }
    }
}
