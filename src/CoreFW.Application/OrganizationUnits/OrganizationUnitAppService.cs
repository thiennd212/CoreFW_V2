using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreFW.OrganizationUnits.Dtos;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace CoreFW.OrganizationUnits;

[Authorize(IdentityPermissions.Users.Default)]
public class OrganizationUnitAppService : ApplicationService, IOrganizationUnitAppService
{
    private readonly IOrganizationUnitRepository _organizationUnitRepository;
    private readonly OrganizationUnitManager _organizationUnitManager;

    public OrganizationUnitAppService(
        IOrganizationUnitRepository organizationUnitRepository,
        OrganizationUnitManager organizationUnitManager)
    {
        _organizationUnitRepository = organizationUnitRepository;
        _organizationUnitManager = organizationUnitManager;
    }

    public async Task<List<OrganizationUnitDto>> GetListAsync()
    {
        var organizationUnits = await _organizationUnitRepository.GetListAsync();
        
        return organizationUnits
            .Select(ou => new OrganizationUnitDto
            {
                Id = ou.Id,
                ParentId = ou.ParentId,
                Code = ou.Code,
                DisplayName = ou.DisplayName,
                Level = ou.Code?.Split('.')?.Length ?? 0,
                CreationTime = ou.CreationTime,
                CreatorId = ou.CreatorId,
                LastModificationTime = ou.LastModificationTime,
                LastModifierId = ou.LastModifierId,
                IsDeleted = ou.IsDeleted,
                DeleterId = ou.DeleterId,
                DeletionTime = ou.DeletionTime
            })
            .ToList();
    }

    [Authorize(IdentityPermissions.Users.Create)]
    public async Task<OrganizationUnitDto> CreateAsync(CreateOrganizationUnitDto input)
    {
        var organizationUnit = new OrganizationUnit(GuidGenerator.Create(), input.DisplayName, input.ParentId);
        await _organizationUnitManager.CreateAsync(organizationUnit);
        await CurrentUnitOfWork.SaveChangesAsync();
        return ObjectMapper.Map<OrganizationUnit, OrganizationUnitDto>(organizationUnit);
    }

    [Authorize(IdentityPermissions.Users.Update)]
    public async Task<OrganizationUnitDto> UpdateAsync(Guid id, UpdateOrganizationUnitDto input)
    {
        var organizationUnit = await _organizationUnitRepository.GetAsync(id);
        organizationUnit.DisplayName = input.DisplayName;
        await _organizationUnitManager.UpdateAsync(organizationUnit);
        return ObjectMapper.Map<OrganizationUnit, OrganizationUnitDto>(organizationUnit);
    }

    [Authorize(IdentityPermissions.Users.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _organizationUnitManager.DeleteAsync(id);
    }

    [Authorize(IdentityPermissions.Users.Update)]
    public async Task MoveAsync(Guid id, Guid? parentId)
    {
        await _organizationUnitManager.MoveAsync(id, parentId);
    }
} 