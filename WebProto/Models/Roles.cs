using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class Roles
    {
        public int RolesId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public void Copy(RolesMirror rolesMirror)
        {
            RolesId = rolesMirror.Id;
            Descripcion = rolesMirror.Descripcion;
            Activo = rolesMirror.Activo;
        }
    }
}