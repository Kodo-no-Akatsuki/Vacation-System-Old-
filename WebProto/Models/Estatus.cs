using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class Estatus
    {
        public int EstatusId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public void Copy(StatusMirror statusMirror)
        {
            EstatusId = statusMirror.Id;
            Descripcion = statusMirror.Descripcion;
            Activo = statusMirror.Activo;
        }
    }
}