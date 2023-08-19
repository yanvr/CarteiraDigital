namespace CarteiraDigital.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public decimal Value { get; set; }
        public DateTime DateTime { get; set; }
    }
}
