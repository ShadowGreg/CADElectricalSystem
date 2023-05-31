using Core;
using Microsoft.EntityFrameworkCore;

namespace BDTest; 

public class BaseProjectedObject: DbContext {
    public DbSet<ConsumerFiller> BaseCons => Set<ConsumerFiller>();
    public BaseProjectedObject() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data Source=helloApp.db");
    }
}