using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSelfieAWookie.Core.Selfie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Selfie.Infrastructure.Data.TypeConfiguration
{
    internal class SelfieEntityTypeConfiguration : IEntityTypeConfiguration<Selfies>
    {
        public void Configure(EntityTypeBuilder<Selfies> builder)
        {
            builder.ToTable(nameof(Selfies));
            builder.HasKey(item => item.Id);
            builder.HasOne(item => item.Wookie)
                   .WithMany(item => item.Selfies);

        }
    }
}
