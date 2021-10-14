using System;
using Microsoft.EntityFrameworkCore;

namespace MysqlEFCoreDemo.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
