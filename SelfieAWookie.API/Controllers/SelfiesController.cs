using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Selfie.Infrastructure.Data;
using SSelfieAWookie.Core.Selfie.Domain;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SelfieAWookie.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        private readonly SelfiesContext _context = null;
        public SelfiesController(SelfiesContext context) 
        {
            this._context = context;
        }
        #region Publics metthods
        [HttpGet]
        //public IEnumerable<Selfie> TestMoi()
        //{
        //    return Enumerable.Range(1, 10).Select(item => new Selfie() {Id = item }) ;
        //}
        public ActionResult TestMoi()
        {
            //var model =  Enumerable.Range(1, 10).Select(item => new Selfies() {Id = item }) ;
            //return this.StatusCode(StatusCodes.Status204NoContent);

            var model = this._context.Selfies
                        .Include(item => item.Wookie)
                        .Select(item => new {Title = item.Title,
                                WookieId = item.Wookie.Id,
                                NbSelfiesFromWookies = item.Wookie.Selfies.Count})
                        .ToList();
            //var query = from selfie in this._context.Selfies
            //             join wookie in this._context.Wookies
            //             on selfie.WookieId equals wookie.Id
            //             select selfie;
            return this.Ok(model);
        }
        #endregion
    }
}
