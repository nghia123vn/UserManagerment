using UserCore.Models;

namespace UserInfrastructure.Repositories
{
    public interface IUserRepository
    {
        public TblUser login(string _userName, string _password);
        public List<TblUser> listAllUser();

        public void AddUser(TblUser user);
    }
}
