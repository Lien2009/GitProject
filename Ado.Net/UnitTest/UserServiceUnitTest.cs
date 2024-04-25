using Repositories.Implement;
using Repositories.Interfaces;
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
        /*
         * Param: string roleName, string methodName
         * Case: 2 params are default value mean ""
         * Expect result: get datatable of all users
         */
        //[TestMethod]
        //public void TestGetAllUser_1()
        //{
        //    var allUser = _service.GetAllUser("", "");
        //    Assert.IsNotNull(allUser);
        //}
        /*
         * Param: string roleName, string methodName
         * Case: roleName is Tenant user, methodName is default value
         * Expect result: get datatable of all users having role Tetnant user
         */
        //[TestMethod]
        //public void TestGetAllUser_2()
        //{
        //    var allUser = _service.GetAllUser("Tenant user", "");
        //    Assert.IsNotNull(allUser);
        //}
        ///*
        // * Param: string roleName, string methodName
        // * Case: roleName is Tenant user, methodName is Microsoft 365 user/group
        // * Expect result: get datatable of all users having Tetnant user role and Microsoft 365 user/group method
        // */
        //[TestMethod]
        //public void TestGetAllUser_3()
        //{
        //    var allUser = _service.GetAllUser("Tenant user", "Microsoft 365 user/group");
        //    Assert.IsNotNull(allUser);
        //}
        /*
        * Param: string id
        * Case: id exist in DB
        * Expect result: get user has this ID
        */
        [TestMethod]
        public void TestGetUserById_1()
        {
            var user = _service.GetUserById("E6A4961B-2FA3-400A-BA11-839611F34ABB");
            Assert.IsNotNull(user);
        }
        /*
        * Param: string id
        * Case: id doesn't exist in DB
        * Expect result: user is null
        */
        [TestMethod]
        public void TestGetUserById_2()
        {
            var user = _service.GetUserById("123");
            Assert.IsNotNull(user);
        }

        /*
        * Param: UserInfo user
        * Case: user has enough info
        * Expect result: 1 record is affected
        */
        //[TestMethod]
        //public async void TestAdd_1()
        //{
        //    var result =await _service.Add(new Domain.UserInfo("8800@gmail.com", "Tenant user", "Tenant user", "Deactivated"));
        //    Assert.AreEqual(result, 1);
        //}

    }
}