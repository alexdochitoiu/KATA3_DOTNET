using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public interface IDatabaseContext
    {
        DbSet<Book> Books { get; set; }
        int SaveChanges();
    }
}