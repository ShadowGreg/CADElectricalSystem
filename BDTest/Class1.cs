﻿using Core;

namespace BDTest;

using Microsoft.EntityFrameworkCore;

public class Class1: DbContext {
    public DbSet<ConsumerController> BaseCons => Set<ConsumerController>();
    public Class1() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data Source=helloApp.db");
    }
}