﻿namespace NumberChallengeAPI.Models
{
    public enum TryResult { Winner, Smaller, Bigger };

    public class NumberResult
    {
        public int Try { get; set; }
        public string Result { get; set; }
    }
}
