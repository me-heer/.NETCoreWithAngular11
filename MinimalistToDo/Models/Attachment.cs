using System;
using System.Collections.Generic;

#nullable disable

namespace MinimalistToDo.Models
{
    public partial class Attachment
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
