using AXT.Model;
using AXT.SQLDBDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.PublicSiteController
{
    public class CreateUserController : _BaseController
    {
        // Constructor
        public CreateUserController(string connectionString) : base(connectionString) { }

        // Method to insert 'newUser'
        public void InsertUser(UserModel newUser)
        {
            // Calls the UserDataAccess 'InsertUser' function.
            UserDataAccess da = new UserDataAccess(SqlConConnectionString);

            da.InsertUser(newUser);
        }
        // The input is password that you want, in clear-text. The output from this function is the encrypted version of that password
        public string EncryptPassword(string clearText)
        {
            string encryptedText = "";


            string EncryptionKey = "Xavier";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (System.Security.Cryptography.Aes encryptor = System.Security.Cryptography.Aes.Create())
            {
                System.Security.Cryptography.Rfc2898DeriveBytes pdb = new System.Security.Cryptography.Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    using (System.Security.Cryptography.CryptoStream cs = new System.Security.Cryptography.CryptoStream(ms, encryptor.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptedText = Convert.ToBase64String(ms.ToArray());
                }
            }


            return encryptedText;
        }
    }

}
