using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicDays.Models;

namespace MusicDays.Pages.Audit
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly MusicDays.Models.MusicDaysContext _context;

        public IndexModel(MusicDays.Models.MusicDaysContext context)
        {
            _context = context;
        }

        public IList<AuditRecord> AuditRecord { get;set; }

        public async Task OnGetAsync()
        {
            AuditRecord = await _context.AuditRecords.ToListAsync();
        }
    }
}
