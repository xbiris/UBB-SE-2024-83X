﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project
{
	public class Song
	{
		public int id { get; set; }
		public string title { get; set; }
		public int length { get; set; }
		public string songUrl { get; set; }
		public int albumId { get; set; }

		public Song(string title, string songUrl) {
			this.title = title;
			this.songUrl = songUrl;
		}
	}
}
