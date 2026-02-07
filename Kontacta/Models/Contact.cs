using System;
using System.Collections.Generic;
using System.Text;

namespace Kontacta.Models
{
    internal class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? ContactAddress { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
