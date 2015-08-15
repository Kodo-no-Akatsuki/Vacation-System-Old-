using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<string> ValidateLogin(string email, string password)
        {
            AkatsukiEntities akatsuki = new AkatsukiEntities();
            List<string> userData = new List<string>();

            foreach (tbl_usuarios user in akatsuki.tbl_usuarios.ToList())
            {
                if (user.email == email && user.password == password)
                {
                    userData.Add(user.email);
                    userData.Add(user.password);
                    userData.Add(user.primer_apellido);
                    userData.Add(user.primer_nombre);
                    userData.Add(user.segundo_apellido);
                    userData.Add(user.segundo_nombre);
                    userData.Add(user.activo.ToString());
                    userData.Add(user.fecha_creacion.ToString());
                    userData.Add(user.fecha_ingreso.ToString());
                    userData.Add(user.talento_humano.ToString());

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
