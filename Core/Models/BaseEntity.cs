using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
