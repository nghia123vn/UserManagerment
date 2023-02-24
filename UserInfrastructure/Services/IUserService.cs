using UserCore.Models;

namespace UserInfrastructure.Services
{
    public interface IUserService
    {

        public List<TblUser> ListUser();
    }
}
