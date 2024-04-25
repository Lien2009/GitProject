using Domain;
using Repositories.Implement;
using Repositories.Interfaces;
using Services.Interfaces;
using System.Data;

namespace Services.Implement
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository userRepository)
        {
            _repository = userRepository;
        }
        //public async Task<DataTable> GetAllUser(string roleName, string methodName)
        //{
        //    DataTable table = await _repository.GetAllUser(roleName, methodName);
        //    foreach (DataColumn c in table.Columns)
        //    {
        //        Console.Write($"{c.ColumnName,20}");
        //    }
        //    Console.WriteLine();

        //    int number_cols = table.Columns.Count;

        //    foreach (DataRow r in table.Rows)
        //    {
        //        for (int i = 0; i < number_cols; i++)
        //        {
        //            Console.Write($"{r[i],20}");
        //        }
        //        Console.WriteLine();
        //    }
        //    return table;
        //}

        public async Task<UserInfo> GetUserById(string id)
        {
            var user = await _repository.GetByIdAsync(id);
            if (user != null)
            {
                Console.WriteLine(user.ToString());
            }
            else
            {
                Console.WriteLine("User not found!");
            }

            return user;
        }

        //public async Task<Int32> Add(UserInfo userInfo)
        //{
        //    return await _repository.Add(userInfo);
        //}


        //public async Task<Int32> Update(UserInfo userInfo)
        //{
        //    return await _repository.Update(userInfo);
        //}

        //public async Task<Int32> Delete(string id)
        //{
        //    return await _repository.Delete(id);
        //}

        //public async Task<Int32> ActivateUsers(List<UserInfo> users)
        //{
        //    return await _repository.ActivateUsers(users);
        //}

        //public async Task<Int32> DeactivateUsers(List<UserInfo> users)
        //{
        //    return await _repository.DeactivateUsers(users);
        //}
    }
}
