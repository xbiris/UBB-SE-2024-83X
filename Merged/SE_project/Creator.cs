﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project
{
	public class Creator : IUser
	{
		public int id { get; set; }
		public string username { get; set; }
		public string fullname { get; set; }
		public string email { get; set; }
		public string country { get; set; }
		public string birthday { get; set; }
		public string socialmedialink { get; set; }
        public string description { get; set; }
        public string profilePicPath { get; set; }

        public Creator(string username, string fullname, string email, string country, string birthday, string socialmedialink, string description, string profilePicPath)
		{
			this.username = username;
			this.fullname = fullname;
			this.email = email;
			this.country = country;
			this.birthday = birthday;
			this.socialmedialink = socialmedialink;
			this.description = description;
			this.profilePicPath = profilePicPath;
        }
	}
}
