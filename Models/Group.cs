using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharpingmindApi.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation properties
        // public List<UserGroupPermission> UserGroupPermissions { get; set; };
        public virtual List<User> Users { get; set; } // = new List<Users>();
    }
}

 
