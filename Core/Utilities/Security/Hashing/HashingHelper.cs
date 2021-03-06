using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //Hash oluşturma
        // Out=> bu method bir void geri birşey döndürmüyor. AMAAA out kullanırsak geri döndürmüş oluyoruz.
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) 
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        // Password Hashini doğrulama
        // yani kullanıcının gönderdiği şifre hashi ile veritabanındaki hash uyusuyor mu
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool VerifyPasswordHash(string password, object passwordHash, object passwordSalt)
        {
            throw new NotImplementedException();
        }
    }
}
