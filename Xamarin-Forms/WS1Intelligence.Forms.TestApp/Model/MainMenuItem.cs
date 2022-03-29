﻿using System;
namespace WS1Intelligence.Forms.App.Model
{
    public class MainMenuItem
    {
        public string Title { get; }
        public string Subtitle { get; }
        //public string ImageSource { get; }

        public MainMenuItem(string title, string subtitle, string imageSource)
        {
            Title = title;
            Subtitle = subtitle;
            //ImageSource = imageSource;
        }
    }
}
