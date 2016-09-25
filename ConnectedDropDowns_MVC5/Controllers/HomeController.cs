using ConnectedDropDowns_MVC5.Models;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace ConnectedDropDowns_MVC5.Controllers
{
    public class HomeController : Controller
    {
        DropDownDbContext db = new DropDownDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Submit(DropViewModel model)
        {
            return View(model);
        }

        public ActionResult Country(DropViewModel model)
        {
            IEnumerable<SelectListItem> countries = GetCountries();
            model.Countries = countries;
            return PartialView(model);
        }
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public PartialViewResult State(DropViewModel model)
        {
            string countryId = db.Countries.Where(x => x.Name == model.CountryName).Select(x => x.ID).FirstOrDefault();
            IEnumerable<SelectListItem> states = GetCountryStates(countryId);
            model.States = states;
            return PartialView(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult City(DropViewModel model)
        {
            string stateId = db.States.Where(x => x.Name == model.StateName).Select(x => x.ID).FirstOrDefault();
            IEnumerable<SelectListItem> cities = GetStateCities(stateId);
            model.Cities = cities;
            return PartialView(model);
        }

        public IEnumerable<SelectListItem> GetCountries()
        {
            List<SelectListItem> countryNames = new List<SelectListItem>();
            var countries = db.Countries.ToList();
            foreach (var country in countries)
            {
                countryNames.Add(new SelectListItem { Text = country.Name, Value = country.Name });
            }
            IEnumerable<SelectListItem> nameAdded = countryNames.GroupBy(x => x.Text).Select(x => x.FirstOrDefault()).ToList<SelectListItem>().OrderBy(x => x.Text);
            return nameAdded;
        }

        public IEnumerable<SelectListItem> GetCountryStates(string id)
        {
            List<SelectListItem> stateNames = new List<SelectListItem>();
            var states = db.States.Where(x => x.CountryId == id).ToList();
            foreach (var state in states)
            {
                stateNames.Add(new SelectListItem { Text = state.Name, Value = state.Name });
            }
            IEnumerable<SelectListItem> nameAdded =
                stateNames.GroupBy(x => x.Text).Select(x => x.FirstOrDefault()).ToList<SelectListItem>().OrderBy(x => x.Text);
            return nameAdded;
        }

        public IEnumerable<SelectListItem> GetStateCities(string id)
        {
            List<SelectListItem> cityNames = new List<SelectListItem>();
            var cities = db.Cities.Where(x => x.StateId == id).ToList();
            foreach (var city in cities)
            {
                cityNames.Add(new SelectListItem { Text = city.Name, Value = city.Name });
            }
            IEnumerable<SelectListItem> nameAdded =
                cityNames.GroupBy(x => x.Text).Select(x => x.FirstOrDefault()).ToList<SelectListItem>().OrderBy(x => x.Text);
            return nameAdded;
        }

    }
}