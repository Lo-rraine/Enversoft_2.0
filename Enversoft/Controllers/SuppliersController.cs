using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Enversoft.Data;
using Enversoft.Models;

namespace Enversoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SuppliersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Suppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetSuppliers()
        {
            return await _context.Suppliers.ToListAsync();
        }

        // GET: api/Suppliers/search
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Supplier>>> SearchSuppliers([FromQuery(Name = "name")] string companyName)
        {
            var suppliers = await _context.Suppliers
                .Where(s => s.Name.ToLower().Contains(companyName.ToLower()))
                .Select(s => new {s.TelelphoneNo })
                .ToListAsync();

            return Ok(suppliers);
        }

        // GET: api/Suppliers
        [HttpGet("{code}")]
        public async Task<ActionResult<Supplier>> GetSupplier(int code)
        {
            var supplier = await _context.Suppliers.FindAsync(code);

            if (supplier == null)
            {
                return NotFound();
            }

            return supplier;
        }

        // POST: api/Suppliers
        [HttpPost]
        public async Task<ActionResult<Supplier>> PostSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupplierExists(supplier.Code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupplier", new { id = supplier.Code }, supplier);
        }

        private bool SupplierExists(int code)
        {
            return _context.Suppliers.Any(e => e.Code == code);
        }
    }
}
