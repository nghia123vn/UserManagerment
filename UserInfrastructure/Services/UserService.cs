using UserCore.Models;
using UserInfrastructure.Data;
using UserInfrastructure.Repositories;

namespace UserInfrastructure.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _unitOfWork;
        private IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public UserService()
        {
        }

        public List<TblUser> ListUser()
        {
            _userRepository = new UserRepository();
            return _userRepository.listAllUser();
        }
        public void AddUser(TblUser user)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

    }
}
