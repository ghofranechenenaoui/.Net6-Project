using Microsoft.EntityFrameworkCore;
using SelfieAwwokieCore.Selfies.Domain;
using SelfieAwwokieCore.Selfies.Infrastructure.Data;
using SelfieWookie.Core.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwwokieCore.Selfies.Infrastructure.Repositories
{
    public class DefaultSelfieRepositories : ISelfieRepository
    {

        #region Fields

        private readonly SelfieContext? _context = null;

        #endregion


        #region constructors
        public DefaultSelfieRepositories(SelfieContext context)
        {
            this._context = context;
        }

        #endregion

        #region public methods
        public ICollection<Selfie> GetAll()
        {
            return this._context.Selfies.Include(item =>item.Wookie).ToList() ;
        }
        #endregion
        #region properties 
        public IUnitOfWork UnitOfWork => this._context;

        #endregion

    }
}
