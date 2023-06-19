using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BewarMC.com.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string FirstName = "";
        public string Lastname = "";
        public string message = "";
        
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            hasData = true;
            FirstName = Request.Form["FirstName"];
            Lastname  = Request.Form["LastName"];
            message = Request.Form["message"];




        }
    }
}
