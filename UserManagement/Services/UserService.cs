using UserManagement.Dtos;
using UserManagement.Repositories.Interfaces;

namespace UserManagement.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;
        public UserService(IUserRepository userRepository) {
            _UserRepository = userRepository;
        }
        public async Task AddAsync(User user)
        {
            // Add User
           await _UserRepository.AddAsync(user);
        }

        public async Task<User?> DeleteAsync(int id)
        {
            // Delete User
            return await _UserRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            // Get AllUsers
            return await _UserRepository.GetAllAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            // Get GetById
            return await _UserRepository.GetByIdAsync(id);
        }

        public async Task<User?> UpdateAsync(User user)
        {
            // Get UpdateUsers
            return await _UserRepository.UpdateAsync(user);
        }
    }
}
