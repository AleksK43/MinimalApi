using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<City> Cities => Set<City>();
    public DbSet<Community> Communities => Set<Community>(); 
    public DbSet<County> Counties => Set<County>();
    public DbSet<Province> Provinces => Set<Province>(); 

}
