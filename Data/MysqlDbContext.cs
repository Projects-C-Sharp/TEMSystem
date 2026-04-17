using Microsoft.EntityFrameworkCore;
using TEMSystem.Models;

namespace TEMSystem.Data;

public class MysqlDbContext : DbContext
{
    public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options) {}
    public DbSet<Event> events { get; set; }
}