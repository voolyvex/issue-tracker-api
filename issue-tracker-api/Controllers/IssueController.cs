using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using issue_tracker_api.Data;
using issue_tracker_api.Models;

namespace issue_tracker_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IssueDbContext _context;

        public IssueController(IssueDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Issue>> Get()
            => await _context.Issues.ToListAsync();

    }
}
