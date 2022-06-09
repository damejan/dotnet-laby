using Microsoft.EntityFrameworkCore;

namespace noteApp.Entities;

public class NoteDbContext: DbContext
{
    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public NoteDbContext(DbContextOptions options) : base(options)
    {
    }
}