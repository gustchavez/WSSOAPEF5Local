using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDPlato
    {
        public CRUDPlato()
        {

        }

        public ContenedorPlato LlamarSPCrear(ContenedorPlato nPlato)
        {
            if (ValidarPerfilCUD(nPlato.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
                var p_OUT_CODIGO = new ObjectParameter("P_OUT_CODIGO", typeof(decimal));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_PLATO
                    ( nPlato.Item.Nombre
                    , nPlato.Item.Descripcion
                    , nPlato.Item.Disponible
                    , nPlato.Item.TipoServicio
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    , p_OUT_CODIGO
                    );

                try
                {
                    nPlato.Item.Codigo = decimal.Parse(p_OUT_CODIGO.Value.ToString());
                    nPlato.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nPlato.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    nPlato.Item.Codigo = 0;
                    nPlato.Retorno.Codigo = 1011;
                    nPlato.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                nPlato.Retorno.Codigo = 100;
                nPlato.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nPlato;
        }
        public ContenedorPlato LlamarSPActualizar(ContenedorPlato aPlato)
        {
            if (ValidarPerfilCUD(aPlato.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACTUALIZAR_PLATO
                    ( aPlato.Item.Codigo
                    , aPlato.Item.Nombre
                    , aPlato.Item.Descripcion
                    , aPlato.Item.Disponible
                    , aPlato.Item.TipoServicio
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    aPlato.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    aPlato.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    aPlato.Retorno.Codigo = 1011;
                    aPlato.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                aPlato.Retorno.Codigo = 100;
                aPlato.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return aPlato;
        }

        public ContenedorPlato LlamarSPEliminar(ContenedorPlato ePlato)
        {
            if (ValidarPerfilCUD(ePlato.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ELIMINAR_PLATO
                    (ePlato.Item.Codigo
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    ePlato.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    ePlato.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    ePlato.Retorno.Codigo = 1011;
                    ePlato.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                ePlato.Retorno.Codigo = 100;
                ePlato.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return ePlato;
        }

        public ContenedorPlatos LlamarSPRescatar(string token)
        {
            ContenedorPlatos LPlatos = new ContenedorPlatos();
            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = conex.PLATO.OrderBy(p => p.NOMBRE).ToList();

                    foreach (var item in collection)
                    {
                        Plato n = new Plato();
                        n.Codigo = item.CODIGO;
                        n.Nombre = item.NOMBRE;
                        n.Descripcion = item.DESCRIPCION;
                        n.Disponible = item.DISPONIBLE;
                        n.TipoServicio = item.SERVICIO_TIPO;
                        LPlatos.Lista.Add(n);
                    }
                    LPlatos.Retorno.Codigo = 0;
                    LPlatos.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LPlatos.Retorno.Codigo = 1011;
                    LPlatos.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                LPlatos.Retorno.Codigo = 100;
                LPlatos.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LPlatos;
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
