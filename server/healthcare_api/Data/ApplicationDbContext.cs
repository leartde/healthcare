using healthcare_api.Models;
using healthcare_api.Models;
using Microsoft.EntityFrameworkCore;

namespace healthcare_api.Data;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
    base(options){}
  
  public DbSet<Patient>? Patients { get; set; }
  public DbSet<Doctor>? Doctors { get; set; }
  public DbSet<MedicalHistory>? MedicalHistories { get; set; }
}
