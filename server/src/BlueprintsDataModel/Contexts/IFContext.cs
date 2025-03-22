using Microsoft.EntityFrameworkCore;
using BlueprintsDataModel.Models;

namespace BlueprintsDataModel.Contexts
{
    public class IFContext : DbContext
    {
        public DbSet<AndExpression> AndExpressions { get; set; }
        public DbSet<AndOperand> AndOperands { get; set; }
        public DbSet<AndExpressionOperand> AndExpressionOperands { get; set; }

        public IFContext(DbContextOptions<IFContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AndExpressionOperand>()
                .HasKey(dependent => new { dependent.AndExpressionId, dependent.AndOperandId });

            modelBuilder.Entity<AndExpressionOperand>()
                .HasOne(dependent => dependent.AndExpression)
                .WithMany(principal => principal.AndExpressionOperands);

            modelBuilder.Entity<AndExpressionOperand>()
                .HasOne(dependent => dependent.AndOperand)
                .WithMany(principal => principal.AndExpressionOperands);
        }
    }
}
