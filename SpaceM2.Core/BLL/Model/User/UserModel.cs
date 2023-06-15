using System;
namespace SpaceM2.Core.BLL.Model
{
    public class UserModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string RoleKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserPassword { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ImageFilePath { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEmployee { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserCreated { get; set; }
        public DateTime DateDeleted { get; set; }
        public int UserDeleted { get; set; }
    }
}
