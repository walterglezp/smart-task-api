using System;

namespace SmartTasks.Domain.Resources
{
    public class TaskResource
    {
        public int Version { get; set; } = 1; // Track current version for API reads/writes
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; } = 1;
        public bool IsCompleted { get; set; } = false;
    }
}
