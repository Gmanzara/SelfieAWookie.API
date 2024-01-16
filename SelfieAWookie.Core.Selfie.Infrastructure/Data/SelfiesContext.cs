using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Selfie.Domain;
using SelfieAWookie.Core.Selfie.Infrastructure.Data.TypeConfiguration;
using SSelfieAWookie.Core.Selfie.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Selfie.Infrastructure.Data
{
    public class SelfiesContext : DbContext
    {
        public SelfiesContext([NotNullAttribute] DbContextOptions options) : base(options) { }
        public SelfiesContext() :base() { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());
        }
        public DbSet<Selfies> Selfies { get; set; }
        public DbSet <Wookies> Wookies { get; set; }
    }
}
