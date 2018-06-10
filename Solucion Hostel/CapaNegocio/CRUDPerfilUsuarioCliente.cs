using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;

namespace CapaNegocio
{
    public class CRUDPerfilUsuarioCliente
    {
        
        public CRUDPerfilUsuarioCliente()
        {
        
        }
        
        public ContenedorPerfilUsuarioCliente LlamarSPCrear(ContenedorPerfilUsuarioCliente nPUC)
        {
            //if (ValidarPerfilCUD(nPUC.Retorno.Token))
            //{
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_CLIENTE
                    ( nPUC.Item.Cliente.Rut
                    , nPUC.Item.PerfilUsuario.Empresa.RazonSocial
                    , nPUC.Item.PerfilUsuario.Empresa.Rubro
                    , nPUC.Item.PerfilUsuario.Empresa.Email
                    , nPUC.Item.PerfilUsuario.Empresa.Telefono
                    , nPUC.Item.PerfilUsuario.Empresa.Logo
                    , nPUC.Item.PerfilUsuario.Persona.Rut
                    , nPUC.Item.PerfilUsuario.Persona.Nombre
                    , nPUC.Item.PerfilUsuario.Persona.Apellido
                    , nPUC.Item.PerfilUsuario.Persona.FechaNacimiento
                    , nPUC.Item.PerfilUsuario.Persona.Email
                    , nPUC.Item.PerfilUsuario.Persona.Telefono
                    , nPUC.Item.PerfilUsuario.Direccion.Calle
                    , nPUC.Item.PerfilUsuario.Direccion.Numero
                    , nPUC.Item.PerfilUsuario.Direccion.Comuna
                    , nPUC.Item.PerfilUsuario.Direccion.CodPostal
                    , nPUC.Item.PerfilUsuario.Direccion.NombreCiudad
                    , nPUC.Item.PerfilUsuario.Direccion.CodPais
                    , nPUC.Item.PerfilUsuario.Usuario.Clave
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    ) ;
            
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
            //} else {
            //    nPUC.Retorno.Codigo = 100;
            //    nPUC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            //}

            return nPUC;
        }
        public ContenedorPerfilUsuarioCliente LlamarSPActualizar(ContenedorPerfilUsuarioCliente aPUC)
        {
            if (ValidarPerfilCUD(aPUC.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACTUALIZAR_CLIENTE
                    ( aPUC.Item.Cliente.Rut
                    , aPUC.Item.PerfilUsuario.Empresa.RazonSocial
                    , aPUC.Item.PerfilUsuario.Empresa.Rubro
                    , aPUC.Item.PerfilUsuario.Empresa.Email
                    , aPUC.Item.PerfilUsuario.Empresa.Telefono
                    , aPUC.Item.PerfilUsuario.Empresa.Logo
                    , aPUC.Item.PerfilUsuario.Persona.Rut
                    , aPUC.Item.PerfilUsuario.Persona.Nombre
                    , aPUC.Item.PerfilUsuario.Persona.Apellido
                    , aPUC.Item.PerfilUsuario.Persona.FechaNacimiento
                    , aPUC.Item.PerfilUsuario.Persona.Email
                    , aPUC.Item.PerfilUsuario.Persona.Telefono
                    , aPUC.Item.PerfilUsuario.Direccion.Calle
                    , aPUC.Item.PerfilUsuario.Direccion.Numero
                    , aPUC.Item.PerfilUsuario.Direccion.Comuna
                    , aPUC.Item.PerfilUsuario.Direccion.CodPostal
                    , aPUC.Item.PerfilUsuario.Direccion.NombreCiudad
                    , aPUC.Item.PerfilUsuario.Direccion.CodPais
                    , aPUC.Item.PerfilUsuario.Usuario.Id
                    , aPUC.Item.PerfilUsuario.Usuario.Clave
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    aPUC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    aPUC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    aPUC.Retorno.Codigo = 1011;
                    aPUC.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                aPUC.Retorno.Codigo = 100;
                aPUC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return aPUC;
        }
        public ContenedorPerfilUsuarioClientes LlamarSPRescatar(string token)
        {
            ContenedorPerfilUsuarioClientes LPerfilUsuarioClientes = new ContenedorPerfilUsuarioClientes();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from cli in conex.CLIENTE
                                      join emp in conex.EMPRESA   on cli.RUT equals emp.RUT
                                      join dir in conex.DIRECCION on cli.RUT equals dir.RUT_EMPRESA
                                      join per in conex.PERSONA   on dir.RUT_PERSONA equals per.RUT
                                      join usu in conex.USUARIO   on per.RUT equals usu.RUT_PERSONA
                                      orderby emp.RAZON_SOCIAL
                                      select new
                                      {
                                          RutCliente  = cli.RUT,
                                          RazonSocial = emp.RAZON_SOCIAL,
                                          MailEmpresa = emp.EMAIL,
                                          TelefonoEmp = emp.TELEFONO,
                                          NomCiudadDir = dir.NOMBRE_CIUDAD,
                                          CalleDirecc = dir.CALLE,
                                          NomUsuario  = usu.NOMBRE,
                                          PassUsiario = usu.CLAVE
                                      }
                            ).ToList();

                    foreach (var item in collection)
                    {
                        PerfilUsuarioCliente m = new PerfilUsuarioCliente();
                        //
                        m.Cliente.Rut = item.RutCliente;
                        m.PerfilUsuario.Empresa.RazonSocial    = item.RazonSocial;
                        m.PerfilUsuario.Empresa.Email          = item.MailEmpresa;
                        m.PerfilUsuario.Empresa.Telefono       = item.MailEmpresa;
                        m.PerfilUsuario.Direccion.NombreCiudad = item.CalleDirecc;
                        m.PerfilUsuario.Direccion.Calle        = item.CalleDirecc;
                        m.PerfilUsuario.Usuario.Nombre         = item.NomUsuario;
                        m.PerfilUsuario.Usuario.Clave          = item.PassUsiario;
                        //
                        LPerfilUsuarioClientes.Lista.Add(m);

                    }
                    LPerfilUsuarioClientes.Retorno.Codigo = 0;
                    LPerfilUsuarioClientes.Retorno.Glosa = "OK";

                }
                catch (Exception)
                {
                    LPerfilUsuarioClientes.Retorno.Codigo = 1011;
                    LPerfilUsuarioClientes.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LPerfilUsuarioClientes.Retorno.Codigo = 100;
                LPerfilUsuarioClientes.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LPerfilUsuarioClientes;
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

        private bool ValidarFecExp(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            if (x.ValidarFechaExpiracion(token))
            {
                retorno = true;
            }
            return retorno;
        }
        public PerfilUsuarioCliente buscarClientePorRut(String rut, String token)
        {
            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var item = (from cli in conex.CLIENTE
                                      join emp in conex.EMPRESA on cli.RUT equals emp.RUT
                                      join dir in conex.DIRECCION on cli.RUT equals dir.RUT_EMPRESA
                                      join per in conex.PERSONA on dir.RUT_PERSONA equals per.RUT
                                      join usu in conex.USUARIO on per.RUT equals usu.RUT_PERSONA
                                      where per.RUT == rut
                                      select new
                                      {
                                          RutCliente = cli.RUT,
                                          RazonSocial = emp.RAZON_SOCIAL,
                                          MailEmpresa = emp.EMAIL,
                                          TelefonoEmp = emp.TELEFONO,
                                          Rubro = emp.RUBRO,
                                          Logo = emp.RUBRO,
                                          NomCiudadDir = dir.NOMBRE_CIUDAD,
                                          CalleDirecc = dir.CALLE,
                                          CodPais = dir.COD_PAIS,
                                          CodPostal = dir.COD_POSTAL,
                                          Comuna = dir.COMUNA,
                                          Numero = dir.NUMERO,
                                          NomUsuario = usu.NOMBRE,
                                          PassUsiario = usu.CLAVE,
                                          RutPersona = per.RUT,
                                          NombrePersona = per.NOMBRE,
                                          ApellidoPersona = per.APELLIDO,
                                          FechaNacimientoPersona = per.NACIMIENTO,
                                          EmailPersona = per.EMAIL,
                                          TelefonoPersona = per.TELEFONO
                                      }
                            ).SingleOrDefault();

                    PerfilUsuarioCliente m = new PerfilUsuarioCliente();
                    //
                    m.Cliente.Rut = item.RutCliente;
                    m.PerfilUsuario.Empresa.RazonSocial = item.RazonSocial;
                    m.PerfilUsuario.Empresa.Rubro = item.Rubro;
                    m.PerfilUsuario.Empresa.Email = item.MailEmpresa;
                    m.PerfilUsuario.Empresa.Telefono = item.TelefonoEmp;
                    m.PerfilUsuario.Direccion.CodPais = int.Parse(item.CodPais.ToString());
                    m.PerfilUsuario.Direccion.CodPostal = item.CodPostal;
                    m.PerfilUsuario.Direccion.NombreCiudad = item.NomCiudadDir;
                    m.PerfilUsuario.Direccion.Comuna = item.Comuna;
                    m.PerfilUsuario.Direccion.Calle = item.CalleDirecc;
                    m.PerfilUsuario.Direccion.Numero = item.Numero;
                    m.PerfilUsuario.Empresa.Logo = item.Rubro;
                    m.PerfilUsuario.Persona.Rut = item.RutPersona;
                    m.PerfilUsuario.Persona.Nombre = item.NombrePersona;
                    m.PerfilUsuario.Persona.Apellido = item.ApellidoPersona;
                    m.PerfilUsuario.Persona.FechaNacimiento = item.FechaNacimientoPersona;
                    m.PerfilUsuario.Persona.Email = item.EmailPersona;
                    m.PerfilUsuario.Persona.Telefono = item.TelefonoPersona;
                    m.PerfilUsuario.Usuario.Nombre = item.NomUsuario;
                    m.PerfilUsuario.Usuario.Clave = item.PassUsiario;

                    return m;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
