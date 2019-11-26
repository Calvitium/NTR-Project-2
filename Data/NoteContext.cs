using Microsoft.EntityFrameworkCore;
using NTR02.Models;

namespace NTR02.Data
{
    public class NoteContext : DbContext
    {
        public NoteContext (DbContextOptions<NoteContext> options)
            : base(options)
        {
        }

        public DbSet<Note> Note { get; set; }
    }
}