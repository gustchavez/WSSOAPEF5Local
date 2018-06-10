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
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_EMPLEADO
                    (nPUC.Item.Persona.Rut
                    , nPUC.Item.Persona.Nombre
                    , nPUC.Item.Persona.Apellido
                    , nPUC.Item.Persona.FechaNacimiento
                    , nPUC.Item.Persona.Email
                    , nPUC.Item.Persona.Telefono
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
        public PerfilUsuarioEmpleado buscarEmpleadoPorRut(String rut, String token)
        {
            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
                    var usuario = conex.USUARIO.SingleOrDefault(b => b.RUT_PERSONA == rut);
                    var persona = conex.PERSONA.SingleOrDefault(b => b.RUT == rut);
                    PerfilUsuarioEmpleado pAdmin = new PerfilUsuarioEmpleado();
                    pAdmin.Persona.Nombre = persona.NOMBRE;
                    pAdmin.Persona.Apellido = persona.APELLIDO;
                    pAdmin.Persona.Email = persona.EMAIL;
                    pAdmin.Persona.FechaNacimiento = persona.NACIMIENTO;
                    pAdmin.Persona.Rut = persona.RUT;
                    pAdmin.Persona.Telefono = persona.TELEFONO;
                    pAdmin.Usuario.Estado = usuario.ESTADO;
                    pAdmin.Usuario.Clave = usuario.CLAVE;
                    pAdmin.Usuario.Id = usuario.ID;
                    pAdmin.Usuario.Nombre = usuario.NOMBRE;
                    pAdmin.Usuario.Perfil = usuario.PERFIL;
                    pAdmin.Usuario.RutPersona = usuario.RUT_PERSONA;
                    return pAdmin;
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
