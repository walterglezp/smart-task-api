using SmartTasks.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTasks.Domain.Entities
{ 
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime Cts { get; set; }
        DateTime Ts { get; set; }
        RecordStatus Status { get; set; }
        string ResourceType { get; set; }
        string Resource { get; set; }
    }
}
