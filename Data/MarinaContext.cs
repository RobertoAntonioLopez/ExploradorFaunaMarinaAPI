using Microsoft.EntityFrameworkCore;
using ExploradorFaunaMarinaAPI.Models;

namespace ExploradorFaunaMarinaAPI.Data
{
    public class MarinaContext : DbContext
    {
        public MarinaContext(DbContextOptions<MarinaContext> options) : base(options) { }

        public DbSet<EspecieMarina> EspeciesMarinas { get; set; }
        public DbSet<TipSnorkeling> TipsSnorkeling { get; set; }
    }
}