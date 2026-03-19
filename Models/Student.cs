namespace studentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }           // Primary key

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Email { get; set; } = string.Empty;

        public string MobileNo { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}