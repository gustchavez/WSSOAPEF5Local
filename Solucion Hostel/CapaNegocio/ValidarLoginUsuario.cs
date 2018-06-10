using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;

namespace CapaNegocio
{
    public class ValidarLoginUsuario
    {
        public Sesion DatosLogin { get; set; }

        public ValidarLoginUsuario()
        {
            Init();
        }

        private void Init()
        {
            this.DatosLogin = new Sesion();
        }

        public void LlamarSP()
        {
            var p_OUT_PERFIL       = new ObjectParameter("P_OUT_PERFIL", typeof(string));
            var p_OUT_RUT_EMPRESA  = new ObjectParameter("P_OUT_RUT_EMPRESA", typeof(string));
            var p_OUT_RAZON_SOCIAL = new ObjectParameter("P_OUT_RAZON_SOCIAL", typeof(string));
            var p_OUT_RUT_PERSONA  = new ObjectParameter("P_OUT_RUT_PERSONA", typeof(string));
            var p_OUT_NOMBRE       = new ObjectParameter("P_OUT_NOMBRE", typeof(string));
            var p_OUT_APELLIDO     = new ObjectParameter("P_OUT_APELLIDO", typeof(string));
            var p_OUT_CODRET       = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET       = new ObjectParameter("P_OUT_GLSRET", typeof(string));
            //
            CommonBD.Conexion.SP_VALIDAR_LOGIN
                ( DatosLogin.Usuario
                , DatosLogin.Clave
                , p_OUT_PERFIL
                , p_OUT_RUT_EMPRESA
                , p_OUT_RAZON_SOCIAL
                , p_OUT_RUT_PERSONA
                , p_OUT_NOMBRE
                , p_OUT_APELLIDO
                , p_OUT_CODRET
                , p_OUT_GLSRET
                ) ;
            //
            DatosLogin.Perfil      = p_OUT_PERFIL.Value.ToString();
            DatosLogin.RutEmpresa  = p_OUT_RUT_EMPRESA.Value.ToString();
            DatosLogin.RazonSocial = p_OUT_RAZON_SOCIAL.Value.ToString();
            DatosLogin.RutPersona  = p_OUT_RUT_PERSONA.Value.ToString();
            DatosLogin.Nombre      = p_OUT_NOMBRE.Value.ToString();
            DatosLogin.Apellido    = p_OUT_APELLIDO.Value.ToString();
            //
            try
            {
                TokenUsuario x = new TokenUsuario();
                DatosLogin.Retorno.Token = x.Codificar(DatosLogin.Nombre, DatosLogin.Usuario, DatosLogin.Perfil);
                DatosLogin.Clave = string.Empty;
                DatosLogin.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                DatosLogin.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                DatosLogin.Retorno.Codigo = 1011;
                DatosLogin.Retorno.Glosa = "Err codret ORACLE";
            }
        }
    }
}
