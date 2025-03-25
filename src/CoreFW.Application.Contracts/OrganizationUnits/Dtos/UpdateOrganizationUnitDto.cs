using System.ComponentModel.DataAnnotations;

namespace CoreFW.OrganizationUnits.Dtos;

public class UpdateOrganizationUnitDto
{
    [Required]
    [StringLength(128)]
    public string DisplayName { get; set; }
} 