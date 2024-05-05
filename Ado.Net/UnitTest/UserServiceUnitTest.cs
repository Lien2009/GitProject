using Repositories.Implement;
using Services.Implement;
using Services.Interfaces;
namespace UnitTest
{
    [TestClass]
    public class UserServiceUnitTest
    {
        private IUserService _service;

        public UserServiceUnitTest()
        {
            _service = new UserService(new UserRepository());
        }

        //* Param: int role, int method
        //* Case: 2 params are default value mean 0
        //* Expect result: get datatable of all users
        //*/
        [TestMethod]
        public void TestGetAllUser_1()
        {
            var allUser = _service.GetAllUsersAsync(0, 0);
            Assert.IsNotNull(allUser);
        }
        /*
         * Param: int role, int method
         * Case: roleId is 1, methodId is default value
         * Expect result: get datatable of all users having role Tetnant user (1)
         */
        [TestMethod]
        public void TestGetAllUser_2()
        {
            var allUser = _service.GetAllUsersAsync(1, 0);
            Assert.IsNotNull(allUser);
        }
        /*
         * Param: int role, int method
         * Case: roleId is 1, methodId is 1
         * Expect result: get datatable of all users having Tetnant user role (1) and Microsoft 365 user/group method(1)
         */
        [TestMethod]
        public void TestGetAllUser_3()
        {
            var allUser = _service.GetAllUsersAsync(1, 1);
            Assert.IsNotNull(allUser);
        }

        //* Param: string id
        //* Case: id exist in DB
        //* Expect result: get user has this ID

        [TestMethod]
        public void TestGetUserById_1()
        {
            var user = _service.GetUserByIdAsync("E6A4961B-2FA3-400A-BA11-839611F34ABB");
            Assert.IsNotNull(user);
        }

        //* Param: string id
        //* Case: id doesn't exist in DB
        //* Expect result: user is null

        [TestMethod]
        public async Task TestGetUserById_2()
        {
            var user = await _service.GetUserByIdAsync("123");
            Assert.IsNull(user);
        }

        /*
        * Param: UserInfo user
        * Case: user has enough info
        * Expect result: 1 record is affected
        * */

        [TestMethod]
        public async Task TestAdd_1()
        {
            var result = await _service.AddAsync(new Domain.UserInfo("8800@gmail.com", 1, 4, 2));
            Assert.AreEqual(result, 1);
        }
        /*
        * Param: UserInfo user
        * Case: user has enough info
        * Expect result: 1 record is affected
        * */

        [TestMethod]
        public async Task TestUpdate_1()
        {
            var result = await _service.UpdateAsync(new Domain.UserInfo("EC6BFA81-7640-422F-A52D-364F93DDF789", "0000@gmail.com", 1, 1, 1));
            Assert.AreEqual(result, 1);
        }

        /*
        * Param: string Id
        * Case: user has enough info
        * Expect result: 1 record is affected
        * */

        [TestMethod]
        public async Task TestDelete_1()
        {
            var result = await _service.DeleteAsync("E6A4961B-2FA3-400A-BA11-839611F34ABB");
            Assert.AreEqual(result, 1);
        }

    }
}