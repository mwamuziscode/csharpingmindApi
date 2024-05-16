using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace csharpingmindApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [JsonRequired]
        public string UserName { get; set; } = string.Empty;

        [JsonRequired]
        public string Email { get; set; } = string.Empty;

        [JsonRequired]
        public string Password { get; set; } = string.Empty;

        [JsonRequired]
        public string FirstName { get; set; } = string.Empty;

        [JsonRequired]
        public string LastName { get; set; } = string.Empty;

        public int Age { get; set; }

        [JsonRequired]
        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsSuperuser { get; set; }
        public bool IsStaff { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
