namespace Domain
{
    public class UserInfo
    {
        public UserInfo()
        {
        }

        public UserInfo(string userId, int roleId, int methodId, int statusId)
        {
            UserId = userId;
            RoleId = roleId;
            MethodId = methodId;
            StatusId = statusId;
        }

        public UserInfo(string iD, string userId, int roleId, int methodId, int statusId)
        {
            ID = iD;
            UserId = userId;
            RoleId = roleId;
            MethodId = methodId;
            StatusId = statusId;
        }

        public string ID { get; set; }
        public string UserId { get; set; }
        public int RoleId { get; set; }
        public int MethodId { get; set; }
        public int StatusId { get; set; }

    }
}
