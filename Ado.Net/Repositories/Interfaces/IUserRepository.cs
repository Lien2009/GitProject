using System.Data;
using Domain;

namespace Repositories.Interfaces
{
    public interface IUserRepository : IRepository<UserInfo>
    {
        //Task<DataTable> GetAllUser(string roleName, string methodName);
        ////Task<UserInfo> GetUserById(string id);
        //Task<Int32> Add(UserInfo userInfo);
        //Task<Int32> Update(UserInfo userInfo);
        //Task<Int32> Delete(string id);
        //Task<Int32> ActivateUsers(List<UserInfo> users);
        //Task<Int32> DeactivateUsers(List<UserInfo> users);
    }
}
