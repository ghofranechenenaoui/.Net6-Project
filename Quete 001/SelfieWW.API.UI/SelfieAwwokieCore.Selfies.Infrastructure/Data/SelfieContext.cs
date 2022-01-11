using Microsoft.EntityFrameworkCore;
using SelfieAwwokieCore.Selfies.Domain;
using SelfieAwwokieCore.Selfies.Infrastructure.Data.TypeConfiguration;
using SelfieWookie.Core.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwwokieCore.Selfies.Infrastructure.Data
{
    

   
    public class SelfieContext :DbContext, IUnitOfWork
    {

        #region constructeur 
        public SelfieContext([NotNullAttribute] DbContextOptions options) : base(options) { }

        public SelfieContext() : base() { }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());
        }

        public DbSet<Selfie>? Selfies { get; set; }
        public DbSet<Wookie>? wookies { get; set; }
<<<<<<< HEAD
        public DbSet<Picture>? pictures { get; set; }

=======
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9
    }
}
