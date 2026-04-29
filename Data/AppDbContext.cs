using DockerizedTaskAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerizedTaskAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TaskItem> Tasks => Set<TaskItem>();
}