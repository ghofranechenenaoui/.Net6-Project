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
<<<<<<< HEAD
            return this._context.Selfies.Include(item => item.Wookie).Include(item2 => item2.Picture).ToList();
        }


        public Selfie AddOne(Selfie item)
        {
            return this._context.Selfies.Add(item).Entity;
        }


        public ICollection<Selfie> GetAll2(int wookieId)
        {
            var Query = this._context.Selfies.Include(item => item.Wookie).AsQueryable();

            if (wookieId > 0)
            {
                Query = Query.Where(item => item.WookieId == wookieId);
            }
            return Query.ToList();

        }


        public Picture AddOnePicture(string url)
        {
            return this._context.pictures.Add(new Picture()
            {
                url = url
            }).Entity;

=======
            return this._context.Selfies.Include(item =>item.Wookie).ToList() ;
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9
        }
        #endregion
        #region properties 
        public IUnitOfWork UnitOfWork => this._context;

        #endregion

    }
}
