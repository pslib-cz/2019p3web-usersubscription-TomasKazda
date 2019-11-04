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

        /* TODO: Messages mechanics */
        /* TODO: Select property for coutries */
        [BindProperty]
        public Subscription Input { get; set; }

        public SubscriptionModel(ISubscriptionStorage ss, CountriesProvider cp)
        {
            _ss = ss;
            _cp = cp;
            /* TODO: adding countries to select */ 
        }

        public void OnGet()
        {
            /* TODO: adding countries to select, or I can do it here, GD */
        }

        public IActionResult OnPost()
        {
            /* TODO Send confirmation messages "Registrace se podařila." "Registrace se nepodařila." */
            if (ModelState.IsValid)
            {
                _ss.Add(Input);
                
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}