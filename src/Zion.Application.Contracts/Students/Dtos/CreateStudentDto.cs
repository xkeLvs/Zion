using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zion.Students.Dtos;

public class CreateStudentDto
{
    [Required]
    [StringLength(128)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(128)]
    public string FirstName { get; set; } = string.Empty;

    public string MiddleName { get; set; } = string.Empty;

    [Required]
    [StringLength(128)]
    public string Address { get; set; } = string.Empty;

    [Required]
    public DateTime? BirthDate { get; set; }

    public string Picture { get; set; } = string.Empty;
    public string BirthCertificate { get; set; } = string.Empty;

    [Required]
    [StringLength(128)]
    public string ParentLastName { get; set; } = string.Empty;

    [Required]
    [StringLength(128)]
    public string ParentFirstName { get; set; } = string.Empty;

    public string ParentMiddleName { get; set; } = string.Empty;

    [Required]
    [StringLength(128)]
    public string ContactNumber { get; set; } = string.Empty;
}
