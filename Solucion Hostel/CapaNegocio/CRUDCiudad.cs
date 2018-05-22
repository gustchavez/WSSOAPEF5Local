using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;

namespace CapaNegocio
{
    public class CRUDCiudad
    {
        public CRUDCiudad()
        {

        }
        
        public ContenedorCiudades LlamarSPRescatar(string token)
        {
            ContenedorCiudades LCiudades = new ContenedorCiudades();

            if (ValidarFecExp(token))
            {
                try
                {
                    var collection = CommonBD.Conexion.CIUDAD.OrderBy(p => p.NOMBRE).ToList();

                    foreach (var item in collection)
                    {
                        Ciudad n = new Ciudad();
                        n.Nombre = item.NOMBRE;
                        n.CodArea = item.COD_AREA;
                        n.CodPais = item.COD_PAIS;
                        LCiudades.Lista.Add(n);
                    }
                    LCiudades.Retorno.Codigo = 0;
                    LCiudades.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LCiudades.Retorno.Codigo = 1011;
                    LCiudades.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                LCiudades.Retorno.Codigo = 100;
                LCiudades.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LCiudades;
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