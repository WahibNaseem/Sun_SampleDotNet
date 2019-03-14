using System.Security.Cryptography;
using System.Threading.Tasks;
using SampleDotNet.Core.Domain;

namespace SampleDotNet.Services.Authentication
{
    public class AuthRepository : IAuthRepository
    {
        Task<User> IAuthRepository.Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        Task<User> IAuthRepository.Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        Task<bool> IAuthRepository.UserExists(string username)
        {
            throw new System.NotImplementedException();
        }

       /*
          This Method will create the PasswordHash through the given password
        */
        private void CreatePasswordHash(string password , out byte[] passwordHash , out byte[] passwordSalt)
        {
           using(var hmac = new System.Security.Cryptography.HMACSHA512())
           {
               passwordSalt = hmac.Key;
               passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
           }
        }
        
        /*
           This Method will verify the password from the passwordSalt as Key
        */
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512(passwordSalt))
            {
                //Get the computedHash password of the current Password
                 var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                 for(int i = 0 ; i < computedHash.Length; i++)
                 {
                     //Each byte of computedHash password does compare with passwordHash from the Database
                     if(computedHash[i] != passwordHash[i]) return false;
                 }
            }

            return true;
        }
    }
}