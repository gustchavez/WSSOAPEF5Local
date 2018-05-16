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

            return nPUP;
        }
    }
}
