using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using petrlitvinov.Models;

namespace petrlitvinov.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private PhotoContext db;
        public SampleDataController(PhotoContext context)
        {
            db = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<Photo> Photos()
        {
            return db.Photos.ToList();
        }
    }
}
