using SmartTasks.Domain.Enums; 

namespace SmartTasks.Domain.Entities
{
    public class TaskRecord
    {
        public Guid Id { get; set; }
        public int Version { get; set; } = 1; // New field
        public DateTime Cts { get; set; }
        public DateTime Ts { get; set; }
        public RecordStatus Status { get; set; }
        public string ResourceType { get; set; } = "Task";
        public string Resource { get; set; } = string.Empty;
    }

    public class TaskHistoryRecord
    {
        public Guid Id { get; set; } // Same ID as Task
        public int Version { get; set; }
        public DateTime Cts { get; set; }
        public DateTime Ts { get; set; }
        public RecordStatus Status { get; set; }
        public string ResourceType { get; set; } = "Task";
        public string Resource { get; set; } = string.Empty;
    }
}
