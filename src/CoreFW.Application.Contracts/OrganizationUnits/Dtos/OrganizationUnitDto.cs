using System;
using Volo.Abp.Application.Dtos;

namespace CoreFW.OrganizationUnits.Dtos;

public class OrganizationUnitDto : FullAuditedEntityDto<Guid>
{
    public Guid? ParentId { get; set; }
    public string Code { get; set; }
    public string DisplayName { get; set; }
    public int Level { get; set; }
    public bool IsExpanded { get; set; }
    public int MemberCount { get; set; }
} 