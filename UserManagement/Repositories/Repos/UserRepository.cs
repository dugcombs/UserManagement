using UserManagement.Dtos;
using UserManagement.Repositories.Interfaces;
using UserManagement.Constants;

namespace UserManagement.Repositories.Repos
{
    public class UserRepository : IUserRepository
    {
        public async Task AddAsync(User user)
        {
            // Simulate an asynchronous operation
            await Task.CompletedTask;

            // Access the singleton instance and add the user
            var userData = UserSampleData.Instance.UserSampleList;
            userData.Add(user);
        }

        public async Task<User?> DeleteAsync(int id)
        {
            // Simulate an asynchronous operation
            await Task.CompletedTask;

            // Find the user by ID and remove them from the list
            var userToRemove = UserSampleData.Instance.UserSampleList.FirstOrDefault(u => u.ID == id);
            if (userToRemove != null)
            {
                UserSampleData.Instance.UserSampleList.Remove(userToRemove);
            }
            // User could be null here
            return userToRemove;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            // Get all Users 
            return await UserSampleData.Instance.GetSampleUsersAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            // Simulate an asynchronous operation
            await Task.CompletedTask;
            // Find the user by ID and return that from the list
            return UserSampleData.Instance.UserSampleList.FirstOrDefault(u => u.ID == id);
            
        }

        public async Task<User?> UpdateAsync(User user)
        {
            // Simulate an asynchronous operation
            await Task.CompletedTask;
            // Find the user by ID and update that from the list
            var userFromList = UserSampleData.Instance.UserSampleList.FirstOrDefault(u => u.ID == user.ID);
            if (userFromList != null)
            {
                userFromList = user;
            }
            // User could be null here
            return userFromList;
        }
    }
}
