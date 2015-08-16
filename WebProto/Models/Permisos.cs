using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class Permisos
    {
        public int PermisosId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public void Copy(PermisosMirror permisosMirror)
        {
            PermisosId = permisosMirror.PermisosId;
            Descripcion = permisosMirror.Descripcion;
            Activo = permisosMirror.Activo;
        }
    }
}