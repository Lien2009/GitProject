using Domain;
using Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace Repositories.Implement
{
    public class UserRepository : RepositoryBase<UserInfo>, IUserRepository
    {
        public async Task<Int32> ActivateUsersAsync(List<UserInfo> users)
        {
            var res = await base.ActivateUsersAsync(users);
            return res;
        }
        public async Task<int> DeactivateUsersAsync(List<UserInfo> users)
        {
            var res = await base.DeActivateUsersAsync(users);
            return res;
        }

        public async Task<Int32> DeleteAsync(string id)
        {
            var res = await base.DeleteAysnc(id);
            return res;
        }

        public async Task<List<UserInfo>> GetAllUserAsync(int role, int method)
        {
            var res = await base.GetAllUsersAsync(role, method);
            return res;
        }

        public async Task<Int32> AddAsync(UserInfo userInfo)
        {

            var res = await base.AddAsync(userInfo);

            return res;
        }

        public async Task<Int32> UpdateAsync(UserInfo userInfo)
        {
            var res = await base.UpdateAsync(userInfo);
            return res;
        }
    }
}
