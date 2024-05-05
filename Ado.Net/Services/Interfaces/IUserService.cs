using Domain;

namespace Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserInfo>> GetAllUsersAsync(int role, int method);
        Task<UserInfo> GetUserByIdAsync(string id);
        Task<Int32> AddAsync(UserInfo userInfo);
        Task<Int32> UpdateAsync(UserInfo userInfo);
        Task<Int32> DeleteAsync(string id);
        Task<Int32> ActivateUsersAsync(List<UserInfo> users);
        Task<Int32> DeActivateUsersAsync(List<UserInfo> users);
    }
}
