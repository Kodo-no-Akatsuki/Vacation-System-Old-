using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string  PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public int TalentoHumano { get; set; }

        public void Copy(UserMirror userMirror)
        {
            Email = userMirror.Email;
            Password = userMirror.Password;
            PrimerNombre = userMirror.PrimerNombre;
            SegundoNombre = userMirror.SegundoNombre;
            PrimerApellido = userMirror.PrimerApellido;
            SegundoApellido = userMirror.SegundoApellido;
            FechaIngreso = userMirror.FechaIngreso;
            FechaCreacion = userMirror.FechaCreacion;
            Activo = userMirror.Activo;
            TalentoHumano = userMirror.TalentoHumano;
        }
    }
}