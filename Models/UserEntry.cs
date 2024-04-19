using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpingmindApi.Models



{
    public class UserEntry
    {
        public int _UserId { get; set; }
        public string? _UserName { get; set; }
        public string? _Email { get; set; }
        public string? _Password { get; set; }
        public string? _FirstName { get; set; }
        public string? _LastName { get; set; }
        public int? _Age { get; set; }
        public string? _PhoneNumber { get; set; }
        // public DateTime? _dateOfBirth { get; set; }
        public bool? _IsActive { get; set; }
        public bool? _IsSuperuser { get; set; }
        public bool? _IsStaff { get; set; }
        public bool? _IsDeleted { get; set; }
        public DateTime? _CreatedAt { get; set; }
        public DateTime? _UpdatedAt { get; set; }

        // IMemberInterface
        public string? UserName { get; set; } = "Guest";

        // Navigation properties
        // public List<UserGroup> _UserGroups { get; set; } = new List<UserGroup>();
        // public List<UserPermission> UserUserPermissions { get; set; } = new List<UserPermission>();
        // public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
        // public List<SuperAdminLog> SuperAdminLogs { get; set; } = new List<SuperAdminLog>();



        // Create a class constructor for the AuthUser class
        public UserEntry(int UserId, string UserName, string Email, string Password, string FirstName, string LastName, int Age, string PhoneNumber, bool IsActive, bool IsSuperuser, bool IsStaff, bool IsDeleted, DateTime CreatedAt, DateTime UpdatedAt)
        {
            _UserId = UserId;
            _UserName = UserName;
            _Email = Email;
            _Password = Password;
            _FirstName = FirstName;
            _LastName = LastName;
            _Age = Age;
            _PhoneNumber = PhoneNumber;
            _IsActive = IsActive;
            _IsSuperuser = IsSuperuser;
            _IsStaff = IsStaff;
            _IsDeleted = IsDeleted;
            _CreatedAt = CreatedAt;
            _UpdatedAt = UpdatedAt;

            // _UserGroups = new UserGroup();
        }


        // get all description
        public string GetDescription()
        {
            string description;
            description = $"UserId: {_UserId}, UserName: {_UserName}, Email: {_Email}, Password: {_Password}, FirstName: {_FirstName}, LastName: {_LastName}, PhoneNumber: {_PhoneNumber}, IsActive: {_IsActive}, IsSuperuser: {_IsSuperuser}, IsStaff: {_IsStaff}, IsDeleted: {_IsDeleted}, CreatedAt: {_CreatedAt}, UpdatedAt: {_UpdatedAt}";
            return description;

        }

        public string GetUsername() => $"UserName: {_UserName}";

        public string GetFullName()
        {
            return $"{_FirstName} {_LastName}";
        }

        public string GetEmail() => $"Email: {_Email}";


        public bool Deactivate() => (bool)(_IsActive = false);
        public bool Reactivate() => (bool)(_IsActive = true);

        // change  user info
        public void ChangeUsername(string username) => _UserName = username;

        // check if user exist
        // public static bool Exist(int id, Database db)
        // {
        //     var query = "SELECT COUNT(*) FROM users WHERE Id=@Id";
        //     var param = new SqlParameter("@Id", id);
        //     int count = db.ExecuteScalar<int>(query, param);
        //     return count > 0 ? true : false;
        // }









    }
}

public class Database
{
}