using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Elizalde.Data;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Elizalde.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingInfoController : ControllerBase
    {
        private BowlingDbContext _bowlingContext;
        public BowlingInfoController(BowlingDbContext temp)
        {
            _bowlingContext = temp;
        }

        [HttpGet(Name = "GetBowlingInfo")]
        public IEnumerable<BowlingInfo> Get()
        {
            var bowlingList = _bowlingContext.Bowlers.Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks").ToList();
            return bowlingList;
        }
    }
}
