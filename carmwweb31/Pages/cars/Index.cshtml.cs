using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carmwweb31.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace carmwweb31.Pages.cars
{
    public class IndexModel : PageModel
    {
        private carmangerContext _db;
        public void OnGet()
        {
            Cars = _db.Cars.ToList();
            Sysusers = _db.Sysusers.ToList();
        }
        public IndexModel(carmangerContext db)
        {
            _db = db;
        }
        public IEnumerable<Cars> Cars { get; set; }
        public IEnumerable<Sysusers> Sysusers { get; set; }
    }
}
