using healthcare_api.Data;
using healthcare_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace healthcare_api.Controllers;

[ApiController]
[Route("api/patients")]
public class PatientController : ControllerBase
{
  private readonly ApplicationDbContext _context;

  public PatientController(ApplicationDbContext context)
  {
    _context = context;
  }
  [HttpGet]
  public async Task<IActionResult> GetPatients()
  {
    var patients = await _context.Patients?.ToListAsync()!;
    return Ok(patients);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetPatient(int id)
  {
    if (id < 1) return BadRequest("Invalid id");
    if (_context.Patients is null) throw new NullReferenceException();
    var patient = await _context.Patients.FindAsync(id);
    if (patient is null) return BadRequest($"Patient with id: {id} not found");
    return Ok(patient);
  }

  [HttpPost]
  public async Task<IActionResult> Create(Patient patient)
  {
    if (_context.Patients is null) throw new NullReferenceException();
      await _context.Patients.AddAsync(patient);
    await _context.SaveChangesAsync();
    return Ok(patient);
  }
}
