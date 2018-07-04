using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDPerfilUsuarioProveedor
    {

        public CRUDPerfilUsuarioProveedor()
        {

        }

        public ContenedorPerfilUsuarioProveedor LlamarSPCrear(ContenedorPerfilUsuarioProveedor nPUP)
        {
            if (ValidarPerfilCUD(nPUP.Retorno.Token))
            {
                CRUDUsuario n = new CRUDUsuario();

                if (n.ExisteNomUsuActivo(nPUP.Item.PerfilUsuario.Usuario.Nombre) == true)
                {
                    nPUP.Retorno.Codigo = 200;
                    nPUP.Retorno.Glosa = "Nombre de Usuario ya existe";
                }
                else {
                    var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                    var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    conex.SP_CREAR_PROVEEDOR
                        ( nPUP.Item.Proveedor.Rut
                        , nPUP.Item.PerfilUsuario.Empresa.RazonSocial
                        , nPUP.Item.PerfilUsuario.Empresa.Rubro
                        , nPUP.Item.PerfilUsuario.Empresa.Email
                        , nPUP.Item.PerfilUsuario.Empresa.Telefono
                        , nPUP.Item.PerfilUsuario.Empresa.Logo
                        , nPUP.Item.PerfilUsuario.Persona.Rut
                        , nPUP.Item.PerfilUsuario.Persona.Nombre
                        , nPUP.Item.PerfilUsuario.Persona.Apellido
                        , nPUP.Item.PerfilUsuario.Persona.FechaNacimiento
                        , nPUP.Item.PerfilUsuario.Persona.Email
                        , nPUP.Item.PerfilUsuario.Persona.Telefono
                        , nPUP.Item.PerfilUsuario.Direccion.Calle
                        , nPUP.Item.PerfilUsuario.Direccion.Numero
                        , nPUP.Item.PerfilUsuario.Direccion.Comuna
                        , nPUP.Item.PerfilUsuario.Direccion.CodPostal
                        , nPUP.Item.PerfilUsuario.Direccion.NombreCiudad
                        , nPUP.Item.PerfilUsuario.Direccion.CodPais
                        , nPUP.Item.PerfilUsuario.Usuario.Nombre
                        , nPUP.Item.PerfilUsuario.Usuario.Clave
                        , p_OUT_CODRET
                        , p_OUT_GLSRET
                        );

                    try
                    {
                        nPUP.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                        nPUP.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                    }
                    catch (Exception)
                    {
                        nPUP.Retorno.Codigo = 1011;
                        nPUP.Retorno.Glosa = "Err codret ORACLE";
                    }
                }
            } else {
                nPUP.Retorno.Codigo = 100;
                nPUP.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nPUP;
        }
        
        public ContenedorPerfilUsuarioProveedor LlamarSPActualizar(ContenedorPerfilUsuarioProveedor aPUP)
        {
            if (ValidarPerfilCUD(aPUP.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACTUALIZAR_PROVEEDOR
                    ( aPUP.Item.Proveedor.Rut
                    , aPUP.Item.PerfilUsuario.Empresa.RazonSocial
                    , aPUP.Item.PerfilUsuario.Empresa.Rubro
                    , aPUP.Item.PerfilUsuario.Empresa.Email
                    , aPUP.Item.PerfilUsuario.Empresa.Telefono
                    , aPUP.Item.PerfilUsuario.Empresa.Logo
                    , aPUP.Item.PerfilUsuario.Persona.Rut
                    , aPUP.Item.PerfilUsuario.Persona.Nombre
                    , aPUP.Item.PerfilUsuario.Persona.Apellido
                    , aPUP.Item.PerfilUsuario.Persona.FechaNacimiento
                    , aPUP.Item.PerfilUsuario.Persona.Email
                    , aPUP.Item.PerfilUsuario.Persona.Telefono
                    , aPUP.Item.PerfilUsuario.Direccion.Calle
                    , aPUP.Item.PerfilUsuario.Direccion.Numero
                    , aPUP.Item.PerfilUsuario.Direccion.Comuna
                    , aPUP.Item.PerfilUsuario.Direccion.CodPostal
                    , aPUP.Item.PerfilUsuario.Direccion.NombreCiudad
                    , aPUP.Item.PerfilUsuario.Direccion.CodPais
                    , aPUP.Item.PerfilUsuario.Usuario.Id
                    , aPUP.Item.PerfilUsuario.Usuario.Clave
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    aPUP.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    aPUP.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    aPUP.Retorno.Codigo = 1011;
                    aPUP.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                aPUP.Retorno.Codigo = 100;
                aPUP.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return aPUP;
        }

        public ContenedorPerfilUsuarioProveedores LlamarSPRescatar(string token)
        {
            ContenedorPerfilUsuarioProveedores LPerfilUsuarioProveedores = new ContenedorPerfilUsuarioProveedores();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from prov in conex.PROVEEDOR
                                      join emp in conex.EMPRESA on prov.RUT equals emp.RUT
                                      join dir in conex.DIRECCION on prov.RUT equals dir.RUT_EMPRESA
                                      join per in conex.PERSONA on dir.RUT_PERSONA equals per.RUT
                                      join usu in conex.USUARIO on per.RUT equals usu.RUT_PERSONA
                                      orderby emp.RAZON_SOCIAL
                                      select new
                                      {
                                          RutProveedor = prov.RUT,
                                          RazonSocial = emp.RAZON_SOCIAL,
                                          Rubro = emp.RUBRO,
                                          MailEmpresa = emp.EMAIL,
                                          TelefonoEmp = emp.TELEFONO,
                                          LogoEmp = emp.LOGO,
                                          RutPersona = per.RUT,
                                          NombrePer = per.NOMBRE,
                                          ApellidoPer = per.APELLIDO,
                                          FecNacPer = per.NACIMIENTO,
                                          MailPer = per.EMAIL,
                                          TelefonoPer = per.TELEFONO,
                                          CalleDirecc = dir.CALLE,
                                          NumeroDir = dir.NUMERO,
                                          ComunaDir = dir.COMUNA,
                                          CodPostalDir = dir.COD_POSTAL,
                                          NomCiudadDir = dir.NOMBRE_CIUDAD,
                                          PaisDirecc = dir.COD_PAIS,
                                          NomUsuario = usu.NOMBRE,
                                          PassUsiario = usu.CLAVE
                                      }
                            ).ToList();

                    foreach (var item in collection)
                    {
                        PerfilUsuarioProveedor m = new PerfilUsuarioProveedor();
                        //
                        m.Proveedor.Rut                         = item.RutProveedor;
                        m.PerfilUsuario.Empresa.RazonSocial     = item.RazonSocial;
                        m.PerfilUsuario.Empresa.Rubro           = item.Rubro;
                        m.PerfilUsuario.Empresa.Email           = item.MailEmpresa;
                        m.PerfilUsuario.Empresa.Telefono        = item.TelefonoEmp;
                        m.PerfilUsuario.Empresa.Logo            = item.LogoEmp;
                        //
                        m.PerfilUsuario.Persona.Rut             = item.RutPersona;
                        m.PerfilUsuario.Persona.Nombre          = item.NombrePer;
                        m.PerfilUsuario.Persona.Apellido        = item.ApellidoPer;
                        m.PerfilUsuario.Persona.FechaNacimiento = item.FecNacPer;
                        m.PerfilUsuario.Persona.Email           = item.MailPer;
                        m.PerfilUsuario.Persona.Telefono        = item.TelefonoPer;
                        //
                        m.PerfilUsuario.Direccion.Calle         = item.CalleDirecc;
                        m.PerfilUsuario.Direccion.Numero        = item.NumeroDir;
                        m.PerfilUsuario.Direccion.Comuna        = item.ComunaDir;
                        m.PerfilUsuario.Direccion.CodPostal     = item.CodPostalDir;
                        m.PerfilUsuario.Direccion.NombreCiudad  = item.NomCiudadDir;
                        m.PerfilUsuario.Direccion.CodPais       = (int)item.PaisDirecc;
                        //
                        m.PerfilUsuario.Usuario.Nombre          = item.NomUsuario;
                        m.PerfilUsuario.Usuario.Clave           = item.PassUsiario;
                        //
                        LPerfilUsuarioProveedores.Lista.Add(m);
                        
                    }
                    LPerfilUsuarioProveedores.Retorno.Codigo = 0;
                    LPerfilUsuarioProveedores.Retorno.Glosa = "OK";

                }
                catch (Exception)
                {
                    LPerfilUsuarioProveedores.Retorno.Codigo = 1011;
                    LPerfilUsuarioProveedores.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                LPerfilUsuarioProveedores.Retorno.Codigo = 100;
                LPerfilUsuarioProveedores.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LPerfilUsuarioProveedores;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Proveedor");
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
        public PerfilUsuarioProveedor buscarProveedorPorRut(String rut, String token)
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
                                    RutCliente             = cli.RUT,
                                    RazonSocial            = emp.RAZON_SOCIAL,
                                    MailEmpresa            = emp.EMAIL,
                                    TelefonoEmp            = emp.TELEFONO,
                                    Rubro                  = emp.RUBRO,
                                    Logo                   = emp.RUBRO,
                                    NomCiudadDir           = dir.NOMBRE_CIUDAD,
                                    CalleDirecc            = dir.CALLE,
                                    CodPais                = dir.COD_PAIS,
                                    CodPostal              = dir.COD_POSTAL,
                                    Comuna                 = dir.COMUNA,
                                    Numero                 = dir.NUMERO,
                                    NomUsuario             = usu.NOMBRE,
                                    PassUsiario            = usu.CLAVE,
                                    RutPersona             = per.RUT,
                                    NombrePersona          = per.NOMBRE,
                                    ApellidoPersona        = per.APELLIDO,
                                    FechaNacimientoPersona = per.NACIMIENTO,
                                    EmailPersona           = per.EMAIL,
                                    TelefonoPersona        = per.TELEFONO
                                }
                            ).SingleOrDefault();

                    PerfilUsuarioProveedor m = new PerfilUsuarioProveedor();
                    //
                    m.Proveedor.Rut = item.RutCliente;
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
