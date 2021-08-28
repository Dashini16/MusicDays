using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MusicDays.Pages.Musics
{
    [Authorize(Roles = "User")]
    public class DojoCatModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
