using SmartTasks.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTasks.Domain.Entities
{
    public class ResourceRecord
    {
        public Guid Id { get; set; }
        public DateTime Cts { get; set; } // Creation timestamp
        public DateTime Ts { get; set; }  // Update timestamp
        public RecordStatus Status { get; set; } // created, updated
        public string ResourceType { get; set; } = string.Empty; // e.g., Task, User
        public string Resource { get; set; } = string.Empty;     // JSON string
    }
}
