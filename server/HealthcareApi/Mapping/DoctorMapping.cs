using HealthcareApi.DTOs.Doctor;
using HealthcareApi.Models;

namespace HealthcareApi.Mapping;

public static class DoctorMapping
{
  public static ViewDoctorDto ToDto(this Doctor entity)
  {
    return new ViewDoctorDto
    {
      Id = entity.Id,
      FirstName = entity.FirstName,
      LastName = entity.LastName,
    };
  }

  public static Doctor ToEntity(this AddDoctorDto dto)
  {
    return new Doctor
    {
      FirstName = dto.FirstName,
      LastName = dto.LastName,
    };
  }
}
