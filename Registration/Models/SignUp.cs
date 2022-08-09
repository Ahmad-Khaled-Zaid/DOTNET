namespace Registration.Models
{
    public class SignUp
    {
        public Guid id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

    }

}
