using ISS_Wildcats.Backend.Controllers;
using ISS_Wildcats.Backend.Repos;
using ISS_Wildcats.Backend.Service;
using System.Windows;
using System.Windows.Forms;

namespace ISS_Wildcats
{
	public partial class Form1 : Form
	{
		bool playing = false;
		ISongRepo songRepo;
		ISongService songService;
		ISongController songController; // main component that is used
		public Form1()
		{
			InitializeComponent();
            songRepo = new SongRepo();
            songService = new SongService(songRepo, 1);
            songController = new SongController(songService);
        }

		private void labelAccount_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.userControl11.Visible = true;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void pictureBox9_Click(object sender, EventArgs e)
		{
			if (!playing)
			{
				songController.Play();
				playing = true;
			}
			else
			{
				songController.Pause();
				playing = false;
			}

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void panel12_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel10_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (!playing)
			{
				songController.Play();
				playing = true;
			}
			else
			{
				songController.ChangeSongId(1);
				playing = true;
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (!playing)
			{
                songController.ChangeSongId(2);
                playing = true;
			}
			else
			{
                songController.ChangeSongId(2);
                playing = true;
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (!playing)
			{
                songController.ChangeSongId(3);
                playing = true;
			}
			else
			{
                songController.ChangeSongId(3);
                playing = true;
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (!playing)
			{
                songController.ChangeSongId(4);
                playing = true;
			}
			else
			{
                songController.ChangeSongId(4);
                playing = true;
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
