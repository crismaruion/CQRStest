using System;

namespace TestApi.Core.Domain
{
    public class TodoEntity : BaseEntity
    {
        public string Description { get; set; }
        public DateTimeOffset? Deadline { get; set; }
    }
}
