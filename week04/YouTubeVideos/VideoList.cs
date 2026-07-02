// A class to store a list of videos

// Lee Ward CSE210 July 2, 2026

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