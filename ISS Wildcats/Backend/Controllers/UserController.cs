using ISS_Wildcats.Backend.Models;
using ISS_Wildcats.Backend.Service;

namespace ISS_Wildcats.Backend.Controllers
{
    public class UserController
    {
        private User user;
        private SongService songService;

        public UserController(string connectionString, int userID, int songID)
        {
            user = new User(connectionString, userID);
			songService = new SongService(songID);
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
			songService.Play();
        }

        public void PauseSong()
        {
			songService.Pause();
        }

        public void SeekSong(int seconds)
        {
			songService.Seek(seconds);
        }
    }
}
