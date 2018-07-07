using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDServicioComida
    {

        public CRUDServicioComida()
        {

        }
        public ContenedorServicioComida LlamarSPActualizar(ContenedorServicioComida aServicioComida)
        {
            if (ValidarFecExp(aServicioComida.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACTUALIZAR_SERVICIO_COMIDA
                    ( aServicioComida.Item.Tipo
                    , aServicioComida.Item.Precio
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    aServicioComida.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    aServicioComida.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    aServicioComida.Retorno.Codigo = 1011;
                    aServicioComida.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                aServicioComida.Retorno.Codigo = 100;
                aServicioComida.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return aServicioComida;
        }
        public ContenedorServiciosComida LlamarSPRescatar(string token)
        {
            ContenedorServiciosComida LServiciosComida = new ContenedorServiciosComida();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = conex.SERVICIO_COMIDA.OrderBy(p => p.TIPO).ToList();

                    foreach (var item in collection)
                    {
                        ServicioComida n = new ServicioComida();
                        n.Tipo = item.TIPO;
                        n.Precio = (int)item.PRECIO;
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
