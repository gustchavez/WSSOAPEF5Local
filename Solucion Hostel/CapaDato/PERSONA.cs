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
    
    public partial class PERSONA
    {
        public PERSONA()
        {
            this.ALOJAMIENTO = new HashSet<ALOJAMIENTO>();
            this.COMIDA = new HashSet<COMIDA>();
            this.DIRECCION = new HashSet<DIRECCION>();
            this.USUARIO = new HashSet<USUARIO>();
            this.EMPRESA = new HashSet<EMPRESA>();
            this.PAIS = new HashSet<PAIS>();
        }
    
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public System.DateTime NACIMIENTO { get; set; }
        public string EMAIL { get; set; }
        public Nullable<long> TELEFONO { get; set; }
    
        public virtual ICollection<ALOJAMIENTO> ALOJAMIENTO { get; set; }
        public virtual ICollection<COMIDA> COMIDA { get; set; }
        public virtual ICollection<DIRECCION> DIRECCION { get; set; }
        public virtual ICollection<USUARIO> USUARIO { get; set; }
        public virtual ICollection<EMPRESA> EMPRESA { get; set; }
        public virtual ICollection<PAIS> PAIS { get; set; }
    }
}
