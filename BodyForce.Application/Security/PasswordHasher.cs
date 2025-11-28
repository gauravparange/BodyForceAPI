using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI.Application.Security
{
    public static class PasswordHasher
    {
        public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;

                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                passwordHash = hmac.ComputeHash(passwordBytes);
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using(var hmac = new HMACSHA512(storedSalt))
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                byte[] computeHash = hmac.ComputeHash(passwordBytes);

                bool hashesMatch = computeHash.SequenceEqual(storedHash);

                return hashesMatch;
            }
        }
    }
}
