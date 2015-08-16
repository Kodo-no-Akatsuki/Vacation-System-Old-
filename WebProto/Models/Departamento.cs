using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public void Copy(DepartamentoMirror departamentoMirror)
        {
            DepartamentoId = departamentoMirror.DepartamentoId;
            Descripcion = departamentoMirror.Descripcion;
            Activo = departamentoMirror.Activo;
        }
    }
}