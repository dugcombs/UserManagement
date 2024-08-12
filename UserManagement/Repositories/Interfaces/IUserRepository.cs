using UserManagement.Dtos;

namespace UserManagement.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task<User?> UpdateAsync(User user);
        Task<User?> DeleteAsync(int id);
    }
}
