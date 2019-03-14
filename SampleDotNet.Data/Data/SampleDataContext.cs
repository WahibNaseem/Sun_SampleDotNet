using System;
using Microsoft.EntityFrameworkCore;
using SampleDotNet.Core.Domain;

namespace SampleDotNet.Data.Data
{
    public class SampleDataContext:DbContext
    {
        public SampleDataContext(DbContextOptions<SampleDataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        

    }
}