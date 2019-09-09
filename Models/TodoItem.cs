using System;

namespace TodoApi.Models
{
    public class TodoItem : IEntity
    {
        public long Id {get; set;}
        public string Name {get; set;}
        public bool IsComplete {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}