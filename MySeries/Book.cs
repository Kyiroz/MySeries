﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySeries.Classes
{
    public class Book : Artwork
    {
        public string Publisher { get; set; }
        public int Volumes { get; set; }
        public int PagesPerVolume { get; set; }
        protected float minutesPerPage = 1.7f;

        public Book(string title, string author, string date, string genre, int rating, string rewiew, string publisher, int volumes, int pagesPerVolume) : base(title, author, date, genre, rating, rewiew)
        {
            Publisher = publisher;
            Volumes = volumes;
            PagesPerVolume = pagesPerVolume;
        }

        public float GetSeriesReadingTime()
        {
            return Volumes * GetVolumeReadingTime();
        }

        public float GetVolumeReadingTime()
        {
            return minutesPerPage * PagesPerVolume;
        }

        public override string GetReference()
        {
            //todo:
            return "";
        }
    }
}