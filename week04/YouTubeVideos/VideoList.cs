// A class to store a list of videos

// Steve Ward CSE210 March 12, 2026

using System;
using System.Collections.Generic;

class VideoList
{
    private List<Video> _videos;

    public VideoList()
    {
        _videos = new List<Video>();
    }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public List<Video> GetVideos()
    {
        return _videos;
    }
}