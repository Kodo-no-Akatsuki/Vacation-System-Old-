using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.MirrorClasses;

namespace WebProto.Models
{
    public class TipoDia
    {
        public int TipoDiaId { get; set; }
        public int Descripcion { get; set; }

        public void Copy(TipoDiaMirror diaMirror)
        {
            TipoDiaId = diaMirror.TipoDiaId;
            Descripcion = diaMirror.Descripcion;
        }
    }
}