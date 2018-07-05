using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDPerfilUsuarioAdministrador
    {
        public CRUDPerfilUsuarioAdministrador()
        {

        }

        public ContenedorPerfilUsuarioAdministrador LlamarSPCrearAdmin(ContenedorPerfilUsuarioAdministrador nPUA)
        {
            if (ValidarPerfilCUD(nPUA.Retorno.Token))
            {
                CRUDUsuario n = new CRUDUsuario();

                if(n.ExisteNomUsuActivo(nPUA.Item.Usuario.Nombre) == true)
                {
                    nPUA.Retorno.Codigo = 200;
                    nPUA.Retorno.Glosa = "Nombre de Usuario ya existe";
                } else {
                    var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                    var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    conex.SP_CREAR_ADMINISTRADOR
                        (nPUA.Item.Persona.Rut
                        , nPUA.Item.Persona.Nombre
                        , nPUA.Item.Persona.Apellido
                        , nPUA.Item.Persona.FechaNacimiento
                        , nPUA.Item.Persona.Email
                        , nPUA.Item.Persona.Telefono
                        , nPUA.Item.Usuario.Nombre
                        , nPUA.Item.Usuario.Clave
                        , p_OUT_CODRET
                        , p_OUT_GLSRET
                        );

                    try
                    {
                        nPUA.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                        nPUA.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                    }
                    catch (Exception)
                    {
                        nPUA.Retorno.Codigo = 1011;
                        nPUA.Retorno.Glosa = "Err codret ORACLE";
                    }
                }                
            } else {
                nPUA.Retorno.Codigo = 100;
                nPUA.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }
            return nPUA;
        }

        public ContenedorPerfilUsuarioAdministrador LlamarSPActualizar(ContenedorPerfilUsuarioAdministrador nPUA)
        {
            if (ValidarPerfilCUD(nPUA.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACTUALIZAR_ADMINISTRADOR
                    (nPUA.Item.Persona.Rut
                    , nPUA.Item.Persona.Nombre
                    , nPUA.Item.Persona.Apellido
                    , nPUA.Item.Persona.FechaNacimiento
                    , nPUA.Item.Persona.Email
                    , nPUA.Item.Persona.Telefono
                    , nPUA.Item.Usuario.Id
                    , nPUA.Item.Usuario.Clave
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    nPUA.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nPUA.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    nPUA.Retorno.Codigo = 1011;
                    nPUA.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                nPUA.Retorno.Codigo = 100;
                nPUA.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nPUA;
        }

        public ContenedorPerfilUsuarioAdministradores LlamarSPRescatar(String token)
        {
            ContenedorPerfilUsuarioAdministradores LPerfilUsuarioAdministradores = new ContenedorPerfilUsuarioAdministradores();

            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from per in conex.PERSONA
                                      join usu in conex.USUARIO on per.RUT equals usu.RUT_PERSONA
                                      where usu.PERFIL == "Administrador"
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
                        PerfilUsuarioAdministrador m = new PerfilUsuarioAdministrador();
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
                        LPerfilUsuarioAdministradores.Lista.Add(m);
                    }
                    LPerfilUsuarioAdministradores.Retorno.Codigo = 0;
                    LPerfilUsuarioAdministradores.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LPerfilUsuarioAdministradores.Retorno.Codigo = 1011;
                    LPerfilUsuarioAdministradores.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LPerfilUsuarioAdministradores.Retorno.Codigo = 100;
                LPerfilUsuarioAdministradores.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LPerfilUsuarioAdministradores;
        }

        public bool eliminarUsuario(ContenedorPerfilUsuarioAdministrador nPUA)
        {
            if (ValidarPerfilCUD(nPUA.Retorno.Token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
                    var eliminar = conex.USUARIO.SingleOrDefault(b => b.NOMBRE == nPUA.Item.Usuario.Nombre);
                    eliminar.ESTADO = "desactivado";
                    conex.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public ContenedorPerfilUsuarioAdministrador LlamarSPRescatarXRut(String rut, String token)
        {
            ContenedorPerfilUsuarioAdministrador cPUA = new ContenedorPerfilUsuarioAdministrador();

            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var item = (from per in conex.PERSONA
                                join usu in conex.USUARIO on per.RUT equals usu.RUT_PERSONA
                                where usu.PERFIL == "Administrador"
                                   && usu.RUT_PERSONA == rut
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
                            ).SingleOrDefault();

                    if (item != null)
                    {
                        PerfilUsuarioAdministrador m = new PerfilUsuarioAdministrador();
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
                        cPUA.Item = m;
                        cPUA.Retorno.Codigo = 0;
                        cPUA.Retorno.Glosa = "OK";
                    } else {
                        cPUA.Retorno.Codigo = 200;
                        cPUA.Retorno.Glosa = "Aviso, dato no encontrado";
                    }
                }
                catch (Exception)
                {
                    cPUA.Retorno.Codigo = 1011;
                    cPUA.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                cPUA.Retorno.Codigo = 100;
                cPUA.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return cPUA;
        }

        //public PerfilUsuarioAdministrador buscarAdministradorPorRut(String  rut, String token)
        //{
        //    if (ValidarPerfilCUD(token))
        //    {
        //        try
        //        {
        //            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
        //            var usuario = conex.USUARIO.SingleOrDefault(b => b.RUT_PERSONA == rut);
        //            var persona = conex.PERSONA.SingleOrDefault(b => b.RUT == rut);
        //            PerfilUsuarioAdministrador pAdmin = new PerfilUsuarioAdministrador();
        //            pAdmin.Persona.Nombre = persona.NOMBRE;
        //            pAdmin.Persona.Apellido = persona.APELLIDO;
        //            pAdmin.Persona.Email = persona.EMAIL;
        //            pAdmin.Persona.FechaNacimiento = persona.NACIMIENTO;
        //            pAdmin.Persona.Rut = persona.RUT;
        //            pAdmin.Persona.Telefono = persona.TELEFONO;
        //            pAdmin.Usuario.Estado = usuario.ESTADO;
        //            pAdmin.Usuario.Clave = usuario.CLAVE;
        //            pAdmin.Usuario.Id = usuario.ID;
        //            pAdmin.Usuario.Nombre = usuario.NOMBRE;
        //            pAdmin.Usuario.Perfil = usuario.PERFIL;
        //            pAdmin.Usuario.RutPersona = usuario.RUT_PERSONA;
        //            return pAdmin;
        //        }
        //        catch (Exception)
        //        {
        //            return null;
        //        }
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Administrador");
            if (x.ValidarPerfil(token, Perfiles))
            {
                retorno = true;
            }
            return retorno;
        }
    }    
}
