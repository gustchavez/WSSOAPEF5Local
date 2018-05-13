using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class PerfilCliente
    {
        public string RutEmpresa  { get; set; }
        public string RazonSocial { get; set; }
        public string Giro        { get; set; }
        public string EmailEmpresa    { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string Logo         { get; set; }
        public string RutPersona  { get; set; }
        public string Nombre       { get; set; }
        public string Apellido     { get; set; }
        public DateTime Nacimiento   { get; set; }
        public string EmailPersona    { get; set; }
        public string TelofonoPersona { get; set; }
        public string Calle        { get; set; }
        public decimal Numero       { get; set; }
        public string Comuna       { get; set; }
        public string CodPostal   { get; set; }
        public string NombreCiudad { get; set; }
        public decimal CodPais     { get; set; }
        public string Clave        { get; set; }

        public Respuesta Retorno { get; set; }

        public PerfilCliente()
        {
            Init();
        }

        private void Init()
        {
            this.RutEmpresa = string.Empty;
            this.RazonSocial = string.Empty;
            this.Giro = string.Empty;
            this.EmailEmpresa = string.Empty;
            this.TelefonoEmpresa = string.Empty;
            this.Logo = string.Empty;
            this.RutPersona = string.Empty;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Nacimiento = DateTime.MinValue;
            this.EmailPersona = string.Empty;
            this.TelofonoPersona = string.Empty;
            this.Calle = string.Empty;
            this.Numero = decimal.MinValue;
            this.Comuna = string.Empty;
            this.CodPostal = string.Empty;
            this.NombreCiudad = string.Empty;
            this.CodPais = decimal.MinValue;
            this.Clave = string.Empty;

            this.Retorno = new Respuesta();
        }
    }
}
