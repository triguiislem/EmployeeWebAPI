using EmployeeWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartementController : ControllerBase
    {
        private readonly TP7Context context;

        public DepartementController(TP7Context context) {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() { 
            
        return Ok(await context.Departments.ToListAsync());
        
        
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByID(int id)
        {
            Departement departement=await context.Departments.FindAsync(id);
            if (departement == null) {
                return BadRequest("departement not exist");
            }
            return Ok(departement);


        }
        [HttpGet("{name:alpha}")]
        public async Task<IActionResult> GetByNAME(string name)
        {
            Departement departement = await context.Departments.Where(d=> d.DepartmentName==name).FirstOrDefaultAsync();
            if (departement == null)
            {
                return BadRequest("departement not exist");
            }
            return Ok(departement);


        }

        [HttpPost]
        public async Task<IActionResult> Create(Departement departement)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(context.Departments.Where(d => d.DepartmentName == departement.DepartmentName).Any())
            {
                ModelState.AddModelError("", "Already Exist");
                return BadRequest(ModelState);
            }
            context.Departments.AddAsync(departement);
            context.SaveChanges();


            return CreatedAtAction(nameof(GetByID), new { id = departement.DepartmentId },departement);


        }



    }
}
