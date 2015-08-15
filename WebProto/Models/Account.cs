using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProto.Models
{
    public class Account
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public string  PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaCreacion { get; set; }
        public string Activo { get; set; }
        public string TalentoHumano { get; set; }
    }
}