using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace DemoRazorPagesJsonAPI.Pages.API
{
    public class UserModel : PageModel
    {
        private readonly List<UserInfoModel> _data = new List<UserInfoModel>
        {
            new UserInfoModel{ Id = 1, Name = "Poy Chang", Email = "poy@mail.com"},
            new UserInfoModel{ Id = 2, Name = "foo2", Email = "foo@mail.com"},
            new UserInfoModel{ Id = 3, Name = "bar2", Email = "bar@mail.com"}
        };

        public IActionResult OnGet()
        {
            return new JsonResult(_data);
        }

        // OnGet() 和使用 QueryString 的 OnGet(string name) 方法，兩者只能擇一使用
        //public IActionResult OnGet(string name)
        //{
        //    return new JsonResult(_data.Where(p => p.Name == name));
        //}
    }

    [Produces("application/json")]
    [Route("api/user2")]
    public class UserController : Controller
    {
        private readonly List<UserInfoModel> _data = new List<UserInfoModel>
        {
            new UserInfoModel{ Id = 1, Name = "Poy Chang", Email = "poy@mail.com"},
            new UserInfoModel{ Id = 2, Name = "foo2", Email = "foo@mail.com"},
            new UserInfoModel{ Id = 3, Name = "bar2", Email = "bar@mail.com"}
        };

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_data);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return new JsonResult(_data);
        }
    }
}