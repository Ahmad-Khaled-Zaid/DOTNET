using System.Security.Cryptography;
using System.Text;
namespace Registration.Tools{
    public class password{
        public static string hashPassword(string password){
            var sha=SHA256.Create();
            var ByteArr=Encoding.Default.GetBytes(password);
            var hashPassword=sha.ComputeHash(ByteArr);
            return Convert.ToBase64String(hashPassword);
    

        }
    }
}