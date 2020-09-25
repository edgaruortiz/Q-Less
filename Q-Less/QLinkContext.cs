namespace Q_Less
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Q_Less.Models;

    public partial class QLinkContext : DbContext
    {
        public QLinkContext()
            : base("name=QLinkContext")
        {
        }

        public virtual DbSet<CardType> CardTypes { get; set; }
        public virtual DbSet<TransportCard> TransportCards { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<PriceMatrix> PriceMatrices{ get; set; }
        public virtual DbSet<TransportCardReloadHistory> TransportCardReloadHistories { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
