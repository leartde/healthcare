using HealthcareApi.Data;
using HealthcareApi.DTOs.ClinicalRecord;
using HealthcareApi.Mapping;
using MachineLearningModel;
using MachineLearningModel.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthcareApi.Controllers;

[ApiController]
[Route("api/clinicalRecords")]
public class ClinicalRecordController : ControllerBase
{
  private readonly ApplicationDbContext _context;
  public ClinicalRecordController(ApplicationDbContext context)
  {
    _context = context;
  }

  [HttpGet]
  public async Task<IActionResult> GetClinicalRecords()
  {
    var clinicalRecords = await _context.ClinicalRecords
      .Include(m => m.Patient)
      .Include(m => m.RecordedByDoctor)
      .ToListAsync();
    return Ok(clinicalRecords.Select(m => m.ToDto()));
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetClinicalRecord(int id)
  {
    if (id < 1) return BadRequest("Invalid id.");
    var clinicalRecord = await _context.ClinicalRecords.FindAsync(id);
    if (clinicalRecord is null) return BadRequest($"Couldn't find clinical record with id: {id}");
    return Ok(clinicalRecord.ToDto());
  }

  [HttpPost]
  public async Task<IActionResult> CreateClinicalRecord(AddClinicalRecordDto dto)
  {
    var clinicalRecordToAdd = dto.ToEntity();
    await _context.ClinicalRecords.AddAsync(clinicalRecordToAdd);
    await _context.SaveChangesAsync();
    return Ok(clinicalRecordToAdd.ToDto());
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteClinicalRecord(int id)
  {
    if (id < 1) return BadRequest("Invalid id.");
    var clinicalRecord = await _context.ClinicalRecords.FindAsync(id);
    if (clinicalRecord is null) return BadRequest($"Couldn't find clinical record with id: {id}");
    _context.ClinicalRecords.Remove(clinicalRecord);
    await _context.SaveChangesAsync();
    return Ok($"Clinical record with id: {id} successfully deleted.");
  }
}
