using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace DemoRazorPagesJsonAPI.Pages.API
{
    public class UserWithRouteParamModel : PageModel
    {
        public IActionResult OnGet(string name, int id)
        {
            var userInfoList = new List<UserInfoModel>
            {
                new UserInfoModel{ Id = 1, Name = "Poy Chang", Email = "poy@mail.com"},
                new UserInfoModel{ Id = 2, Name = "foo", Email = "foo@mail.com"},
                new UserInfoModel{ Id = 3, Name = "bar", Email = "bar@mail.com"}
            };

            return new JsonResult(userInfoList.Where(p => p.Name == name || p.Id == id));
        }
    }
}