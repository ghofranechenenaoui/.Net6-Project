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
    class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Wookie>

    #region public methods
  
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Wookie> builder)
        {
            builder.ToTable("Wookie");
        }
        #endregion
    }
    #endregion
}
