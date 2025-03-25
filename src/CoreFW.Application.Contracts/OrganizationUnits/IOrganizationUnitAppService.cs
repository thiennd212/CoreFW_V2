using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreFW.OrganizationUnits.Dtos;
using Volo.Abp.Application.Services;

namespace CoreFW.OrganizationUnits;

public interface IOrganizationUnitAppService : IApplicationService
{
    Task<List<OrganizationUnitDto>> GetListAsync();
    
    Task<OrganizationUnitDto> CreateAsync(CreateOrganizationUnitDto input);
    
    Task<OrganizationUnitDto> UpdateAsync(Guid id, UpdateOrganizationUnitDto input);
    
    Task DeleteAsync(Guid id);
    
    Task MoveAsync(Guid id, Guid? parentId);
} 