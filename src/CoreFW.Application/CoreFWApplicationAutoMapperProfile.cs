using AutoMapper;
using CoreFW.OrganizationUnits.Dtos;
using Volo.Abp.Identity;

namespace CoreFW;

public class CoreFWApplicationAutoMapperProfile : Profile
{
    public CoreFWApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<OrganizationUnit, OrganizationUnitDto>();
    }
}
