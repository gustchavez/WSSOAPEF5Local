using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CRUDPerfilUsuarioEmpleado
    {
        public CRUDPerfilUsuarioEmpleado()
        {

        }

        public ContenedorPerfilUsuarioEmpleado LlamarSPCrear(ContenedorPerfilUsuarioEmpleado nPUC)
        {
            if (ValidarPerfilCUD(nPUC.Retorno.Token))
            {
                CRUDUsuario n = new CRUDUsuario();

                if (n.ExisteNomUsuActivo(nPUC.Item.Usuario.Nombre) == true)
                {
                    nPUC.Retorno.Codigo = 200;
                    nPUC.Retorno.Glosa = "Nombre de Usuario ya existe";
                }
                else {
                    var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                    var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    conex.SP_CREAR_EMPLEADO
                        ( nPUC.Item.Persona.Rut
                        , nPUC.Item.Persona.Nombre
                        , nPUC.Item.Persona.Apellido
                        , nPUC.Item.Persona.FechaNacimiento
                        , nPUC.Item.Persona.Email
                        , nPUC.Item.Persona.Telefono
                        , nPUC.Item.Usuario.Nombre
                        , nPUC.Item.Usuario.Clave
                        , p_OUT_CODRET
                        , p_OUT_GLSRET
                        );

                    try
                    {
                        nPUC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                        nPUC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                    }
                    catch (Exception)
                    {
                        nPUC.Retorno.Codigo = 1011;
                        nPUC.Retorno.Glosa = "Err codret ORACLE";
                    }
                }
            }
            else {
                nPUC.Retorno.Codigo = 100;
                nPUC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nPUC;
        }

        public ContenedorPerfilUsuarioEmpleado LlamarSPActualizar(ContenedorPerfilUsuarioEmpleado nPUC)
        {
            if (ValidarPerfilCUD(nPUC.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACTUALIZAR_EMPLEADO
                    (nPUC.Item.Persona.Rut
                    , nPUC.Item.Persona.Nombre
                    , nPUC.Item.Persona.Apellido
                    , nPUC.Item.Persona.FechaNacimiento
                    , nPUC.Item.Persona.Email
                    , nPUC.Item.Persona.Telefono
                    , nPUC.Item.Usuario.Id
                    , nPUC.Item.Usuario.Clave
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    nPUC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nPUC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    nPUC.Retorno.Codigo = 1011;
                    nPUC.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                nPUC.Retorno.Codigo = 100;
                nPUC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nPUC;
        }

        public ContenedorPerfilUsuarioEmpleados LlamarSPRescatar(String token)
        {
            ContenedorPerfilUsuarioEmpleados LPerfilUsuarioEmpleados = new ContenedorPerfilUsuarioEmpleados();

            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from per in conex.PERSONA
                                      join usu in conex.USUARIO on per.RUT equals usu.RUT_PERSONA
                                      orderby per.RUT
                                      select new
                                      {
                                          RutPersona = per.RUT,
                                          NombrePer = per.NOMBRE,
                                          ApellidoPer = per.APELLIDO,
                                          FecNacPer = per.NACIMIENTO,
                                          MailPer = per.EMAIL,
                                          TelefonoPer = per.TELEFONO,
                                          NomUsuario = usu.NOMBRE,
                                          PassUsiario = usu.CLAVE
                                      }
                            ).ToList();

                    foreach (var item in collection)
                    {
                        PerfilUsuarioEmpleado m = new PerfilUsuarioEmpleado();
                        //
                        m.Persona.Rut = item.RutPersona;
                        m.Persona.Nombre = item.NombrePer;
                        m.Persona.Apellido = item.ApellidoPer;
                        m.Persona.FechaNacimiento = item.FecNacPer;
                        m.Persona.Email = item.MailPer;
                        m.Persona.Telefono = item.TelefonoPer;
                        //
                        m.Usuario.Nombre = item.NomUsuario;
                        m.Usuario.Clave = item.PassUsiario;
                        //
                        LPerfilUsuarioEmpleados.Lista.Add(m);
                    }
                    LPerfilUsuarioEmpleados.Retorno.Codigo = 0;
                    LPerfilUsuarioEmpleados.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LPerfilUsuarioEmpleados.Retorno.Codigo = 1011;
                    LPerfilUsuarioEmpleados.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LPerfilUsuarioEmpleados.Retorno.Codigo = 100;
                LPerfilUsuarioEmpleados.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LPerfilUsuarioEmpleados;
        }
        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Empleado");
            Perfiles.Add("Administrador");
            if (x.ValidarPerfil(token, Perfiles))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
