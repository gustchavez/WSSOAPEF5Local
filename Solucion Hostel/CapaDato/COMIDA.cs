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
    
    public partial class COMIDA
    {
        public System.DateTime RECEPCION { get; set; }
        public string OBSERVACIONES { get; set; }
        public string CONFIRMADA { get; set; }
        public string RUT_PERSONA { get; set; }
        public decimal NUMERO_OC { get; set; }
        public Nullable<decimal> CODIGO_PLATO { get; set; }
        public string TIPO_SERVICIO { get; set; }
    
        public virtual ORDEN_DE_COMPRA ORDEN_DE_COMPRA { get; set; }
        public virtual PERSONA PERSONA { get; set; }
        public virtual PLATO PLATO { get; set; }
    }
}
