using UserManagement.Dtos;

namespace UserManagement.Services
{
    public interface IUserService
    {
        Task<User?> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task<User?> UpdateAsync(User user);
        Task<User?> DeleteAsync(int id);
    }
}
