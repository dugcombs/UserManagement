using UserManagement.Dtos;

namespace UserManagement.Constants
{
    public class UserSampleData
    {
        // Private static instance of the class
        private static readonly UserSampleData _instance = new UserSampleData();

        // Private constructor to prevent external instantiation
        private UserSampleData() {
            UserSampleList = new List<User>
            {
                new User { ID = 1, Name = "Alice Smith", Age = 30, Education = "Bachelor's Degree", Occupation = "Software Engineer" },
                new User { ID = 2, Name = "Bob Johnson", Age = 25, Education = "Associate Degree", Occupation = "Graphic Designer" },
                new User { ID = 3, Name = "Charlie Brown", Age = 35, Education = "Master's Degree", Occupation = "Project Manager" },
                new User { ID = 4, Name = "Diana Prince", Age = 28, Education = "Bachelor's Degree", Occupation = "Marketing Specialist" },
                new User { ID = 5, Name = "Edward Norton", Age = 40, Education = "Master's Degree", Occupation = "Data Scientist" },
                new User { ID = 6, Name = "Fiona Gallagher", Age = 22, Education = "High School Diploma", Occupation = "Sales Associate" },
                new User { ID = 7, Name = "George Martin", Age = 50, Education = "PhD", Occupation = "Professor" },
                new User { ID = 8, Name = "Hannah Brown", Age = 29, Education = "Bachelor's Degree", Occupation = "Content Writer" },
                new User { ID = 9, Name = "Ian Wright", Age = 33, Education = "Master's Degree", Occupation = "Financial Analyst" },
                new User { ID = 10, Name = "Julia Roberts", Age = 45, Education = "Bachelor's Degree", Occupation = "Human Resources Manager" }
            };
        }
        // Public property to get the singleton instance
        public static UserSampleData Instance
        {
            get
            {
                return _instance;
            }
        }
        // List of sample users
        public List<User> UserSampleList { get; private set; }
        // Asynchronous method to get sample users
        public async Task<List<User>> GetSampleUsersAsync()
        {
            // Simulate a delay
            await Task.Delay(1000); // Delay for 1 second to simulate DB operation

            return UserSampleList;
        }
    }
}
