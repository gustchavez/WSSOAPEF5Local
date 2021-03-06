﻿using System;
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
            CRUDUsuario n = new CRUDUsuario();

            if (n.ExisteNomUsuActivo(nPUC.Item.PerfilUsuario.Usuario.Nombre) == true)
            {
                nPUC.Retorno.Codigo = 200;
                nPUC.Retorno.Glosa = "Nombre de Usuario ya existe";
            }
            else {
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
                    , nPUC.Item.PerfilUsuario.Usuario.Nombre
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
            }
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
                    , aPUC.Item.PerfilUsuario.Usuario.Nombre
                    , aPUC.Item.PerfilUsuario.Usuario.Clave
                    , aPUC.Item.PerfilUsuario.Usuario.Estado
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
                                          RutCliente   = cli.RUT,
                                          RazonSocial  = emp.RAZON_SOCIAL,
                                          Rubro        = emp.RUBRO,
                                          MailEmpresa  = emp.EMAIL,
                                          TelefonoEmp  = emp.TELEFONO,
                                          LogoEmp      = emp.LOGO,
                                          RutPersona   = per.RUT,
                                          NombrePer    = per.NOMBRE,
                                          ApellidoPer  = per.APELLIDO,
                                          FecNacPer    = per.NACIMIENTO,
                                          MailPer      = per.EMAIL,
                                          TelefonoPer  = per.TELEFONO,
                                          CalleDirecc  = dir.CALLE,
                                          NumeroDir    = dir.NUMERO,
                                          ComunaDir    = dir.COMUNA,
                                          CodPostalDir = dir.COD_POSTAL,
                                          NomCiudadDir = dir.NOMBRE_CIUDAD,
                                          PaisDirecc   = dir.COD_PAIS,
                                          IdUsuario    = usu.ID,
                                          NomUsuario   = usu.NOMBRE,
                                          PassUsiario  = usu.CLAVE,
                                          EstUsuario   = usu.ESTADO
                                      }
                            ).ToList();

                    foreach (var item in collection)
                    {
                        PerfilUsuarioCliente m = new PerfilUsuarioCliente();
                        //
                        m.Cliente.Rut                           = item.RutCliente;
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
                        m.PerfilUsuario.Usuario.Id              = item.IdUsuario;
                        m.PerfilUsuario.Usuario.Nombre          = item.NomUsuario;
                        m.PerfilUsuario.Usuario.Clave           = item.PassUsiario;
                        m.PerfilUsuario.Usuario.Estado          = item.EstUsuario;
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

            Perfiles.Add("Cliente");
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
        public ContenedorPerfilUsuarioCliente LlamarSPRescatarXRut(String rut, String token)
        {
            ContenedorPerfilUsuarioCliente cPUC = new ContenedorPerfilUsuarioCliente();

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
                                      where cli.RUT == rut
                                      select new
                                      {
                                          RutCliente   = cli.RUT,
                                          RazonSocial  = emp.RAZON_SOCIAL,
                                          Rubro        = emp.RUBRO,
                                          MailEmpresa  = emp.EMAIL,
                                          TelefonoEmp  = emp.TELEFONO,
                                          LogoEmp      = emp.LOGO,
                                          RutPersona   = per.RUT,
                                          NombrePer    = per.NOMBRE,
                                          ApellidoPer  = per.APELLIDO,
                                          FecNacPer    = per.NACIMIENTO,
                                          MailPer      = per.EMAIL,
                                          TelefonoPer  = per.TELEFONO,
                                          CalleDirecc  = dir.CALLE,
                                          NumeroDir    = dir.NUMERO,
                                          ComunaDir    = dir.COMUNA,
                                          CodPostalDir = dir.COD_POSTAL,
                                          NomCiudadDir = dir.NOMBRE_CIUDAD,
                                          PaisDirecc   = dir.COD_PAIS,
                                          IdUsuario    = usu.ID,
                                          NomUsuario   = usu.NOMBRE,
                                          PassUsiario  = usu.CLAVE,
                                          EstUsuario   = usu.ESTADO
                                      }
                            ).SingleOrDefault();

                    if (item != null)
                    {
                        PerfilUsuarioCliente m = new PerfilUsuarioCliente();
                        //
                        //
                        m.Cliente.Rut                           = item.RutCliente;
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
                        m.PerfilUsuario.Usuario.Id              = item.IdUsuario;
                        m.PerfilUsuario.Usuario.Nombre          = item.NomUsuario;
                        m.PerfilUsuario.Usuario.Clave           = item.PassUsiario;
                        m.PerfilUsuario.Usuario.Estado          = item.EstUsuario;

                        cPUC.Item = m;
                        cPUC.Retorno.Codigo = 0;
                        cPUC.Retorno.Glosa = "OK";
                    }
                    else {
                        cPUC.Retorno.Codigo = 200;
                        cPUC.Retorno.Glosa = "Aviso, dato no encontrado";
                    }
                }
                catch (Exception)
                {
                    cPUC.Retorno.Codigo = 1011;
                    cPUC.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                cPUC.Retorno.Codigo = 100;
                cPUC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return cPUC;
        }
    }
}
