using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using TransactionManagementAPI.Models;

namespace TransactionManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientTransactionController : ControllerBase
    {
        private readonly APIDbContex _context;

        public ClientTransactionController(APIDbContex context)
        {
            _context = context;
        }

        // GET: api/ClientTransaction
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientTransaction>>> Getclient_transaction()
        {
          if (_context.client_transaction == null)
          {
              return NotFound();
          }
            return await _context.client_transaction.ToListAsync();
        }

        // GET: api/ClientTransaction/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientTransaction>> GetClientTransaction(long id)
        {
          if (_context.client_transaction == null)
          {
              return NotFound();
          }
            var clientTransaction = await _context.client_transaction.FindAsync(id);

            if (clientTransaction == null)
            {
                return NotFound();
            }
           

            return clientTransaction;
        }

        // PUT: api/ClientTransaction/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientTransaction(long id, ClientTransaction clientTransaction)
        {
            if (id != clientTransaction.TransactionId)
            {
                return BadRequest();
            }

            _context.Entry(clientTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientTransactionExists(id))
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

        // POST: api/ClientTransaction
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClientTransaction>> PostClientTransaction(ClientTransaction clientTransaction)
        {
          if (_context.client_transaction == null)
          {
              return Problem("Entity set 'APIDbContex.client_transaction'  is null.");
          }
           
                _context.client_transaction.Add(clientTransaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientTransaction", new { id = clientTransaction.TransactionId }, clientTransaction);
        }

        // DELETE: api/ClientTransaction/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientTransaction(long id)
        {
            if (_context.client_transaction == null)
            {
                return NotFound();
            }
            var clientTransaction = await _context.client_transaction.FindAsync(id);
            if (clientTransaction == null)
            {
                return NotFound();
            }

            _context.client_transaction.Remove(clientTransaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientTransactionExists(long id)
        {
            return (_context.client_transaction?.Any(e => e.TransactionId == id)).GetValueOrDefault();
        }
    }
}
