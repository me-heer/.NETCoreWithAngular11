using System;
using System.Collections.Generic;

#nullable disable

namespace MinimalistToDo.Models
{
    public partial class Collection
    {
        public Collection()
        {
            SharedMappings = new HashSet<SharedMapping>();
            Tasks = new HashSet<Task>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<SharedMapping> SharedMappings { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
