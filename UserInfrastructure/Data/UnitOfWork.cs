using UserCore.Models;

namespace UserInfrastructure.Data
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangeAsync();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private UserManagementContext _UserManagementContext;
        public UnitOfWork(UserManagementContext UserManagementContext)
        {
            _UserManagementContext = UserManagementContext;
        }
        public async Task<bool> SaveChangeAsync()
        {
            return (await _UserManagementContext.SaveChangesAsync()) > 0;
        }
    }
}
