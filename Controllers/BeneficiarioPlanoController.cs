using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.LaerteTeste2020.Models;

namespace Api.LaerteTeste2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioPlanoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BeneficiarioPlanoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // PUT: api/Beneficiarios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBeneficiario(int id, Beneficiario beneficiario)
        {
            if (id != beneficiario.BeneficiarioId)
            {
                return BadRequest();
            }

            _context.Entry(beneficiario).Property(p => p.PlanoId).IsModified = true;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeneficiarioExists(id))
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


        private bool BeneficiarioExists(int id)
        {
            return _context.Beneficiario.Any(e => e.BeneficiarioId == id);
        }
    }
}
