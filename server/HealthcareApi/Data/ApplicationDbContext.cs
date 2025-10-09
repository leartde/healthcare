using HealthcareApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthcareApi.Data;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
    base(options){}
  
  public DbSet<Patient> Patients { get; set; } = null!;
  public DbSet<Doctor> Doctors { get; set; } = null!;
  public DbSet<ClinicalRecord> ClinicalRecords { get; set; } = null!;
  public DbSet<HeartDiseasePrediction> HeartDiseasePredictions { get; set; } = null!;


}
