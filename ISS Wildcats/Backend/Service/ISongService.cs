﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS_Wildcats.Backend.Service
{
    public interface ISongService
    {
        void ChangeSongId(int newSongId);
        void Play();
        void Pause();
        void Seek(int seconds);
    }
}
