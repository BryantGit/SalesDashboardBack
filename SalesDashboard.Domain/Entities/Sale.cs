using SalesDashboard.Domain.Entities;

namespace SalesDashboard.Infrastructure.Persistence
{
    public class Sale
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; } = default!;
        public decimal Amount { get; set; }
        public DateTime SaleDate { get; set; }
        public Guid UserId { get; set; } // Foreign key to User entity
        public User User { get; set; } = default!; // Navigation property
    }
}