﻿namespace Koala.ActivityMusicHandlerService.Models.Incoming;

public class SpotifyInfoIncoming
{
    public string Album { get; set; }
    public IReadOnlyCollection<string> Artists { get; set; }
    public string Track { get; set; }
    public int? DurationInSeconds { get; set; }
    public string TrackId { get; set; }
}