using SignalR5.Hubs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignalR5.Models;

namespace SinemaOtomasyonu
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        { }
        public DbSet<Mesaj> Mesajlar { get; set; }

    }
}