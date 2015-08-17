using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService.MirrorClasses;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        
        public UserMirror ValidateLogin(string email, string password)
        {
            AkatsukiEntities akatsuki = new AkatsukiEntities();
            UserMirror userData = new UserMirror();

            foreach (tbl_usuarios user in akatsuki.tbl_usuarios.ToList())
            {
                if (user.email == email && user.password == password)
                {
                    userData.Email = user.email;
                    userData.Password = user.password;
                    userData.PrimerNombre = user.primer_nombre;
                    userData.SegundoNombre = user.segundo_nombre;
                    userData.PrimerApellido = user.primer_apellido;
                    userData.SegundoApellido = user.segundo_apellido;
                    userData.TalentoHumano = user.talento_humano;
                    userData.FechaIngreso = user.fecha_ingreso;
                    userData.FechaCreacion = user.fecha_creacion;
                    userData.Activo = user.activo;
                    
                    return userData;
                }
            }

            return null;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
