using System;
using System.Collections.Generic;

#nullable disable

namespace MinimalistToDo.Models
{
    public partial class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ReminderDate { get; set; }
        public DateTime? DueDate { get; set; }
        public byte Progress { get; set; }
        public decimal Priority { get; set; }
        public Guid CollectionId { get; set; }
        public short HoursWorked { get; set; }
        public bool IsCompleted { get; set; }
        public byte? AttachmentId { get; set; }
        public bool IsSubtask { get; set; }
        public Guid? ParentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Collection Collection { get; set; }
    }
}
