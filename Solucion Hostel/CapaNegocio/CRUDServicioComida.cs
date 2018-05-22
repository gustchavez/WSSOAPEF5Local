using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;

namespace CapaNegocio
{
    public class CRUDServicioComida
    {

        public CRUDServicioComida()
        {

        }
        
        public ContenedorServiciosComida LlamarSPRescatar(string token)
        {
            ContenedorServiciosComida LServiciosComida = new ContenedorServiciosComida();

            if (ValidarFecExp(token))
            {
                try
                {
                    var collection = CommonBD.Conexion.SERVICIO_COMIDA.OrderBy(p => p.TIPO).ToList();

                    foreach (var item in collection)
                    {
                        ServicioComida n = new ServicioComida();
                        n.Tipo = item.TIPO;
                        n.Precio = (decimal)item.PRECIO;
                        LServiciosComida.Lista.Add(n);
                    }
                    LServiciosComida.Retorno.Codigo = 0;
                    LServiciosComida.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LServiciosComida.Retorno.Codigo = 1011;
                    LServiciosComida.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                LServiciosComida.Retorno.Codigo = 100;
                LServiciosComida.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LServiciosComida;
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
    }
}
