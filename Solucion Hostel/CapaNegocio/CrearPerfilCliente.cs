using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;

namespace CapaNegocio
{
    public class CrearPerfilCliente
    {
        public PerfilCliente DatoCliente { get; set; }

        public CrearPerfilCliente()
        {
            Init(); 
        }

        private void Init()
        {
            this.DatoCliente = new PerfilCliente();
        }

        public void LlamarSP()
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CommonBD.Conexion.SP_CREAR_CLIENTE
                ( DatoCliente.RutEmpresa
                , DatoCliente.RazonSocial
                , DatoCliente.Giro
                , DatoCliente.EmailEmpresa
                , DatoCliente.TelefonoEmpresa
                , DatoCliente.Logo
                , DatoCliente.RutPersona
                , DatoCliente.Nombre
                , DatoCliente.Apellido
                , DatoCliente.Nacimiento
                , DatoCliente.EmailPersona
                , DatoCliente.TelofonoPersona
                , DatoCliente.Calle
                , DatoCliente.Numero
                , DatoCliente.Comuna
                , DatoCliente.CodPostal
                , DatoCliente.NombreCiudad
                , DatoCliente.CodPais
                , DatoCliente.Clave
                , p_OUT_CODRET
                , p_OUT_GLSRET
                ) ;
            
            try
            {
                DatoCliente.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                DatoCliente.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                DatoCliente.Retorno.Codigo = 1011;
                DatoCliente.Retorno.Glosa = "Err codret ORACLE";
            }
        }
    }
}
