using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpingmindApi.Models

{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public bool IsSuperuser { get; set; }
        public bool IsStaff { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // UserGroup
        public int GroupId { get; set; }




        // Navigation properties
        // public List<UserGroup> _UserGroups { get; set; } = new List<UserGroup>();
        // public List<UserPermission> UserUserPermissions { get; set; } = new List<UserPermission>();
        // public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
        // public List<SuperAdminLog> SuperAdminLogs { get; set; } = new List<SuperAdminLog>();
    }
}

