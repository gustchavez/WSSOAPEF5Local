using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDCama
    {
        public CRUDCama()
        {

        }

        public ContenedorCama LlamarSPCrear(ContenedorCama nCama)
        {
            if (ValidarPerfilCUD(nCama.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
                var p_OUT_CODIGO = new ObjectParameter("P_OUT_CODIGO", typeof(decimal));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_CAMA
                    (nCama.Item.Descripcion
                    , nCama.Item.Disponible
                    , nCama.Item.CodHabitacion
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    , p_OUT_CODIGO
                    );

                try
                {
                    nCama.Item.Codigo = int.Parse(p_OUT_CODIGO.Value.ToString());
                    nCama.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nCama.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    nCama.Item.Codigo = 0;
                    nCama.Retorno.Codigo = 1011;
                    nCama.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                nCama.Retorno.Codigo = 100;
                nCama.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nCama;
        }
        public ContenedorCama LlamarSPActualizar(ContenedorCama aCama)
        {
            if (ValidarPerfilCUD(aCama.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACTUALIZAR_CAMA
                    (aCama.Item.Codigo
                    , aCama.Item.Descripcion
                    , aCama.Item.Disponible
                    , aCama.Item.CodHabitacion
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    aCama.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    aCama.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    aCama.Retorno.Codigo = 1011;
                    aCama.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                aCama.Retorno.Codigo = 100;
                aCama.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return aCama;
        }

        public ContenedorCama LlamarSPEliminar(ContenedorCama eCama)
        {
            if (ValidarPerfilCUD(eCama.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ELIMINAR_CAMA
                    (eCama.Item.Codigo
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    eCama.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    eCama.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    eCama.Retorno.Codigo = 1011;
                    eCama.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                eCama.Retorno.Codigo = 100;
                eCama.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return eCama;
        }

        public ContenedorCamas LlamarSPRescatar(string token)
        {
            ContenedorCamas LCamas = new ContenedorCamas();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = conex.CAMA.OrderBy(p => p.CODIGO_HABITACION).ToList();

                    foreach (var item in collection)
                    {
                        Cama n = new Cama();
                        n.Codigo = item.CODIGO;
                        n.Descripcion = item.DESCRIPCION;
                        n.Disponible = item.DISPONIBLE;
                        n.CodHabitacion = item.CODIGO_HABITACION;
                        LCamas.Lista.Add(n);
                    }

                    LCamas.Retorno.Codigo = 0;
                    LCamas.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LCamas.Retorno.Codigo = 1011;
                    LCamas.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                LCamas.Retorno.Codigo = 100;
                LCamas.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LCamas;
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
