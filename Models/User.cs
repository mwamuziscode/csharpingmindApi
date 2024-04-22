using System.Text.Json.Serialization;

namespace csharpingmindApi.Models

{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime dateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public bool IsSuperuser { get; set; }
        public bool IsStaff { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // UserGroup
        public int GroupId { get; set; }
        [JsonIgnore]
        public virtual Group Group { get; set; }
        //public List<Permission> Permissions { get; set; } //= new List<UserPermission>();
        // public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
        //public List<SuperLog> SuperLogs { get; set; } // = new List<SuperAdminLog>();
    }
}

