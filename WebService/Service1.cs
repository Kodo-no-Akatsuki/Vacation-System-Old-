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
        
        public Empleado ValidateLogin(string email, string password)
        {
            AkatsukiEntities akatsuki = new AkatsukiEntities();
            Empleado empleado = new Empleado();
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

                    empleado.User = userData;

                    foreach(tbl_jerarquia jerarquia in user.tbl_jerarquia.ToList())
                    {
                        JerarquiaMirror jm = new JerarquiaMirror();
                        jm.DepartamentoId = jerarquia.departamentoid;
                        jm.JefeTalentoHumano = jerarquia.jefe_talentohumano;
                        jm.JerarquiaId = jerarquia.jerarquiaid;
                        jm.TalentoHumano = jerarquia.talento_humano;

                        empleado.Jerarquias.Add(jm);
                    }
                    
                    foreach(tbl_departamento dep in user.tbl_departamento.ToList())
                    {
                        DepartamentoMirror dp = new DepartamentoMirror();
                        dp.Activo = dep.activo;
                        dp.DepartamentoId = dep.departamentoid;
                        dp.Descripcion = dep.descripcion;

                        empleado.Departamento.Add(dp);
                    }

                    foreach(tbl_vacaciones vac in user.tbl_vacaciones.ToList())
                    {
                        VacacionesMirror vc = new VacacionesMirror();
                        vc.DiasSolicitados = vac.dias_solicitados;
                        vc.EstatusId = vac.estatusid;
                        vc.FechaAprobacion = vac.fecha_de_aprobacion;
                        vc.FechaEntrada = vac.fecha_entrada;
                        vc.FechaSalida = vac.fecha_salida;
                        vc.FechaSolicitud = vac.fecha_solicitud;
                        vc.TalentoHumano = vac.talento_humano;
                        vc.VacacionesId = vac.vacacionesid;

                        empleado.Vacaciones.Add(vc);
                    }

                    foreach(tbl_roles rol in user.tbl_roles.ToList())
                    {
                        foreach(tbl_permisos permiso in rol.tbl_permisos.ToList())
                        {
                            //Llenar un espejo de permiso y agregarlo a la empleado
                            PermisosMirror permisoMirror = new PermisosMirror();

                            permisoMirror.PermisosId = permiso.permisosid;
                            permisoMirror.Descripcion = permiso.descripcion;
                            permisoMirror.Activo = permiso.activo;

                            empleado.Permisos.Add(permisoMirror);
                        }
                    }

                    foreach(tbl_roles rol in user.tbl_roles.ToList())
                    {
                        foreach(tbl_permisos permiso in rol.tbl_permisos.ToList())
                        {
                            //Llenar un espejo de permiso y agregarlo a la empleado
                            PermisosMirror permisoMirror = new PermisosMirror();

                            permisoMirror.PermisosId = permiso.permisosid;
                            permisoMirror.Descripcion = permiso.descripcion;
                            permisoMirror.Activo = permiso.activo;

                            empleado.Permisos.Add(permisoMirror);
                        }
                    }

                    

                    return empleado;
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
