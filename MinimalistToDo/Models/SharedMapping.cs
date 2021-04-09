using System;
using System.Collections.Generic;

#nullable disable

namespace MinimalistToDo.Models
{
    public partial class SharedMapping
    {
        public Guid Id { get; set; }
        public string SharedUserId { get; set; }
        public Guid SharedCollectionId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Collection SharedCollection { get; set; }
        public virtual AspNetUser SharedUser { get; set; }
    }
}
