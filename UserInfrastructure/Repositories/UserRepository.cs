using UserCore.Models;

namespace UserInfrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public TblUser login(string _userName, string _password)
        {
            using (var context = new UserManagementContext())
            {
                TblUser User = context.TblUsers.SingleOrDefault(user => user.FullName == _userName && user.Password == _password);
                return User;
            }
        }

        public List<TblUser> listAllUser()
        {
            using (var context = new UserManagementContext())
            {
                return context.TblUsers.ToList();
            }
        }

        public void AddUser(TblUser user)
        {
            using (var context = new UserManagementContext())
            {
                context.TblUsers.Add(user);
            }
        }
    }
}
