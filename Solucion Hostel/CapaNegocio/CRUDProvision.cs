using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDProvision
    {
        public CRUDProvision()
        {

        }
        public ContenedorProvision LlamarSPCrear(ContenedorProvision nProvision)
        {
            if (ValidarPerfilCUD(nProvision.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_PROVISION
                    ( nProvision.Item.RutProveedor
                    , nProvision.Item.CodigoProducto
                    , nProvision.Item.Precio
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    nProvision.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nProvision.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    nProvision.Retorno.Codigo = 1011;
                    nProvision.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                nProvision.Retorno.Codigo = 100;
                nProvision.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nProvision;
        }
        public ContenedorProvision LlamarSPActualizar(ContenedorProvision aProvision)
        {
            if (ValidarPerfilCUD(aProvision.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACTUALIZAR_PROVISION
                    ( aProvision.Item.RutProveedor
                    , aProvision.Item.CodigoProducto
                    , aProvision.Item.Precio
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    aProvision.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    aProvision.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    aProvision.Retorno.Codigo = 1011;
                    aProvision.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                aProvision.Retorno.Codigo = 100;
                aProvision.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return aProvision;
        }

        public ContenedorProvision LlamarSPEliminar(ContenedorProvision eProvision)
        {
            if (ValidarPerfilCUD(eProvision.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ELIMINAR_PROVISION
                    ( eProvision.Item.RutProveedor
                    , eProvision.Item.CodigoProducto
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    eProvision.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    eProvision.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    eProvision.Retorno.Codigo = 1011;
                    eProvision.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                eProvision.Retorno.Codigo = 100;
                eProvision.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return eProvision;
        }

        public ContenedorProvisiones LlamarSPRescatar(string token)
        {
            ContenedorProvisiones LProvisiones = new ContenedorProvisiones();
            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = conex.PROVISION.OrderBy(p => p.RUT_PROVEEDOR).ToList();

                    foreach (var item in collection)
                    {
                        Provision n = new Provision();
                        n.RutProveedor = item.RUT_PROVEEDOR;
                        n.CodigoProducto = item.CODIGO_PRODUCTO;
                        n.Precio = item.PRECIO;
                        LProvisiones.Lista.Add(n);
                    }
                    LProvisiones.Retorno.Codigo = 0;
                    LProvisiones.Retorno.Glosa = "OK";

                }
                catch (Exception)
                {
                    LProvisiones.Retorno.Codigo = 1011;
                    LProvisiones.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LProvisiones.Retorno.Codigo = 100;
                LProvisiones.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LProvisiones;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Administrador");
            Perfiles.Add("Empleado");
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
