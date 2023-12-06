using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ElijahbillpayerAPI.Models;
using ElijahbillpayerAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

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


        // GET: api/Bills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bills>> GetBill(int id)
        {
            var bill = await _dbContext.Bills.FindAsync(id);

            if (bill == null)
            {
                return NotFound();
            }

            return bill;
        }

        // POST: api/Bills
        [HttpPost("AddBills")]
        public async Task<ActionResult<Bills>> PostBill(Bills bill)
        {
            _dbContext.Bills.Add(bill);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBill), new { id = bill.ID }, bill);
        }

        // PUT: api/Bills/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBill(int id, Bills bill)
        {
            if (id != bill.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(bill).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Bills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBill(int id)
        {
            var bill = await _dbContext.Bills.FindAsync(id);
            if (bill == null)
            {
                return NotFound();
            }

            _dbContext.Bills.Remove(bill);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool BillExists(int id)
        {
            return _dbContext.Bills.Any(e => e.ID == id);
        }

        //Lets work on the payment model
        // GET: api/Payments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payments>>> GetPayments()
        {
            return await _dbContext.Payments.ToListAsync();
        }

        // GET: api/Payments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Payments>> GetPayment(int id)
        {
            var payment = await _dbContext.Payments.FindAsync(id);

            if (payment == null)
            {
                return NotFound();
            }

            return payment;
        }

        // POST: api/Payments
        [HttpPost]
        public async Task<ActionResult<Payments>> PostPayment(Payments payment)
        {
            _dbContext.Payments.Add(payment);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPayment), new { id = payment.ID }, payment);
        }

        // PUT: api/Payments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, Payments payment)
        {
            if (id != payment.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(payment).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            var payment = await _dbContext.Payments.FindAsync(id);
            if (payment == null)
            {
                return NotFound();
            }

            _dbContext.Payments.Remove(payment);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool PaymentExists(int id)
        {
            return _dbContext.Payments.Any(e => e.ID == id);
        }

        //Lets work on the Admin Model

        // GET: api/Admin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmins()
        {
            return await _dbContext.Admin.ToListAsync();
        }

        // GET: api/Admin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            var admin = await _dbContext.Admin.FindAsync(id);

            if (admin == null)
            {
                return NotFound();
            }

            return admin;
        }

        // POST: api/Admin
        [HttpPost]
        public async Task<ActionResult<Admin>> PostAdmin(Admin admin)
        {
            _dbContext.Admin.Add(admin);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAdmin), new { id = admin.ID }, admin);
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(int id, Admin admin)
        {
            if (id != admin.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(admin).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Admin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            var admin = await _dbContext.Admin.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            _dbContext.Admin.Remove(admin);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminExists(int id)
        {
            return _dbContext.Admin.Any(e => e.ID == id);
        }


        //Lets Do User model

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _dbContext.User.ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _dbContext.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST: api/User
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _dbContext.User.Add(user);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.ID }, user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(user).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _dbContext.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _dbContext.User.Remove(user);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _dbContext.User.Any(e => e.ID == id);
        }

        //Let do Airtime
























        // GET: api/Priviledges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Priviledges>>> GetPriviledges()
        {
            return await _dbContext.Priviledges.ToListAsync();
        }

        // GET: api/Priviledges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Priviledges>> GetPriviledges(int id)
        {
            var priviledges = await _dbContext.Priviledges.FindAsync(id);

            if (priviledges == null)
            {
                return NotFound();
            }

            return priviledges;
        }

        // POST: api/Priviledges
        [HttpPost]
        public async Task<ActionResult<Priviledges>> PostPriviledges(Priviledges priviledges)
        {
            _dbContext.Priviledges.Add(priviledges);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction("GetPriviledges", new { id = priviledges.ID }, priviledges);
        }

        // PUT: api/Priviledges/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPriviledges(int id, Priviledges priviledges)
        {
            if (id != priviledges.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(priviledges).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriviledgesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Priviledges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePriviledges(int id)
        {
            var priviledges = await _dbContext.Priviledges.FindAsync(id);
            if (priviledges == null)
            {
                return NotFound();
            }

            _dbContext.Priviledges.Remove(priviledges);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool PriviledgesExists(int id)
        {
            return _dbContext.Priviledges.Any(e => e.ID == id);
        }


    }
}


 