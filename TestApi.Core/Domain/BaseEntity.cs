using System;
using System.Collections.Generic;
using System.Text;

namespace TestApi.Core.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? LastModified { get; set; }
    }
}
