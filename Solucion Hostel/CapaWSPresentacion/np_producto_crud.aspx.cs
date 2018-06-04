﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaObjeto;

namespace CapaWSPresentacion
{
    public partial class np_producto_crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Empleado"))
                {
                    if (!IsPostBack)
                    {
                        CargarGridView();
                    }
                } else {
                    Session["TokenUsuario"] = null;
                    Response.Redirect("np_ingreso.aspx");
                    }
                }
            catch (Exception)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("np_ingreso.aspx");
            }
        }

        private void CargarGridView()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProductos n = new ContenedorProductos();

            n = x.ProductoRescatar(Session["TokenUsuario"].ToString());

            gwListaProductos.DataSource = null;
            gwListaProductos.DataSource = n.Lista;
            gwListaProductos.DataBind();
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProducto nProducto = new ContenedorProducto();

            nProducto.Item.Descripcion  = txtDescripcion.Text;
            nProducto.Item.Stock        = decimal.Parse(txtStock.Text);
            nProducto.Item.StockCritico = decimal.Parse(txtStockCritico.Text);
            nProducto.Retorno.Token = Session["TokenUsuario"].ToString();

            nProducto = x.ProductoCrear(nProducto);

            txtCodigo.Text = nProducto.Item.Codigo.ToString();
            txtCodigoRetorno.Text = nProducto.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text  = nProducto.Retorno.Glosa;

            CargarGridView();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProducto aProducto = new ContenedorProducto();

            aProducto.Item.Codigo       = decimal.Parse(txtCodigo.Text);
            aProducto.Item.Descripcion  = txtDescripcion.Text;
            aProducto.Item.Stock        = decimal.Parse(txtStock.Text);
            aProducto.Item.StockCritico = decimal.Parse(txtStockCritico.Text);
            aProducto.Retorno.Token = Session["TokenUsuario"].ToString();

            aProducto = x.ProductoActualizar(aProducto);

            txtCodigoRetorno.Text = aProducto.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text  = aProducto.Retorno.Glosa;

            CargarGridView();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProducto eProducto = new ContenedorProducto();

            eProducto.Item.Codigo = decimal.Parse(txtCodigo.Text);
            eProducto.Retorno.Token = Session["TokenUsuario"].ToString();

            eProducto = x.ProductoEliminar(eProducto);

            txtCodigoRetorno.Text = eProducto.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = eProducto.Retorno.Glosa;

            CargarGridView();
        }

    }
}