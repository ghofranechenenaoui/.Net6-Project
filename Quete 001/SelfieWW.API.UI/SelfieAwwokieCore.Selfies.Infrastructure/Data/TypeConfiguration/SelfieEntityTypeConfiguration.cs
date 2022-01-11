using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelfieAwwokieCore.Selfies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwwokieCore.Selfies.Infrastructure.Data.TypeConfiguration
{
    class SelfieEntityTypeConfiguration : IEntityTypeConfiguration<Selfie>
    #region public methods
  
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Selfie> builder)
        {
            builder.ToTable("Selfie");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Wookie).WithMany(x => x.Selfies);

        }
        #endregion
    }
    #endregion
}
