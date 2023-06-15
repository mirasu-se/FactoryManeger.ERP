namespace SpaceM2.Core.BLL.Model
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string Abbreviation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public bool IsEmployed { get; set; }

    }
}
