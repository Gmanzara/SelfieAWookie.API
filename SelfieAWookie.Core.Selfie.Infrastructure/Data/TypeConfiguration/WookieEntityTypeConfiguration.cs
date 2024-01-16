using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelfieAWookie.Core.Selfie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Selfie.Infrastructure.Data.TypeConfiguration
{
    public class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Wookies>
    {
        public void Configure(EntityTypeBuilder<Wookies> builder)
        {
            builder.ToTable(nameof(Wookies)) ;
        }
    }
}
