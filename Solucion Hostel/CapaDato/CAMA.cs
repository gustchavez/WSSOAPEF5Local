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
    
    public partial class CAMA
    {
        public CAMA()
        {
            this.ALOJAMIENTO = new HashSet<ALOJAMIENTO>();
        }
    
        public decimal CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string DISPONIBLE { get; set; }
        public short CODIGO_HABITACION { get; set; }
    
        public virtual HABITACION HABITACION { get; set; }
        public virtual ICollection<ALOJAMIENTO> ALOJAMIENTO { get; set; }
    }
}
