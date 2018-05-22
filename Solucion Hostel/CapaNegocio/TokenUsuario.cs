using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.IO;

namespace CapaNegocio
{
    public class TokenUsuario
    {
        private static RijndaelManaged _myRijndael;
        private static byte[] _clave;
        private static byte[] _iv;

        private static RijndaelManaged MyRijndael
        {
            get
            {
                if (_myRijndael == null)
                {
                    _myRijndael = new RijndaelManaged();
                }
                return _myRijndael;
            }
        }

        private static byte[] Clave
        {
            get
            {
                if (_clave == null)
                {
                    MyRijndael.GenerateKey();
                    _clave = MyRijndael.Key;
                }
                return _clave;
            }
        }
        private static byte[] IV
        {
            get
            {
                if (_iv == null)
                {
                    MyRijndael.GenerateIV();
                    _iv = MyRijndael.IV;
                }
                return _iv;
            }
        }
        
        public string Codificar(string nombre, string usuario, string perfil)
        {
            try
            {
                string key = "{0}-{1}-{2}-{3}";
                key = string.Format(key, nombre, usuario, perfil, DateTime.Now.Ticks);

                byte[] inputBytes = Encoding.ASCII.GetBytes(key);
                byte[] encripted;

                RijndaelManaged cripto = new RijndaelManaged();
                using (MemoryStream ms = new MemoryStream(inputBytes.Length))
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(Clave, IV), CryptoStreamMode.Write))
                    {
                        objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
                        objCryptoStream.FlushFinalBlock();
                        objCryptoStream.Close();
                    }
                    encripted = ms.ToArray();
                }
                return Convert.ToBase64String(encripted);

            }
            catch (Exception)
            {
                return string.Empty; 
            }
        }

        public bool ValidarPerfil(string token, List<string> perfiles)
        {
            try
            {
                bool result = false;

                byte[] inputBytes = Convert.FromBase64String(token);
                byte[] resultBytes = new byte[inputBytes.Length];
                string textoLimpio = String.Empty;
                RijndaelManaged cripto = new RijndaelManaged();
                using (MemoryStream ms = new MemoryStream(inputBytes))
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(objCryptoStream, true))
                        {
                            textoLimpio = sr.ReadToEnd();
                        }
                    }
                }
                string[] values = textoLimpio.Split('-');

                if (values != null && values.Length == 4)
                {
                    string Tnombre  = values[0];
                    string Tusuario = values[1];
                    string Tperfil  = values[2];
                    long Tticks;
                    if (long.TryParse(values[3], out Tticks))
                    {
                        if (Math.Abs((new DateTime(Tticks) - DateTime.Now).Hours) < 1)
                        {
                            foreach (var item in perfiles)
                            {
                                if(item == Tperfil) {
                                    result = true;
                                    break;
                                }
                            }
                            
                        }
                    }
                }

                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ValidarFechaExpiracion(string token)
        {
            try
            {
                bool result = false;

                byte[] inputBytes = Convert.FromBase64String(token);
                byte[] resultBytes = new byte[inputBytes.Length];
                string textoLimpio = String.Empty;
                RijndaelManaged cripto = new RijndaelManaged();
                using (MemoryStream ms = new MemoryStream(inputBytes))
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(objCryptoStream, true))
                        {
                            textoLimpio = sr.ReadToEnd();
                        }
                    }
                }
                string[] values = textoLimpio.Split('-');

                if (values != null && values.Length == 4)
                {
                    string Tnombre = values[0];
                    string Tusuario = values[1];
                    string Tperfil = values[2];
                    long Tticks;
                    if (long.TryParse(values[3], out Tticks))
                    {
                        if (Math.Abs((new DateTime(Tticks) - DateTime.Now).Hours) < 1)
                        {
                            result = true;
                        }
                    }
                }

                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string LeerPerfil(string token)
        {
            string result = string.Empty;
            try
            {
                byte[] inputBytes = Convert.FromBase64String(token);
                byte[] resultBytes = new byte[inputBytes.Length];
                string textoLimpio = String.Empty;
                RijndaelManaged cripto = new RijndaelManaged();
                using (MemoryStream ms = new MemoryStream(inputBytes))
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(objCryptoStream, true))
                        {
                            textoLimpio = sr.ReadToEnd();
                        }
                    }
                }
                string[] values = textoLimpio.Split('-');

                if (values != null && values.Length == 4)
                {
                    string Tnombre = values[0];
                    string Tusuario = values[1];
                    string Tperfil = values[2];
                    long Tticks;
                    if (long.TryParse(values[3], out Tticks))
                    {
                        if (Math.Abs((new DateTime(Tticks) - DateTime.Now).Hours) < 1)
                        {
                            result = Tperfil;
                        }
                    }
                }

                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}
