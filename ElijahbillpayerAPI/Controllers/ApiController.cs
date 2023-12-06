using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ElijahbillpayerAPI.Models;
using ElijahbillpayerAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElijahbillpayerAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ApiController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // KEY ROUTINGS
        [HttpGet]
        [Route("bills")]
        //get all bills
        public async Task<ActionResult<IEnumerable<Bills>>> GetBills()
        {
            return await _dbContext.Bills.ToListAsync();
        }

        //insert bills
        [HttpPost]
        [Route("Addbills")]
        




        [HttpGet]
        [Route("payments")]
        public async Task<ActionResult<IEnumerable<Payments>>> GetPayments()
        {
            return await _dbContext.Payments.ToListAsync();
        }

        // OTHER IMPORTANT ROUTINGS

        [HttpPost]
        [Route("signup")]
        public JsonResult SignUp()
        {
            // Implement your signup logic here
            return new JsonResult("Signup successful");
        }

        [HttpGet]
        [Route("alldataplan")]
        public JsonResult GetData()
        {
            return new JsonResult("All data network");
        }

        [HttpGet]
        [Route("allairtime")]
        public JsonResult GetAirtime()
        {
            return new JsonResult("");
        }

        [HttpGet]
        [Route("allcable")]
        public JsonResult AllCable()
        {
            return new JsonResult("");
        }

        [HttpGet]
        [Route("allnepa")]
        public JsonResult AllNepa()
        {
            return new JsonResult("ama");
        }

        [HttpGet]
        [Route("alluser")]
        public JsonResult AllUser()
        {
            // Implement your logic to retrieve all users
            var users = _dbContext.User.ToList();
            return new JsonResult(users);
        }
    }
}
