namespace CarteiraDigital.Domain.Entities
{
    public sealed class User
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? DocumentNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public UserType? UserType { get; set; }
    }
}
