using System;

namespace IdeasApp.Models
{
    public class Entry {
        // Stores table values for particular columns listed below
        public long Id { get; set; }
        public string Category { get; set; }
        public string TaskName { get; set; }
        public DateTime Deadline { get; set; }
        public string Priority { get; set; }
        public int EstimatedTime { get; set; }
    }
}
