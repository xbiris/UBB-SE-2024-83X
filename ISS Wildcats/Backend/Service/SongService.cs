using ISS_Wildcats.Backend.Controllers;

namespace ISS_Wildcats.Backend.Service
{
	public class SongService
	{
		SongController songController;

		public SongService(int songId) {
			songController = new SongController(songId);
		}

		public void Play()
		{
			songController.Play();
		}

		public void Pause()
		{
			songController.Pause();
		}

		public void Seek(int seconds)
		{
			songController.Seek(seconds);
		}
	}
}
