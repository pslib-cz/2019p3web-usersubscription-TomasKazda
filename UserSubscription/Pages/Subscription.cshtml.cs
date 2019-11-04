using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UserSubscription.Models;
using UserSubscription.Services;

namespace UserSubscription.Pages
{
    public class SubscriptionModel : PageModel
    {
        private ISubscriptionStorage _ss;
        private CountriesProvider _cp;


        [TempData]
        public string ErrorMessage { get; set; }
        [TempData]
        public string SuccessMessage { get; set; }

        [BindProperty]
        public Subscription Input { get; set; }

        public List<SelectListItem> Countries { get; set; }

        public SubscriptionModel(ISubscriptionStorage ss, CountriesProvider cp)
        {
            _ss = ss;
            _cp = cp;

            Countries = new List<SelectListItem>();
            foreach (var item in cp.EFTA)
            {
                Countries.Add(new SelectListItem(text: item.Value, value: item.Key));
            }
            foreach (var item in cp.EUMembers)
            {
                Countries.Add(new SelectListItem(text: item.Value, value: item.Key));
            }
        }

        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                _ss.Add(Input);
                SuccessMessage = $"{Input.Email} byl přidán k odběru";

                return RedirectToPage("Index");
            }
            ErrorMessage = $"Něco se nepovedlo - sleduj výpis ;-)";
            SuccessMessage = null;
            return Page();
        }
    }
}