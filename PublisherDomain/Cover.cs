﻿namespace PublisherDomain
{
    public class Cover
    {
        public Cover()
        {
            Artists = new List<Artist>();
        }
        public int CoverId { get; set; }
        public string DesignIdea { get; set; }
        public bool DigitalOnly { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
