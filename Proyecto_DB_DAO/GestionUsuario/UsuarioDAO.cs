using proyecto_Db_EDM.GestionUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DB_DAO.GestionUsuario
{
  public  class UsuarioDAO
    {
        private AccesoContainer db = new AccesoContainer();
        private string ClaveMaestra = "ProgDB2023";
        public bool Agregar(string pUsuario, string pClave)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.NombreDeUsuario = Encriptar(pUsuario.Trim());
            oUsuario.ClaveDeUsuario = Encriptar(pClave.Trim());
            db.Usuario.Add(oUsuario);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public int Validar(string pUsuario, string pClave)
        {
            string usua = Encriptar(pUsuario.Trim());
            string clv = Encriptar(pClave.Trim());
            Usuario oUsua = db.Usuario.DefaultIfEmpty(null).FirstOrDefault(u => u.NombreDeUsuario.Trim() == usua && u.ClaveDeUsuario.Trim() == clv);
            return (oUsua != null ? oUsua.Id : 0);
        }
        private string Encriptar(string  cadena)
        {
            byte[] arrMaestro;
            byte[] arrCifrar = UTF8Encoding.UTF8.GetBytes(cadena);
            MD5CryptoServiceProvider varMd5 = new MD5CryptoServiceProvider();
            arrMaestro = varMd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(ClaveMaestra));
            varMd5.Clear();
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = arrMaestro;
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cryptoTransform = tripleDES.CreateEncryptor();
            byte[] Resutaldo = cryptoTransform.TransformFinalBlock(arrCifrar, 0, arrCifrar.Length);
            tripleDES.Clear();
            return (Convert.ToBase64String(Resutaldo, 0, Resutaldo.Length));

        }
        private  string Desencriptar(string textEncriptado)
        {
            byte[] arrClave;
            byte[] arrDesifrar = Convert.FromBase64String(textEncriptado);
            MD5CryptoServiceProvider varMd5 = new MD5CryptoServiceProvider();
            arrClave = varMd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(ClaveMaestra));
            varMd5.Clear();
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = arrClave;
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform transform = tDes.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(arrDesifrar,0,arrDesifrar.Length);
            tDes.Clear();
            return (UTF8Encoding.UTF8.GetString(resultado));
        }
        public List<ListaUsuario> Listar()
        {
            var q = (from u in db.Usuario
                     select new ListaUsuario { NombreDeUsuario = u.NombreDeUsuario, ClaveDeUsuario=u.ClaveDeUsuario,Id=u.Id}
                     ).ToList();
            return q;
        }
        public bool VerificarPermiso(int IdUsuario, int IdFuncion)
        {
            var q = (from f in db.FuncionDeAcceso
                     join fu in db.FuncionAsignada
                     on f.Id equals fu.FuncionDeAccesoId
                     where fu.UsuarioId == IdUsuario && fu.FuncionDeAccesoId == IdFuncion && fu.FechaVencimiento >= DateTime.Now
                     select f).ToList();
            return q.Count > 0 ? true : false;
        }
    }
}
