using Domain;
using Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace Repositories.Implement
{
    public class UserRepository : Repository<UserInfo>, IUserRepository
    {
        protected override String TableName => "Users";

        //public async Task<DataTable> GetAllUser(string roleName, string methodName)
        //{
        //    using (SqlConnection connection = RepositoryBase.GetConnection())
        //    {
        //        await connection.OpenAsync();
        //        var adapter = new SqlDataAdapter();
        //        SqlCommand command = new SqlCommand("SELECT Users.ID, Users.UserID, Roles.RoleName, Methods.MethodName, Status.StatusName \r\nFROM Users\r\nJOIN Roles ON Users.RoleId = Roles.RoleId\r\nJOIN Methods ON Users.MethodId = Methods.MethodId\r\nJOIN Status ON Users.StatusId = Status.StatusId\r\nWHERE (Roles.RoleName LIKE @RoleName OR @RoleName IS NULL OR @RoleName = '') AND (Methods.MethodName LIKE @MethodName OR @MethodName IS NULL OR @MethodName = '')", connection);

        //        if (!string.IsNullOrEmpty(roleName))
        //        {
        //            command.Parameters.AddWithValue("@RoleName", roleName);
        //        }
        //        else
        //        {
        //            command.Parameters.AddWithValue("@RoleName", DBNull.Value);
        //        }
        //        if (!string.IsNullOrEmpty(methodName))
        //        {
        //            command.Parameters.AddWithValue("@MethodName", methodName);
        //        }
        //        else
        //        {
        //            command.Parameters.AddWithValue("@MethodName", DBNull.Value);
        //        }

        //        adapter.SelectCommand = command;
        //        var table = new DataTable();
        //        await Task.Run(() => adapter.Fill(table));
        //        return table;
        //    }
        //}


        //public async Task<UserInfo> GetUserById(string id)
        //{
        //    using (SqlConnection connection = RepositoryBase.GetConnection())
        //    {
        //        await connection.OpenAsync();
        //        SqlCommand command = new SqlCommand("SELECT Users.ID, Users.UserID, Roles.RoleName, Methods.MethodName, Status.StatusName \r\nFROM Users\r\nJOIN Roles ON Users.RoleId = Roles.RoleId\r\nJOIN Methods ON Users.MethodId = Methods.MethodId\r\nJOIN Status ON Users.StatusId = Status.StatusId\r\nWHERE Users.ID = @ID", connection);
        //        if (!string.IsNullOrEmpty(id))
        //        {
        //            command.Parameters.AddWithValue("@ID", id);
        //        }
        //        else
        //        {
        //            return null;
        //        }

        //        using (SqlDataReader reader = await command.ExecuteReaderAsync())
        //        {
        //            if (await reader.ReadAsync())
        //            {
        //                UserInfo user = new UserInfo
        //                {
        //                    ID = reader["ID"].ToString(),
        //                    UserId = reader["UserID"].ToString(),
        //                    Role = reader["RoleName"].ToString(),
        //                    Method = reader["MethodName"].ToString(),
        //                    Status = reader["StatusName"].ToString()
        //                };
        //                return user;
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //    }
        //}

        //public async Task<Int32> Add(UserInfo userInfo)
        //{
        //    using (SqlConnection connection = RepositoryBase.GetConnection())
        //    {
        //        await connection.OpenAsync();
        //        var adapter = new SqlDataAdapter();
        //        SqlCommand command = new SqlCommand("insert into Users(UserID, RoleId, MethodId, StatusId)\r\n  values (@UserID,@RoleId,@MethodId,@StatusId)", connection);
        //        SqlCommand commandRoleId = new SqlCommand("select RoleId from Roles where RoleName = @RoleName", connection);
        //        SqlCommand commandMethodId = new SqlCommand("select MethodId from Methods where MethodName = @MethodName", connection);
        //        SqlCommand commandStatusId = new SqlCommand("select StatusId from Status where StatusName = @StatusName", connection);

        //        if (userInfo != null)
        //        {
        //            var roleId = await commandRoleId.ExecuteScalarAsync();
        //            var methodId = await commandMethodId.ExecuteScalarAsync();
        //            var statusId = await commandStatusId.ExecuteScalarAsync();
        //            command.Parameters.AddWithValue("@UserID", userInfo.UserId);
        //            command.Parameters.AddWithValue("@RoleId", roleId);
        //            command.Parameters.AddWithValue("@MethodId", methodId);
        //            command.Parameters.AddWithValue("@StatusId", statusId);
        //        }
        //        return await command.ExecuteNonQueryAsync();
        //    }
        //}

        //public async Task<Int32> Update(UserInfo userInfo)
        //{
        //    using (SqlConnection connection = RepositoryBase.GetConnection())
        //    {
        //        await connection.OpenAsync();
        //        var adapter = new SqlDataAdapter();
        //        SqlCommand command = new SqlCommand("update Users set UserID = $UserID, RoleId = @RoleId, MethodId = @MethodId, StatusId = @StatusId where ID = @ID", connection);
        //        SqlCommand commandRoleId = new SqlCommand("select RoleId from Roles where RoleName = @RoleName", connection);
        //        SqlCommand commandMethodId = new SqlCommand("select MethodId from Methods where MethodName = @MethodName", connection);
        //        SqlCommand commandStatusId = new SqlCommand("select StatusId from Status where StatusName = @StatusName", connection);
        //        if (userInfo != null)
        //        {
        //            var roleId = await commandRoleId.ExecuteScalarAsync();
        //            var methodId = await commandMethodId.ExecuteScalarAsync();
        //            var statusId = await commandStatusId.ExecuteScalarAsync();
        //            command.Parameters.AddWithValue("@UserID", userInfo.UserId);
        //            command.Parameters.AddWithValue("@RoleId", roleId);
        //            command.Parameters.AddWithValue("@MethodId", methodId);
        //            command.Parameters.AddWithValue("@StatusId", statusId);
        //            command.Parameters.AddWithValue("@ID", userInfo.ID);
        //        }
        //        return await command.ExecuteNonQueryAsync();
        //    }
        //}

        //public async Task<Int32> Delete(string id)
        //{
        //    using (SqlConnection connection = RepositoryBase.GetConnection())
        //    {
        //        await connection.OpenAsync();
        //        var adapter = new SqlDataAdapter();
        //        SqlCommand command = new SqlCommand("delete from Users where ID =@ID", connection);

        //        if (!string.IsNullOrEmpty(id))
        //        {
        //            command.Parameters.AddWithValue("@ID", id);
        //        }
        //        return await command.ExecuteNonQueryAsync();
        //    }
        //}


        //public async Task<Int32> ActivateUsers(List<UserInfo> users)
        //{
        //    List<string> userIds = users.Select(user => user.ID).ToList();
        //    using (SqlConnection connection = RepositoryBase.GetConnection())
        //    {
        //        await connection.OpenAsync();
        //        var adapter = new SqlDataAdapter();
        //        SqlCommand command = new SqlCommand("update Users set StatusId = 1 where ID = @ID", connection);
        //        foreach (string id in userIds)
        //        {
        //            if (!string.IsNullOrEmpty(id))
        //            {
        //                command.Parameters.AddWithValue("@ID", id);
        //            }
        //        }
        //        return await command.ExecuteNonQueryAsync();
        //    }
        //}


        //public async Task<Int32> DeactivateUsers(List<UserInfo> users)
        //{
        //    List<string> userIds = users.Select(user => user.ID).ToList();
        //    using (SqlConnection connection = RepositoryBase.GetConnection())
        //    {
        //        await connection.OpenAsync();
        //        var adapter = new SqlDataAdapter();
        //        SqlCommand command = new SqlCommand("update Users set StatusId = 2 where ID = @ID", connection);
        //        foreach (string id in userIds)
        //        {
        //            if (!string.IsNullOrEmpty(id))
        //            {
        //                command.Parameters.AddWithValue("@ID", id);
        //            }
        //        }
        //        return await command.ExecuteNonQueryAsync();
        //    }
        //}
    }
}
