using System;

namespace todo.Data.Models
{
    public class BaseStructure
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime Started { get; set; }
        public DateTime Finished { get; set; }
        public State State { get; set; }
    }
}