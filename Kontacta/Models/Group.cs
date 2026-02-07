using System;
using System.Collections.Generic;
using System.Text;

namespace Kontacta.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
