using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS_Wildcats.Backend.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }

        private readonly string connectionString;

        public User(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public User(string connectionString, int userID)
        {
            this.connectionString = connectionString;
            LoadUserFromDatabase(userID);
        }

        private void LoadUserFromDatabase(int userID)
        {
            
        }

        public void Add()
        {
        }

        public static User Get(int userID, string connectionString)
        {
            return new User(connectionString, userID);
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }
}
