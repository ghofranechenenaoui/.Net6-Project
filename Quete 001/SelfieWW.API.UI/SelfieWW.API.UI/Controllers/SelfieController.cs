using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfieAwwokieCore.Selfies.Domain;
using SelfieAwwokieCore.Selfies.Infrastructure.Data;
using SelfieWW.API.UI.Application.DTOs;

namespace SelfieWW.API.UI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SelfieController : ControllerBase
        {
        #region Fields 
        private readonly ISelfieRepository _repository = null; 
        #endregion

        #region Constructeur

        public SelfieController (ISelfieRepository repository)
        {
             this._repository = repository;

        }
        #endregion


        //    #region public methods
        //    [HttpGet]
        //    public IEnumerable<Selfie> TestAMoi()
        //    {
        //        return Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });
        //    }

        //    #endregion

        #region public methods
        [HttpGet]

        //The ActionResult types represent various HTTP status codes.
        public IActionResult TestAMoi()
    {
            // var model=  Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });

            // return this.StatusCode(StatusCodes.Status204NoContent);

            //var model = this._context.Selfies.ToList();
            // var query = from Wookie in this._context.Selfies select Wookie;
           // with this we can not show the wookie so another solution
           // var model = this._context.Selfies.Include(item => item.Wookie).Select(item => new {Title = item.Title , WookieId = item.Wookie.Id , NbSelfieFromOneWookie = item.Wookie.Selfies.Count() }).ToList();
           // include les information sur les wookies 


            var selfieList = this._repository.GetAll();

            var model = selfieList.Select(item => new SelfieResumeDto() { Title = item.Title, WookieId = item.Wookie.Id, NbrSelfiesFromWooki = (item.Wookie?.Selfies?.Count()).GetValueOrDefault(0)}).ToList();




            return this.Ok(model);
    }

    #endregion
}
}
