//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDato
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROVISION
    {
        public string RUT_PROVEEDOR { get; set; }
        public short CODIGO_PRODUCTO { get; set; }
        public int PRECIO { get; set; }



        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
