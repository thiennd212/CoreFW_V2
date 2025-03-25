using System;
using System.ComponentModel.DataAnnotations;

namespace CoreFW.OrganizationUnits.Dtos;

public class CreateOrganizationUnitDto
{
    public Guid? ParentId { get; set; }

    [Required]
    [StringLength(128)]
    public string DisplayName { get; set; }
} 