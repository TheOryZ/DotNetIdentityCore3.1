using Example.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccess.Concrete.EntityFramework
{
    public class ExampleContext : IdentityDbContext<AppUser, AppRole, string> 
        //DbContext yerine Identity kullandığımız için IdentityDbContext kullanıyoruz. eklediğimiz manuel AppUser ve AppRole classlarını veriyoruz. son olarak bizden bir key istiyor.
    {
        private static string connectionString { get; set; }
        public DbSet<Project> Projects { get; set; }
        public ExampleContext() { }

        public ExampleContext(DbContextOptions<ExampleContext> options) : base(options)
        {
            if (connectionString == null)
            {
                var extension = options.FindExtension<SqlServerOptionsExtension>();

                connectionString = extension.ConnectionString;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseSqlServer(@"Server = (LocalDB)\\MSSQLLocalDB; Database = IdentityExampleDatabase; Trusted_Connection = true");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>(entity => entity.ToTable("User"));
            builder.Entity<AppRole>(entity => entity.ToTable("Role"));
            builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable("UserRole"));
            builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
            builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
            builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
            builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });
        }
    }
}
