using System.Collections.Generic;

namespace todo.Data.Models
{
    public class Project : BaseStructure
    {
        public List<Task> Tasks { get; set; }
        
    }
}