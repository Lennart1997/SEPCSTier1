using System.Collections.Generic;
using System.Threading.Tasks;
using SEPCSTier1.Models;

namespace SEPCSTier1.Data
{
    public interface IUserData
    {
        void AddUser(User user);
        
        void RemoveAccount(int UserId);
        
        Task<IList<User>> GetUsers();
        Task<IList<User>> ValidateUser(string userName, string passWord);
    }
}