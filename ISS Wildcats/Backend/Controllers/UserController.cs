using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS_Wildcats.Backend.Models;

namespace ISS_Wildcats.Backend.Controllers
{
    public class UserController
    {
        private User user;
        private SongController songController;

        public UserController(string connectionString, int userID, string songConnectionString, int songID)
        {
            user = new User(connectionString, userID);
            songController = new SongController(songConnectionString, songID);
        }

        // User management methods
        public void ChangeName(string newName)
        {
            user.Name = newName;
            user.Update();
        }

        public void ChangeEmail(string newEmail)
        {
            user.Email = newEmail;
            user.Update();
        }

        public void ChangePassword(string newPassword)
        {
            user.Password = newPassword;
            user.Update();
        }

        public void ChangeBirthDate(DateTime newBirthDate)
        {
            user.BirthDate = newBirthDate;
            user.Update();
        }

        public void DeleteUser()
        {
            user.Delete();
        }

        public void PlaySong()
        {
            songController.Play();
        }

        public void PauseSong()
        {
            songController.Pause();
        }

        public void SeekSong(int seconds)
        {
            songController.Seek(seconds);
        }
    }
}
