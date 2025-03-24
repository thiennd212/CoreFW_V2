This file is a merged representation of the entire codebase, combined into a single document by Repomix. The content has been processed where security check has been disabled.

# File Summary

## Purpose
This file contains a packed representation of the entire repository's contents.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

## File Format
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Multiple file entries, each consisting of:
  a. A header with the file path (## File: path/to/file)
  b. The full contents of the file in a code block

## Usage Guidelines
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

## Notes
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Security check has been disabled - content may contain sensitive information

## Additional Info

# Directory Structure
```
.cursor/
  rules/
    abp-rule.mdc
    chunk-250.mdc
src/
  CoreFW.Application/
    Properties/
      AssemblyInfo.cs
    CoreFW.Application.csproj
    CoreFWApplicationAutoMapperProfile.cs
    CoreFWApplicationModule.cs
    CoreFWAppService.cs
  CoreFW.Application.Contracts/
    Permissions/
      CoreFWPermissionDefinitionProvider.cs
      CoreFWPermissions.cs
    CoreFW.Application.Contracts.csproj
    CoreFWApplicationContractsModule.cs
    CoreFWDtoExtensions.cs
  CoreFW.Blazor/
    Components/
      Pages/
        _ViewImports.cshtml
        Index.razor
        Index.razor.cs
        Index.razor.css
      App.razor
      Routes.razor
    Menus/
      CoreFWMenuContributor.cs
      CoreFWMenus.cs
    Pages/
      _Host.cshtml
    Properties/
      launchSettings.json
    wwwroot/
      images/
        getting-started/
          discord.svg
          instagram.svg
          stack-overflow.svg
          x-white.svg
          youtube.svg
      blazor-global-styles.css
      global-styles.css
    _Imports.razor
    abp.resourcemapping.js
    appsettings.Development.json
    appsettings.json
    appsettings.secrets.json
    CoreFW.Blazor.csproj
    CoreFWBlazorModule.cs
    CoreFWBrandingProvider.cs
    CoreFWComponentBase.cs
    package.json
    Program.cs
    web.config
  CoreFW.DbMigrator/
    appsettings.json
    appsettings.secrets.json
    CoreFW.DbMigrator.csproj
    CoreFWDbMigratorModule.cs
    DbMigratorHostedService.cs
    Program.cs
  CoreFW.Domain/
    Data/
      CoreFWDbMigrationService.cs
      ICoreFWDbSchemaMigrator.cs
      NullCoreFWDbSchemaMigrator.cs
    OpenIddict/
      OpenIddictDataSeedContributor.cs
    Properties/
      AssemblyInfo.cs
    Settings/
      CoreFWSettingDefinitionProvider.cs
      CoreFWSettings.cs
    CoreFW.Domain.csproj
    CoreFWConsts.cs
    CoreFWDomainModule.cs
  CoreFW.Domain.Shared/
    Localization/
      CoreFW/
        ar.json
        cs.json
        de.json
        en-GB.json
        en.json
        es.json
        fi.json
        fr.json
        hi.json
        hr.json
        hu.json
        is.json
        it.json
        nl.json
        pl-PL.json
        pt-BR.json
        ro-RO.json
        ru.json
        sk.json
        sl.json
        sv.json
        tr.json
        vi.json
        zh-Hans.json
        zh-Hant.json
      CoreFWResource.cs
    MultiTenancy/
      MultiTenancyConsts.cs
    CoreFW.Domain.Shared.csproj
    CoreFWDomainErrorCodes.cs
    CoreFWDomainSharedModule.cs
    CoreFWGlobalFeatureConfigurator.cs
    CoreFWModuleExtensionConfigurator.cs
  CoreFW.EntityFrameworkCore/
    EntityFrameworkCore/
      CoreFWDbContext.cs
      CoreFWDbContextFactory.cs
      CoreFWEfCoreEntityExtensionMappings.cs
      CoreFWEntityFrameworkCoreModule.cs
      EntityFrameworkCoreCoreFWDbSchemaMigrator.cs
    Migrations/
      20250321103701_Initial.cs
      20250321103701_Initial.Designer.cs
      CoreFWDbContextModelSnapshot.cs
    Properties/
      AssemblyInfo.cs
    CoreFW.EntityFrameworkCore.csproj
  CoreFW.HttpApi/
    Controllers/
      CoreFWController.cs
    Models/
      Test/
        TestModel.cs
    CoreFW.HttpApi.csproj
    CoreFWHttpApiModule.cs
  CoreFW.HttpApi.Client/
    CoreFW.HttpApi.Client.csproj
    CoreFWHttpApiClientModule.cs
test/
  CoreFW.Application.Tests/
    Samples/
      SampleAppServiceTests.cs
    CoreFW.Application.Tests.csproj
    CoreFWApplicationTestBase.cs
    CoreFWApplicationTestModule.cs
  CoreFW.Domain.Tests/
    Samples/
      SampleDomainTests.cs
    CoreFW.Domain.Tests.csproj
    CoreFWDomainTestBase.cs
    CoreFWDomainTestModule.cs
  CoreFW.EntityFrameworkCore.Tests/
    EntityFrameworkCore/
      Applications/
        EfCoreSampleAppServiceTests.cs
      Domains/
        EfCoreSampleDomainTests.cs
      Samples/
        SampleRepositoryTests.cs
      CoreFWEntityFrameworkCoreCollection.cs
      CoreFWEntityFrameworkCoreCollectionFixtureBase.cs
      CoreFWEntityFrameworkCoreFixture.cs
      CoreFWEntityFrameworkCoreTestBase.cs
      CoreFWEntityFrameworkCoreTestModule.cs
    CoreFW.EntityFrameworkCore.Tests.csproj
  CoreFW.HttpApi.Client.ConsoleTestApp/
    appsettings.json
    appsettings.secrets.json
    ClientDemoService.cs
    ConsoleTestAppHostedService.cs
    CoreFW.HttpApi.Client.ConsoleTestApp.csproj
    CoreFWConsoleApiClientModule.cs
    Program.cs
  CoreFW.TestBase/
    Security/
      FakeCurrentPrincipalAccessor.cs
    CoreFW.TestBase.csproj
    CoreFWTestBase.cs
    CoreFWTestBaseModule.cs
    CoreFWTestConsts.cs
    CoreFWTestDataSeedContributor.cs
.gitattributes
.gitignore
.prettierrc
common.props
CoreFW.sln
CoreFW.sln.DotSettings
CoreRequiment.txt
NuGet.Config
README.md
```

# Files

## File: .cursor/rules/abp-rule.mdc
````
---
description: 
globs: 
alwaysApply: true
---
# ABP .NET Development Rules

You are a senior .NET backend developer and an expert in C#, ASP.NET Core, ABP Framework, and Entity Framework Core. You are using ABP Framework version 8.3.4.

## Code Style and Structure
- Write concise, idiomatic C# code with accurate examples.
- Follow ABP Framework’s recommended folder and module structure (e.g., *.Application, *.Domain, *.EntityFrameworkCore, *.HttpApi).
- Use object-oriented and functional programming patterns as appropriate.
- Prefer LINQ and lambda expressions for collection operations.
- Use descriptive variable and method names (e.g., `IsUserSignedIn`, `CalculateTotal`).
- Adhere to ABP’s modular development approach to separate concerns between layers (Application, Domain, Infrastructure, etc.).

## Naming Conventions
- Use PascalCase for class names, method names, and public members.
- Use camelCase for local variables and private fields.
- Use UPPERCASE for constants.
- Prefix interface names with "I" (e.g., `IUserService`).

## C# and .NET Usage
- Use C# 10+ features when appropriate (e.g., record types, pattern matching, null-coalescing assignment).
- Leverage built-in ASP.NET Core features and middleware, as well as ABP’s modules and features (e.g., Permission Management, Setting Management).
- Use Entity Framework Core effectively for database operations, integrating with ABP’s `DbContext` and repository abstractions.

## Syntax and Formatting
- Follow the C# Coding Conventions (https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).
- Use C#’s expressive syntax (e.g., null-conditional operators, string interpolation).
- Use `var` for implicit typing when the type is obvious.
- Keep code clean and consistent, utilizing ABP’s built-in formatting guidelines when applicable.

## Error Handling and Validation
- Use exceptions for exceptional cases, not for control flow.
- Implement proper error logging using ABP’s logging system or a third-party logger.
- Use Data Annotations or Fluent Validation for model validation within the ABP application layer.
- Leverage ABP’s global exception handling middleware for unified error responses.
- Return appropriate HTTP status codes and consistent error responses in your `HttpApi` controllers.

## API Design
- Follow RESTful API design principles in your `HttpApi` layer.
- Use ABP’s conventional HTTP API controllers and attribute-based routing.
- Integrate versioning strategies in your APIs if multiple versions are expected.
- Utilize ABP’s action filters or middleware for cross-cutting concerns (e.g., auditing).

## Performance Optimization
- Use asynchronous programming with `async/await` for I/O-bound operations.
- Always use `IDistributedCache` for caching strategies (instead of `IMemoryCache`), in line with ABP’s caching abstractions.
- Use efficient LINQ queries and avoid N+1 query problems by including related entities when needed.
- Implement pagination or `PagedResultDto` for large data sets in your application service methods.

## Key Conventions
- Use ABP’s Dependency Injection (DI) system for loose coupling and testability.
- Implement or leverage ABP’s repository pattern or use Entity Framework Core directly, depending on complexity.
- Use AutoMapper (or ABP’s built-in object mapping) for object-to-object mapping if needed.
- Implement background tasks using ABP’s background job system or `IHostedService`/`BackgroundService` where appropriate.
- Follow ABP’s recommended approach for domain events and entities (e.g., using `AuditedAggregateRoot`, `FullAuditedEntity`).
- Keep business rules in the **Domain layer**. Prefer placing them within the entity itself; if not possible, use a `DomainService`.
- Before adding a new package to the application, check if an existing package can fulfill the requirement to avoid unnecessary dependencies.
- Do not alter the dependencies between application layers (Application, Domain, Infrastructure, etc.).

**Domain Best Practices**  
- [Domain Services Best Practices](https://abp.io/docs/8.3/framework/architecture/best-practices/domain-services)  
- [Repositories Best Practices](https://abp.io/docs/8.3/framework/architecture/best-practices/repositories)  
- [Entities Best Practices](https://abp.io/docs/8.3/framework/architecture/best-practices/entities)

**Application Layer Best Practices**  
- [Application Services Best Practices](https://abp.io/docs/8.3/framework/architecture/best-practices/application-services)  
- [Data Transfer Objects Best Practices](https://abp.io/docs/8.3/framework/architecture/best-practices/data-transfer-objects)

**Data Access Best Practices**  
- [Entity Framework Core Integration](https://abp.io/docs/8.3/framework/architecture/best-practices/entity-framework-core-integration)  
- [MongoDB Integration](https://abp.io/docs/8.3/framework/architecture/best-practices/mongodb-integration)

Additionally, refer to the [EventHub repository](https://github.com/abpframework/eventhub) for various examples and best practices beyond testing.

## Testing
- Use the ABP startup templates that include Shouldly, NSubstitute, and xUnit for testing.
- Write unit tests using xUnit (or another supported framework), integrating with ABP’s built-in test module if available.
- Use NSubstitute (or a similar library) for mocking dependencies.
- Implement integration tests for your modules (e.g., `Application.Tests`, `Domain.Tests`), leveraging ABP’s test base classes.

## Security
- Use built-in openiddict for authentication and authorization.
- Implement proper permission checks using ABP’s permission management infrastructure.
- Use HTTPS and enforce SSL.
- Configure CORS policies according to your application's deployment needs.

## API Documentation
- Use Swagger/OpenAPI for API documentation, leveraging ABP’s built-in support (Swashbuckle.AspNetCore or NSwag).
- Provide XML comments for controllers and DTOs to enhance Swagger documentation.
- Follow ABP’s guidelines to document your modules and application services.

Adhere to official Microsoft documentation, ASP.NET Core guides, and ABP’s documentation (https://docs.abp.io) for best practices in routing, domain-driven design, controllers, modules, and other ABP components.
````

## File: .cursor/rules/chunk-250.mdc
````
---
description: 
globs: 
alwaysApply: true
---

# Keep source code files under 250 lines

- Keep source code files under 250 lines.
- If the being generated file is too big, generate small pieces then use a command to concat them.
````

## File: src/CoreFW.Application/Properties/AssemblyInfo.cs
````csharp
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleToAttribute("CoreFW.Application.Tests")]
````

## File: src/CoreFW.Application/CoreFW.Application.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\CoreFW.Domain\CoreFW.Domain.csproj" />
    <ProjectReference Include="..\CoreFW.Application.Contracts\CoreFW.Application.Contracts.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.Account.Application" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Identity.Application" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.PermissionManagement.Application" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.TenantManagement.Application" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.FeatureManagement.Application" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.SettingManagement.Application" Version="8.3.4" />
  </ItemGroup>

</Project>
````

## File: src/CoreFW.Application/CoreFWApplicationAutoMapperProfile.cs
````csharp
using AutoMapper;

namespace CoreFW;

public class CoreFWApplicationAutoMapperProfile : Profile
{
    public CoreFWApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
````

## File: src/CoreFW.Application/CoreFWApplicationModule.cs
````csharp
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(CoreFWApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class CoreFWApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<CoreFWApplicationModule>();
        });
    }
}
````

## File: src/CoreFW.Application/CoreFWAppService.cs
````csharp
using System;
using System.Collections.Generic;
using System.Text;
using CoreFW.Localization;
using Volo.Abp.Application.Services;

namespace CoreFW;

/* Inherit your application services from this class.
 */
public abstract class CoreFWAppService : ApplicationService
{
    protected CoreFWAppService()
    {
        LocalizationResource = typeof(CoreFWResource);
    }
}
````

## File: src/CoreFW.Application.Contracts/Permissions/CoreFWPermissionDefinitionProvider.cs
````csharp
using CoreFW.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CoreFW.Permissions;

public class CoreFWPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CoreFWPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CoreFWPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CoreFWResource>(name);
    }
}
````

## File: src/CoreFW.Application.Contracts/Permissions/CoreFWPermissions.cs
````csharp
namespace CoreFW.Permissions;

public static class CoreFWPermissions
{
    public const string GroupName = "CoreFW";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
````

## File: src/CoreFW.Application.Contracts/CoreFW.Application.Contracts.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\CoreFW.Domain.Shared\CoreFW.Domain.Shared.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.ObjectExtending" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Account.Application.Contracts" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Identity.Application.Contracts" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.PermissionManagement.Application.Contracts" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.TenantManagement.Application.Contracts" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.FeatureManagement.Application.Contracts" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.SettingManagement.Application.Contracts" Version="8.3.4" />
  </ItemGroup>

</Project>
````

## File: src/CoreFW.Application.Contracts/CoreFWApplicationContractsModule.cs
````csharp
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWDomainSharedModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class CoreFWApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        CoreFWDtoExtensions.Configure();
    }
}
````

## File: src/CoreFW.Application.Contracts/CoreFWDtoExtensions.cs
````csharp
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace CoreFW;

public static class CoreFWDtoExtensions
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        OneTimeRunner.Run(() =>
        {
                /* You can add extension properties to DTOs
                 * defined in the depended modules.
                 *
                 * Example:
                 *
                 * ObjectExtensionManager.Instance
                 *   .AddOrUpdateProperty<IdentityRoleDto, string>("Title");
                 *
                 * See the documentation for more:
                 * https://docs.abp.io/en/abp/latest/Object-Extensions
                 */
        });
    }
}
````

## File: src/CoreFW.Blazor/Components/Pages/_ViewImports.cshtml
````
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI
@addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI.Bootstrap
@addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI.Bundling
````

## File: src/CoreFW.Blazor/Components/Pages/Index.razor
````
@page "/"
@using Volo.Abp.MultiTenancy
@inherits CoreFWComponentBase
@inject AuthenticationStateProvider AuthenticationStateProvider

<div class="row mb-3">
    <div class="col-xl-6 col-12 d-flex">
        <div class="card h-lg-100 w-100 overflow-hidden">
            <div class="card-body">
                <div class="starting-content">
                    <h3>Getting Started</h3>
                    <p class="lead text-muted mb-2">Learn how to create and run a new web application using the application startup template.</p>
                    <a href="https://docs.abp.io/en/commercial/latest/getting-started" class="btn btn-brand mb-4" target="_blank">Getting Started</a>

                    <h4>Web Application Development Tutorial</h4>
                    <p class="text-muted mb-2">Learn how to build an ABP based web application named Acme.BookStore.</p>
                    <a href="https://docs.abp.io/en/commercial/latest/tutorials/book-store/part-1?UI=MVC&DB=EF" class="btn btn-primary soft mb-4" target="_blank">Explore Tutorial</a>

                    <h4>Customize Lepton Theme</h4>
                    <p class="text-muted mb-2">Learn how to customize LeptonX Theme as you wish.</p>
                    <a href="https://docs.abp.io/en/commercial/latest/themes/lepton/customizing-lepton-theme" class="btn btn-primary soft mb-5 mb-xl-0" target="_blank">Customize Lepton</a>
                </div>
                <img class="card-bg-image" src="/images/getting-started/bg-01.png">
            </div>
        </div>
    </div>

    <div class="col-xl-3 col-md-6 d-flex">
        <div class="card h-100 overflow-hidden">
            <div class="card-body">
                <div class="abp-support abp-logo mb-2"></div>
                <p class="text-muted mb-2">You can check for similar problems and solutions, or open a new topic to discuss your specific issue.</p>
                <a href="https://support.abp.io/QA/Questions" class="btn btn-brand soft" target="_blank">Visit Support</a>
                <img class="" src="/images/getting-started/img-support.png">
            </div>
        </div>
    </div>

    <div class="col-xl-3 col-md-6 d-flex">
        <div class="card h-100 overflow-hidden">
            <div class="card-body">
                <div class="abp-community abp-logo mb-2"></div>
                <p class="lead text-muted">A unique community platform for <span class="fw-bold">ABP Lovers!</span></p>
                <p class="text-muted mb-2">Explore all ABP users' experiences with the ABP Framework, discover articles and videos on how to use ABP, and join raffles for a chance to win surprise gifts!</p>
                <a class="btn btn-brand soft mb-3" href="https://community.abp.io/" target="_blank">Join ABP Community</a>
            </div>
            <img class="mt-3" src="/images/getting-started/img-community.png">
        </div>
    </div>
</div>

<div class="my-3 text-center">
    <h3>Let's improve your application!</h3>
    <p>Here are some links to help you get started:</p>
</div>

<div class="card mt-4 mb-5">
    <div class="card-body">
        <div class="row text-center justify-content-md-center">
            <div class="col-lg-4">
                <div class="p-4">
                    <h5 class="mb-3"><i class="fas fa-book text-secondary d-block my-3 fa-2x"></i> Learn the ABP Framework</h5>
                    <p>Explore the comprehensive documentation to learn how to build a modern web application.</p>
                    <a href="https://abp.io/docs/latest?ref=tmpl" target="_blank" class="btn btn-link px-1">See Documents <i class="fas fa-chevron-right"></i></a>
                </div>
            </div>
            <div class="col-lg-4 border-start">
                <div class="p-4">
                    <h5 class="mb-3"><i class="fas fa-cubes text-secondary d-block my-3 fa-2x"></i> Samples</h5>
                    <p>See the example projects built with the ABP Framework.</p>
                    <a href="https://abp.io/docs/latest/samples?ref=tmpl" target="_blank" class="btn btn-link px-1">All samples <i class="fas fa-chevron-right"></i></a>
                </div>
            </div>
            <div class="col-lg-4 border-start">
                <div class="p-4">
                    <h5 class="mb-3"><i class="fas fa-users text-secondary d-block my-3 fa-2x"></i> ABP Community</h5>
                    <p>Get involved with a vibrant community and become a contributor.</p>
                    <a href="https://abp.io/community/" target="_blank" class="btn btn-link px-1">Community <i class="fas fa-chevron-right"></i></a>
                    <a href="https://abp.io/docs/latest/contribution?ref=tmpl" target="_blank" class="btn btn-link px-1">Contribute <i class="fas fa-chevron-right"></i></a>
                </div>
            </div>
        </div>
        <div class="row text-center mt-lg-3 justify-content-md-center">
            <div class="col-lg-4">
                <div class="p-4">
                    <h5 class="mb-3"><i class="fas fa-pen-nib text-secondary d-block my-3 fa-2x"></i> ABP Blog</h5>
                    <p>Take a look at our recently published articles.</p>
                    <a href="https://abp.io/blog?ref=tmpl" target="_blank" class="btn btn-link px-1">See Blog <i class="fas fa-chevron-right"></i></a>
                </div>
            </div>
            <div class="col-lg-4 border-start">
                <div class="p-4">
                    <h5 class="mb-3"><i class="fab fa-github text-secondary d-block my-3 fa-2x"></i> Github</h5>
                    <p>Do you love the ABP Framework? Please <strong>give a star</strong> to support it!</p>
                    <a href="https://github.com/abpframework/abp/" target="_blank" class="btn btn-link px-1">See Open Source Framework <i class="fas fa-chevron-right"></i></a>
                </div>
            </div>
        </div>
    </div>
</div>
````

## File: src/CoreFW.Blazor/Components/Pages/Index.razor.cs
````csharp
namespace CoreFW.Blazor.Pages;

public partial class Index
{

}
````

## File: src/CoreFW.Blazor/Components/Pages/Index.razor.css
````css
/* Getting-Started */
.card-bg-image {
    position: absolute;
    width: 630px;
    height: auto;
    bottom: 0;
    right: 0;
    z-index: 1;
}
/* Getting-Started End */

/* Write here your styles for the Index page */
````

## File: src/CoreFW.Blazor/Components/App.razor
````
@using Volo.Abp.Localization
@using System.Globalization
@using Microsoft.Extensions.Hosting
@using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Bundling
@using Volo.Abp.AspNetCore.Components.Web.Theming.Bundling
@inject IHostEnvironment Env
@{
    var rtl = CultureHelper.IsRtl ? "rtl" : string.Empty;
}

<!DOCTYPE html>
<html lang="@CultureInfo.CurrentCulture.Name" dir="@rtl">

<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>CoreFW.Blazor</title>
    <base href="/" />

    <AbpStyles BundleName="@BlazorLeptonXLiteThemeBundles.Styles.Global" />

    <HeadOutlet @rendermode="InteractiveServer" />

</head>
<body>

    <Routes @rendermode="InteractiveServer" />

    <AbpScripts BundleName="@BlazorLeptonXLiteThemeBundles.Scripts.Global" />

    <script src="_framework/blazor.web.js"></script>

    <div id="blazor-error-ui">
        @if (Env.IsDevelopment())
        {
            <text>An unhandled exception has occurred. See browser dev tools for details.</text>
        }
        else if (Env.IsStaging() || Env.IsProduction())
        {
            <text>An error has occurred. This application may no longer respond until reloaded.</text>
        }
        <a href="" class="reload">Reload</a>
        <a class="dismiss">🗙</a>
    </div>

</body>
</html>
````

## File: src/CoreFW.Blazor/Components/Routes.razor
````
@using Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite
@using Volo.Abp.AspNetCore.Components.Web.Theming.Routing
@using Microsoft.Extensions.Options
@inject IOptions<AbpRouterOptions> RouterOptions
<Router AppAssembly="typeof(Program).Assembly" AdditionalAssemblies="RouterOptions.Value.AdditionalAssemblies">
    <Found Context="routeData">
        <AuthorizeRouteView RouteData="routeData" DefaultLayout="typeof(MainLayout)">
            <NotAuthorized>
                <RedirectToLogin />
            </NotAuthorized>
        </AuthorizeRouteView>
    </Found>
</Router>
````

## File: src/CoreFW.Blazor/Menus/CoreFWMenuContributor.cs
````csharp
using System.Threading.Tasks;
using CoreFW.Localization;
using CoreFW.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace CoreFW.Blazor.Menus;

public class CoreFWMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<CoreFWResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                CoreFWMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return Task.CompletedTask;
    }
}
````

## File: src/CoreFW.Blazor/Menus/CoreFWMenus.cs
````csharp
namespace CoreFW.Blazor.Menus;

public class CoreFWMenus
{
    private const string Prefix = "CoreFW";
    public const string Home = Prefix + ".Home";

    //Add your menu items here...

}
````

## File: src/CoreFW.Blazor/Pages/_Host.cshtml
````
@page "/"
@namespace CoreFW.Blazor.Pages
@using System.Globalization
@using Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite
@using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Bundling
@using Volo.Abp.Localization
@using Microsoft.AspNetCore.Components.Web
@{
    Layout = null;
    var rtl = CultureHelper.IsRtl ? "rtl" : string.Empty;
}

<!DOCTYPE html>
<html lang="@CultureInfo.CurrentCulture.Name" dir="@rtl">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>CoreFW.Blazor</title>
    <base href="~/" />
    
    <abp-style-bundle name="@BlazorLeptonXLiteThemeBundles.Styles.Global" />
    <component type="typeof(HeadOutlet)" render-mode="ServerPrerendered" />
</head>
<body class="abp-application-layout bg-light @rtl">

    <component type="typeof(App)" render-mode="Server" />

    <div id="blazor-error-ui">
        <environment include="Staging,Production">
            An error has occurred. This application may no longer respond until reloaded.
        </environment>
        <environment include="Development">
            An unhandled exception has occurred. See browser dev tools for details.
        </environment>
        <a href="" class="reload">Reload</a>
        <a class="dismiss">🗙</a>
    </div>

    <abp-script-bundle name="@BlazorLeptonXLiteThemeBundles.Scripts.Global" />
</body>
</html>
````

## File: src/CoreFW.Blazor/Properties/launchSettings.json
````json
{
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "https://localhost:44321/",
      "sslPort": 44321
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "CoreFW.Blazor": {
      "commandName": "Project",
      "dotnetRunMessages": "true",
      "launchBrowser": true,
      "applicationUrl": "https://localhost:44321/",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
````

## File: src/CoreFW.Blazor/wwwroot/images/getting-started/discord.svg
````
<svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
<g id="Frame 1416">
<g id="Group">
<path id="Vector" d="M16.9419 3.29661C15.6473 2.69088 14.263 2.25066 12.8157 2C12.638 2.32134 12.4304 2.75355 12.2872 3.09738C10.7487 2.86601 9.22445 2.86601 7.7143 3.09738C7.57116 2.75355 7.3588 2.32134 7.17947 2C5.73067 2.25066 4.3448 2.6925 3.05016 3.29982C0.438869 7.24582 -0.269009 11.0938 0.0849305 14.8872C1.81688 16.1805 3.49534 16.9662 5.14548 17.4804C5.55291 16.9196 5.91628 16.3235 6.22931 15.6953C5.63313 15.4688 5.06211 15.1892 4.52256 14.8647C4.6657 14.7586 4.80571 14.6478 4.94098 14.5337C8.23183 16.0729 11.8074 16.0729 15.0589 14.5337C15.1958 14.6478 15.3358 14.7586 15.4774 14.8647C14.9362 15.1908 14.3637 15.4704 13.7675 15.697C14.0805 16.3235 14.4423 16.9212 14.8513 17.4819C16.503 16.9678 18.183 16.1822 19.915 14.8872C20.3303 10.4897 19.2056 6.67705 16.9419 3.29661ZM6.67765 12.5543C5.68977 12.5543 4.87963 11.632 4.87963 10.509C4.87963 9.38591 5.67247 8.46208 6.67765 8.46208C7.68285 8.46208 8.49297 9.38429 8.47567 10.509C8.47723 11.632 7.68285 12.5543 6.67765 12.5543ZM13.3223 12.5543C12.3344 12.5543 11.5243 11.632 11.5243 10.509C11.5243 9.38591 12.3171 8.46208 13.3223 8.46208C14.3275 8.46208 15.1376 9.38429 15.1203 10.509C15.1203 11.632 14.3275 12.5543 13.3223 12.5543Z" fill="#5865F2"/>
</g>
</g>
</svg>
````

## File: src/CoreFW.Blazor/wwwroot/images/getting-started/instagram.svg
````
<svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
<g clip-path="url(#clip0_425_4536)">
<path d="M10.014 -0.00549316C5.8391 -0.00549316 4.6181 -0.00118628 4.38076 0.0185023C3.524 0.0897197 2.99087 0.224617 2.41005 0.513794C1.96244 0.73606 1.60943 0.993704 1.26104 1.35487C0.626541 2.01351 0.241998 2.82382 0.102793 3.78702C0.0351137 4.25463 0.0154251 4.35 0.0114258 6.73847C0.00988765 7.53463 0.0114258 8.58243 0.0114258 9.98786C0.0114258 14.1594 0.0160403 15.3792 0.0360366 15.616C0.105254 16.4497 0.235999 16.9742 0.51287 17.548C1.042 18.6462 2.05258 19.4707 3.24313 19.7783C3.65536 19.8845 4.11066 19.9429 4.69516 19.9706C4.94281 19.9814 7.46695 19.9891 9.99263 19.9891C12.5183 19.9891 15.044 19.986 15.2855 19.9737C15.9623 19.9418 16.3553 19.8891 16.7898 19.7768C17.988 19.4676 18.9802 18.6555 19.5201 17.5418C19.7916 16.9819 19.9292 16.4374 19.9915 15.6473C20.0051 15.475 20.0107 12.7283 20.0107 9.98524C20.0107 7.24176 20.0046 4.50012 19.9911 4.32785C19.928 3.52492 19.7903 2.98502 19.5101 2.41436C19.2801 1.94722 19.0248 1.59836 18.6541 1.24166C17.9925 0.609776 17.1834 0.225233 16.2193 0.0861819C15.7522 0.0186561 15.6591 -0.0013401 13.2688 -0.00549316H10.014Z" fill="url(#paint0_radial_425_4536)"/>
<path d="M10.014 -0.00549316C5.8391 -0.00549316 4.6181 -0.00118628 4.38076 0.0185023C3.524 0.0897197 2.99087 0.224617 2.41005 0.513794C1.96244 0.73606 1.60943 0.993704 1.26104 1.35487C0.626541 2.01351 0.241998 2.82382 0.102793 3.78702C0.0351137 4.25463 0.0154251 4.35 0.0114258 6.73847C0.00988765 7.53463 0.0114258 8.58243 0.0114258 9.98786C0.0114258 14.1594 0.0160403 15.3792 0.0360366 15.616C0.105254 16.4497 0.235999 16.9742 0.51287 17.548C1.042 18.6462 2.05258 19.4707 3.24313 19.7783C3.65536 19.8845 4.11066 19.9429 4.69516 19.9706C4.94281 19.9814 7.46695 19.9891 9.99263 19.9891C12.5183 19.9891 15.044 19.986 15.2855 19.9737C15.9623 19.9418 16.3553 19.8891 16.7898 19.7768C17.988 19.4676 18.9802 18.6555 19.5201 17.5418C19.7916 16.9819 19.9292 16.4374 19.9915 15.6473C20.0051 15.475 20.0107 12.7283 20.0107 9.98524C20.0107 7.24176 20.0046 4.50012 19.9911 4.32785C19.928 3.52492 19.7903 2.98502 19.5101 2.41436C19.2801 1.94722 19.0248 1.59836 18.6541 1.24166C17.9925 0.609776 17.1834 0.225233 16.2193 0.0861819C15.7522 0.0186561 15.6591 -0.0013401 13.2688 -0.00549316H10.014Z" fill="url(#paint1_radial_425_4536)"/>
<path d="M10.0093 2.60938C8.00417 2.60938 7.75252 2.61814 6.96498 2.65398C6.17897 2.68998 5.64246 2.81441 5.17301 2.99699C4.68741 3.18557 4.27549 3.43783 3.8651 3.84837C3.45441 4.25876 3.20215 4.67068 3.01295 5.15613C2.82991 5.62573 2.70532 6.1624 2.66994 6.9481C2.63472 7.73564 2.62549 7.98744 2.62549 9.9926C2.62549 11.9978 2.63441 12.2486 2.6701 13.0362C2.70624 13.8222 2.83068 14.3587 3.01311 14.8282C3.20184 15.3138 3.4541 15.7257 3.86464 16.1361C4.27487 16.5468 4.68679 16.7996 5.17209 16.9882C5.64184 17.1708 6.17851 17.2952 6.96436 17.3312C7.75191 17.3671 8.0034 17.3758 10.0084 17.3758C12.0137 17.3758 12.2646 17.3671 13.0521 17.3312C13.8381 17.2952 14.3753 17.1708 14.845 16.9882C15.3305 16.7996 15.7418 16.5468 16.152 16.1361C16.5627 15.7257 16.815 15.3138 17.0042 14.8283C17.1857 14.3587 17.3103 13.822 17.3472 13.0363C17.3826 12.2488 17.3918 11.9978 17.3918 9.9926C17.3918 7.98744 17.3826 7.7358 17.3472 6.94825C17.3103 6.16225 17.1857 5.62573 17.0042 5.15628C16.815 4.67068 16.5627 4.25876 16.152 3.84837C15.7413 3.43768 15.3306 3.18542 14.8446 2.99699C14.3739 2.81441 13.8371 2.68998 13.0511 2.65398C12.2635 2.61814 12.0128 2.60938 10.007 2.60938H10.0093ZM9.34699 3.93989C9.54357 3.93959 9.76291 3.93989 10.0093 3.93989C11.9807 3.93989 12.2143 3.94697 12.9928 3.98235C13.7126 4.01526 14.1033 4.13555 14.3636 4.23661C14.7081 4.37043 14.9538 4.5304 15.212 4.78881C15.4705 5.04722 15.6304 5.29333 15.7646 5.63788C15.8656 5.89783 15.9861 6.28853 16.0188 7.00839C16.0542 7.78671 16.0619 8.02051 16.0619 9.99091C16.0619 11.9613 16.0542 12.1951 16.0188 12.9734C15.9859 13.6933 15.8656 14.084 15.7646 14.3439C15.6307 14.6885 15.4705 14.9338 15.212 15.1921C14.9536 15.4505 14.7083 15.6105 14.3636 15.7443C14.1036 15.8458 13.7126 15.9658 12.9928 15.9987C12.2145 16.0341 11.9807 16.0418 10.0093 16.0418C8.03785 16.0418 7.80421 16.0341 7.02589 15.9987C6.30603 15.9655 5.91533 15.8452 5.65492 15.7441C5.31037 15.6103 5.06426 15.4503 4.80585 15.1919C4.54743 14.9335 4.38746 14.688 4.25334 14.3433C4.15228 14.0834 4.03184 13.6927 3.99908 12.9728C3.9637 12.1945 3.95662 11.9607 3.95662 9.98906C3.95662 8.01744 3.9637 7.78486 3.99908 7.00655C4.03199 6.28668 4.15228 5.89599 4.25334 5.63573C4.38716 5.29118 4.54743 5.04507 4.80585 4.78666C5.06426 4.52824 5.31037 4.36828 5.65492 4.23415C5.91518 4.13263 6.30603 4.01265 7.02589 3.97958C7.70699 3.94882 7.97094 3.93959 9.34699 3.93805V3.93989ZM13.9504 5.16582C13.4613 5.16582 13.0644 5.5622 13.0644 6.0515C13.0644 6.54064 13.4613 6.93748 13.9504 6.93748C14.4396 6.93748 14.8364 6.54064 14.8364 6.0515C14.8364 5.56236 14.4396 5.16551 13.9504 5.16551V5.16582ZM10.0093 6.20101C7.91542 6.20101 6.21774 7.89869 6.21774 9.9926C6.21774 12.0865 7.91542 13.7834 10.0093 13.7834C12.1032 13.7834 13.8003 12.0865 13.8003 9.9926C13.8003 7.89869 12.1032 6.20101 10.0093 6.20101ZM10.0093 7.53153C11.3685 7.53153 12.4704 8.63332 12.4704 9.9926C12.4704 11.3517 11.3685 12.4537 10.0093 12.4537C8.65005 12.4537 7.54825 11.3517 7.54825 9.9926C7.54825 8.63332 8.65005 7.53153 10.0093 7.53153Z" fill="white"/>
</g>
<defs>
<radialGradient id="paint0_radial_425_4536" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(5.32327 21.5291) rotate(-90) scale(19.8161 18.4355)">
<stop stop-color="#FFDD55"/>
<stop offset="0.1" stop-color="#FFDD55"/>
<stop offset="0.5" stop-color="#FF543E"/>
<stop offset="1" stop-color="#C837AB"/>
</radialGradient>
<radialGradient id="paint1_radial_425_4536" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(-3.33936 1.43488) rotate(78.6776) scale(8.85796 36.5221)">
<stop stop-color="#3771C8"/>
<stop offset="0.128" stop-color="#3771C8"/>
<stop offset="1" stop-color="#6600FF" stop-opacity="0"/>
</radialGradient>
<clipPath id="clip0_425_4536">
<rect width="20" height="20" fill="white"/>
</clipPath>
</defs>
</svg>
````

## File: src/CoreFW.Blazor/wwwroot/images/getting-started/stack-overflow.svg
````
<svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
<path d="M14.418 16.5774V12.291H15.8406V18H3V12.291H4.42263V16.5774H14.418Z" fill="#BCBBBB"/>
<path d="M5.99302 11.8845L12.9769 13.3441L13.2725 11.94L6.28863 10.4804L5.99302 11.8845ZM6.91681 8.55889L13.3833 11.5704L13.9745 10.2771L7.50803 7.24711L6.91681 8.55889ZM8.70896 5.38106L14.1963 9.94457L15.1016 8.8545L9.61427 4.29099L8.70896 5.38106ZM12.2563 2L11.1108 2.84988L15.3602 8.57737L16.5057 7.72748L12.2563 2ZM5.84521 15.1363H12.9769V13.7136H5.84521V15.1363Z" fill="#F48023"/>
</svg>
````

## File: src/CoreFW.Blazor/wwwroot/images/getting-started/x-white.svg
````
<svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
<path d="M11.5158 8.77569L17.4682 2H16.0582L10.8875 7.88203L6.76083 2H2L8.24173 10.8955L2 18H3.41003L8.86681 11.787L13.2258 18H17.9867M3.91893 3.04127H6.08513L16.0571 17.0099H13.8904" fill="white"/>
</svg>
````

## File: src/CoreFW.Blazor/wwwroot/images/getting-started/youtube.svg
````
<svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
<g clip-path="url(#clip0_425_4528)">
<path d="M19.5818 5.18637C19.3513 4.32532 18.6746 3.64867 17.8136 3.41818C16.2545 3 9.99996 3 9.99996 3C9.99996 3 3.74547 3 2.18636 3.41818C1.32532 3.64867 0.648666 4.32532 0.418176 5.18637C1.25176e-07 6.74547 0 10.0003 0 10.0003C0 10.0003 1.25176e-07 13.2552 0.418176 14.8143C0.648666 15.6753 1.32532 16.352 2.18636 16.5825C3.74547 17.0007 9.99996 17.0007 9.99996 17.0007C9.99996 17.0007 16.2545 17.0007 17.8136 16.5825C18.6746 16.352 19.3513 15.6753 19.5818 14.8143C20 13.2552 20 10.0003 20 10.0003C20 10.0003 19.9983 6.74547 19.5818 5.18637Z" fill="#FF0000"/>
<path d="M7.99854 13.0003L13.1945 10.0007L7.99854 7.00098V13.0003Z" fill="white"/>
</g>
<defs>
<clipPath id="clip0_425_4528">
<rect width="20" height="20" fill="white"/>
</clipPath>
</defs>
</svg>
````

## File: src/CoreFW.Blazor/wwwroot/blazor-global-styles.css
````css
#blazor-error-ui {
    background: lightyellow;
    bottom: 0;
    box-shadow: 0 -1px 2px rgba(0, 0, 0, 0.2);
    display: none;
    left: 0;
    padding: 0.6rem 1.25rem 0.7rem 1.25rem;
    position: fixed;
    width: 100%;
    z-index: 1000;
}

#blazor-error-ui .dismiss {
    cursor: pointer;
    position: absolute;
    right: 0.75rem;
    top: 0.5rem;
}
:root .lpx-brand-logo {
    --lpx-logo: url('/images/logo/leptonx/logo-light.png');
    --lpx-logo-icon: url('/images/logo/leptonx/logo-light-thumbnail.png');
}
.lpx-topbar-container .lpx-topbar
{
    border-radius: 0%;
}
````

## File: src/CoreFW.Blazor/wwwroot/global-styles.css
````css
body {
    
}

:root .lpx-brand-logo {
    --lpx-logo: url('/images/logo/leptonx/logo-light.png');
    --lpx-logo-icon: url('/images/logo/leptonx/logo-light-thumbnail.png');
}
````

## File: src/CoreFW.Blazor/_Imports.razor
````
@using System.Net.Http
@using Microsoft.AspNetCore.Authorization
@using Microsoft.AspNetCore.Components.Authorization
@using Microsoft.AspNetCore.Components.Forms
@using Microsoft.AspNetCore.Components.Routing
@using Microsoft.AspNetCore.Components.Web
@using Microsoft.AspNetCore.Components.Web.Virtualization
@using static Microsoft.AspNetCore.Components.Web.RenderMode
@using Microsoft.JSInterop
@using CoreFW.Blazor
@using Blazorise
@using Blazorise.DataGrid
@using Volo.Abp.BlazoriseUI
@using Volo.Abp.BlazoriseUI.Components
````

## File: src/CoreFW.Blazor/abp.resourcemapping.js
````javascript
module.exports = {
    aliases: {

    },
    clean: [

    ],
    mappings: {

    }
};
````

## File: src/CoreFW.Blazor/appsettings.Development.json
````json
{
}
````

## File: src/CoreFW.Blazor/appsettings.json
````json
{
  "App": {
    "SelfUrl": "https://localhost:44321",
    "RedirectAllowedUrls": "https://localhost:44321"
  },
  "ConnectionStrings": {
    "Default": "Server=localhost;Port=3306;Database=corefw;Uid=root;Pwd=123456a@;"
  },
  "AuthServer": {
    "Authority": "https://localhost:44321",
    "RequireHttpsMetadata": false
  },
  "StringEncryption": {
    "DefaultPassPhrase": "GivqoV9VPvUha1Zf"
  }
}
````

## File: src/CoreFW.Blazor/appsettings.secrets.json
````json
{
}
````

## File: src/CoreFW.Blazor/CoreFW.Blazor.csproj
````
<Project Sdk="Microsoft.NET.Sdk.Web">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
    <GenerateBindingRedirectsOutputType>true</GenerateBindingRedirectsOutputType>
    <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
    <MvcRazorExcludeRefAssembliesFromPublish>false</MvcRazorExcludeRefAssembliesFromPublish>
    <PreserveCompilationReferences>true</PreserveCompilationReferences>
    <UserSecretsId>CoreFW-4681b4fd-151f-4221-84a4-929d86723e4c</UserSecretsId>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="DevExpress.Blazor" Version="24.2.5" />
    <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.Server" Version="8.0.4" />
    <PackageReference Include="Blazorise.Bootstrap5" Version="1.5.2" />
    <PackageReference Include="Blazorise.Icons.FontAwesome" Version="1.5.2" />
    <PackageReference Include="Serilog.AspNetCore" Version="8.0.0" />
    <PackageReference Include="Serilog.Sinks.Async" Version="1.5.0" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme" Version="3.2.0" />
    <PackageReference Include="Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite" Version="3.2.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\CoreFW.Application\CoreFW.Application.csproj" />
    <ProjectReference Include="..\CoreFW.HttpApi\CoreFW.HttpApi.csproj" />
    <ProjectReference Include="..\CoreFW.EntityFrameworkCore\CoreFW.EntityFrameworkCore.csproj" />
    <PackageReference Include="Volo.Abp.Autofac" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Swashbuckle" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.AspNetCore.Serilog" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Account.Web.OpenIddict" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Identity.Blazor.Server" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.TenantManagement.Blazor.Server" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.SettingManagement.Blazor.Server" Version="8.3.4" />
  </ItemGroup>

  <ItemGroup Condition="Exists('./openiddict.pfx')">
    <None Remove="openiddict.pfx" />
    <EmbeddedResource Include="openiddict.pfx">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </EmbeddedResource>
  </ItemGroup>

  <ItemGroup>
    <Compile Remove="Logs\**" />
    <Content Remove="Logs\**" />
    <EmbeddedResource Remove="Logs\**" />
    <None Remove="Logs\**" />
  </ItemGroup>

  <ItemGroup>
    <None Update="Pages\**\*.js">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Update="Pages\**\*.css">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>

</Project>
````

## File: src/CoreFW.Blazor/CoreFWBlazorModule.cs
````csharp
using System;
using System.IO;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using CoreFW.Blazor.Components;
using CoreFW.Blazor.Menus;
using CoreFW.EntityFrameworkCore;
using CoreFW.Localization;
using CoreFW.MultiTenancy;
using OpenIddict.Validation.AspNetCore;
using Volo.Abp;
using Volo.Abp.Account.Web;
using Volo.Abp.AspNetCore.Components.Web;
using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme;
using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Bundling;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity.Blazor.Server;
using Volo.Abp.Modularity;
using Volo.Abp.Security.Claims;
using Volo.Abp.SettingManagement.Blazor.Server;
using Volo.Abp.Swashbuckle;
using Volo.Abp.TenantManagement.Blazor.Server;
using Volo.Abp.OpenIddict;
using Volo.Abp.UI;
using Volo.Abp.UI.Navigation;
using Volo.Abp.UI.Navigation.Urls;
using Volo.Abp.VirtualFileSystem;

namespace CoreFW.Blazor;

[DependsOn(
    typeof(CoreFWApplicationModule),
    typeof(CoreFWEntityFrameworkCoreModule),
    typeof(CoreFWHttpApiModule),
    typeof(AbpAutofacModule),
    typeof(AbpSwashbuckleModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpAccountWebOpenIddictModule),
    typeof(AbpAspNetCoreComponentsServerLeptonXLiteThemeModule),
    typeof(AbpAspNetCoreMvcUiLeptonXLiteThemeModule),
    typeof(AbpIdentityBlazorServerModule),
    typeof(AbpTenantManagementBlazorServerModule),
    typeof(AbpSettingManagementBlazorServerModule)
   )]
public class CoreFWBlazorModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        var hostingEnvironment = context.Services.GetHostingEnvironment();
        var configuration = context.Services.GetConfiguration();

        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(
                typeof(CoreFWResource),
                typeof(CoreFWDomainModule).Assembly,
                typeof(CoreFWDomainSharedModule).Assembly,
                typeof(CoreFWApplicationModule).Assembly,
                typeof(CoreFWApplicationContractsModule).Assembly,
                typeof(CoreFWBlazorModule).Assembly
            );
        });

        PreConfigure<OpenIddictBuilder>(builder =>
        {
            builder.AddValidation(options =>
            {
                options.AddAudiences("CoreFW");
                options.UseLocalServer();
                options.UseAspNetCore();
            });
        });

        if (!hostingEnvironment.IsDevelopment())
        {
            PreConfigure<AbpOpenIddictAspNetCoreOptions>(options =>
            {
                options.AddDevelopmentEncryptionAndSigningCertificate = false;
            });

            PreConfigure<OpenIddictServerBuilder>(serverBuilder =>
            {
                serverBuilder.AddProductionEncryptionAndSigningCertificate("openiddict.pfx", "b35f0cf8-1c4b-4414-bd75-d79555e50386");
            });
        }

        PreConfigure<AbpAspNetCoreComponentsWebOptions>(options =>
        {
            options.IsBlazorWebApp = true;
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var hostingEnvironment = context.Services.GetHostingEnvironment();
        var configuration = context.Services.GetConfiguration();

        // Add services to the container.
        context.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        ConfigureAuthentication(context);
        ConfigureUrls(configuration);
        ConfigureBundles();
        ConfigureAutoMapper();
        ConfigureVirtualFileSystem(hostingEnvironment);
        ConfigureSwaggerServices(context.Services);
        ConfigureAutoApiControllers();
        ConfigureBlazorise(context);
        ConfigureRouter(context);
        ConfigureMenu(context);
    }

    private void ConfigureAuthentication(ServiceConfigurationContext context)
    {
        context.Services.ForwardIdentityAuthenticationForBearer(OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme);
        context.Services.Configure<AbpClaimsPrincipalFactoryOptions>(options =>
        {
            options.IsDynamicClaimsEnabled = true;
        });
    }

    private void ConfigureUrls(IConfiguration configuration)
    {
        Configure<AppUrlOptions>(options =>
        {
            options.Applications["MVC"].RootUrl = configuration["App:SelfUrl"];
            options.RedirectAllowedUrls.AddRange(configuration["App:RedirectAllowedUrls"]?.Split(',') ?? Array.Empty<string>());
        });
    }

    private void ConfigureBundles()
    {
        Configure<AbpBundlingOptions>(options =>
        {
            // MVC UI
            options.StyleBundles.Configure(
                LeptonXLiteThemeBundles.Styles.Global,
                bundle =>
                {
                    bundle.AddFiles("/global-styles.css");
                }
            );

            //BLAZOR UI
            options.StyleBundles.Configure(
                BlazorLeptonXLiteThemeBundles.Styles.Global,
                bundle =>
                {
                    bundle.AddFiles("/blazor-global-styles.css");
                    //You can remove the following line if you don't use Blazor CSS isolation for components
                    bundle.AddFiles(new BundleFile("/CoreFW.Blazor.styles.css", true));
                }
            );
        });
    }

    private void ConfigureVirtualFileSystem(IWebHostEnvironment hostingEnvironment)
    {
        if (hostingEnvironment.IsDevelopment())
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.ReplaceEmbeddedByPhysical<CoreFWDomainSharedModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}CoreFW.Domain.Shared"));
                options.FileSets.ReplaceEmbeddedByPhysical<CoreFWDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}CoreFW.Domain"));
                options.FileSets.ReplaceEmbeddedByPhysical<CoreFWApplicationContractsModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}CoreFW.Application.Contracts"));
                options.FileSets.ReplaceEmbeddedByPhysical<CoreFWApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}CoreFW.Application"));
                options.FileSets.ReplaceEmbeddedByPhysical<CoreFWBlazorModule>(hostingEnvironment.ContentRootPath);
            });
        }
    }

    private void ConfigureSwaggerServices(IServiceCollection services)
    {
        services.AddAbpSwaggerGen(
            options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "CoreFW API", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);
                options.CustomSchemaIds(type => type.FullName);
            }
        );
    }

    private void ConfigureBlazorise(ServiceConfigurationContext context)
    {
        context.Services
            .AddBootstrap5Providers()
            .AddFontAwesomeIcons();
    }

    private void ConfigureMenu(ServiceConfigurationContext context)
    {
        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new CoreFWMenuContributor());
        });
    }

    private void ConfigureRouter(ServiceConfigurationContext context)
    {
        Configure<AbpRouterOptions>(options =>
        {
            options.AppAssembly = typeof(CoreFWBlazorModule).Assembly;
        });
    }

    private void ConfigureAutoApiControllers()
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(CoreFWApplicationModule).Assembly);
        });
    }

    private void ConfigureAutoMapper()
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<CoreFWBlazorModule>();
        });
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var env = context.GetEnvironment();
        var app = context.GetApplicationBuilder();

        app.UseAbpRequestLocalization();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseCorrelationId();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAbpOpenIddictValidation();

        if (MultiTenancyConsts.IsEnabled)
        {
            app.UseMultiTenancy();
        }
        app.UseUnitOfWork();
        app.UseDynamicClaims();
        app.UseAntiforgery();
        app.UseAuthorization();

        app.UseSwagger();
        app.UseAbpSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "CoreFW API");
        });

        app.UseConfiguredEndpoints(builder =>
        {
            builder.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddAdditionalAssemblies(builder.ServiceProvider.GetRequiredService<IOptions<AbpRouterOptions>>().Value.AdditionalAssemblies.ToArray());
        });
    }
}
````

## File: src/CoreFW.Blazor/CoreFWBrandingProvider.cs
````csharp
using Microsoft.Extensions.Localization;
using CoreFW.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CoreFW.Blazor;

[Dependency(ReplaceServices = true)]
public class CoreFWBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CoreFWResource> _localizer;

    public CoreFWBrandingProvider(IStringLocalizer<CoreFWResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
````

## File: src/CoreFW.Blazor/CoreFWComponentBase.cs
````csharp
using CoreFW.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CoreFW.Blazor;

public abstract class CoreFWComponentBase : AbpComponentBase
{
    protected CoreFWComponentBase()
    {
        LocalizationResource = typeof(CoreFWResource);
    }
}
````

## File: src/CoreFW.Blazor/package.json
````json
{
  "version": "1.0.0",
  "name": "my-app",
  "private": true,
  "dependencies": {
    "@abp/aspnetcore.mvc.ui.theme.leptonxlite": "~3.3.4",
    "@abp/aspnetcore.components.server.leptonxlitetheme": "~3.3.4"
  }
}
````

## File: src/CoreFW.Blazor/Program.cs
````csharp
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace CoreFW.Blazor;

public class Program
{
    public async static Task<int> Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
#if DEBUG
            .MinimumLevel.Debug()
#else
            .MinimumLevel.Information()
#endif
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .WriteTo.Async(c => c.File("Logs/logs.txt"))
            .WriteTo.Async(c => c.Console())
            .CreateLogger();

        try
        {
            Log.Information("Starting web host.");
            var builder = WebApplication.CreateBuilder(args);
            builder.Host.AddAppSettingsSecretsJson()
                .UseAutofac()
                .UseSerilog();
            await builder.AddApplicationAsync<CoreFWBlazorModule>();
            var app = builder.Build();
            await app.InitializeApplicationAsync();
            await app.RunAsync();
            return 0;
        }
        catch (Exception ex)
        {
            if (ex is HostAbortedException)
            {
                throw;
            }

            Log.Fatal(ex, "Host terminated unexpectedly!");
            return 1;
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
````

## File: src/CoreFW.Blazor/web.config
````
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <location path="." inheritInChildApplications="false">
    <system.webServer>
      <handlers>
        <add name="aspNetCore" path="*" verb="*" modules="AspNetCoreModuleV2" resourceType="Unspecified" />
      </handlers>
      <aspNetCore processPath="dotnet" arguments=".\CoreFW.Blazor.dll" stdoutLogEnabled="false" stdoutLogFile=".\Logs\stdout" hostingModel="inprocess" />
    </system.webServer>
  </location>
  <system.webServer>
    <httpProtocol>
      <customHeaders>
        <remove name="x-powered-by" />
      </customHeaders>
    </httpProtocol>
  </system.webServer>
</configuration>
````

## File: src/CoreFW.DbMigrator/appsettings.json
````json
{
  "ConnectionStrings": {
    "Default": "Server=localhost;Port=3306;Database=corefw;Uid=root;Pwd=123456a@;"
  },
  "OpenIddict": {
    "Applications": {
      "CoreFW_Swagger": {
        "ClientId": "CoreFW_Swagger",
        "RootUrl": "https://localhost:44367"
      }
    }
  }
}
````

## File: src/CoreFW.DbMigrator/appsettings.secrets.json
````json
{
}
````

## File: src/CoreFW.DbMigrator/CoreFW.DbMigrator.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <None Remove="appsettings.json" />
    <Content Include="appsettings.json">
      <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <None Remove="appsettings.secrets.json" />
    <Content Include="appsettings.secrets.json">
      <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>

  <ItemGroup>    
    <PackageReference Include="Serilog.Extensions.Logging" Version="8.0.0" />
    <PackageReference Include="Serilog.Sinks.Async" Version="1.5.0" />
    <PackageReference Include="Serilog.Sinks.File" Version="5.0.0" />
    <PackageReference Include="Serilog.Sinks.Console" Version="5.0.0" />
    <PackageReference Include="Microsoft.Extensions.Hosting" Version="8.0.0" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.Autofac" Version="8.3.4" />
    <ProjectReference Include="..\CoreFW.Application.Contracts\CoreFW.Application.Contracts.csproj" />
    <ProjectReference Include="..\CoreFW.EntityFrameworkCore\CoreFW.EntityFrameworkCore.csproj" />
  </ItemGroup>

  <ItemGroup>
    <Compile Remove="Logs\**" />
    <Content Remove="Logs\**" />
    <EmbeddedResource Remove="Logs\**" />
    <None Remove="Logs\**" />
  </ItemGroup>

</Project>
````

## File: src/CoreFW.DbMigrator/CoreFWDbMigratorModule.cs
````csharp
using CoreFW.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CoreFW.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CoreFWEntityFrameworkCoreModule),
    typeof(CoreFWApplicationContractsModule)
    )]
public class CoreFWDbMigratorModule : AbpModule
{
}
````

## File: src/CoreFW.DbMigrator/DbMigratorHostedService.cs
````csharp
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CoreFW.Data;
using Serilog;
using Volo.Abp;
using Volo.Abp.Data;

namespace CoreFW.DbMigrator;

public class DbMigratorHostedService : IHostedService
{
    private readonly IHostApplicationLifetime _hostApplicationLifetime;
    private readonly IConfiguration _configuration;

    public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime, IConfiguration configuration)
    {
        _hostApplicationLifetime = hostApplicationLifetime;
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using (var application = await AbpApplicationFactory.CreateAsync<CoreFWDbMigratorModule>(options =>
        {
           options.Services.ReplaceConfiguration(_configuration);
           options.UseAutofac();
           options.Services.AddLogging(c => c.AddSerilog());
           options.AddDataMigrationEnvironment();
        }))
        {
            await application.InitializeAsync();

            await application
                .ServiceProvider
                .GetRequiredService<CoreFWDbMigrationService>()
                .MigrateAsync();

            await application.ShutdownAsync();

            _hostApplicationLifetime.StopApplication();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
````

## File: src/CoreFW.DbMigrator/Program.cs
````csharp
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace CoreFW.DbMigrator;

class Program
{
    static async Task Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Volo.Abp", LogEventLevel.Warning)
#if DEBUG
                .MinimumLevel.Override("CoreFW", LogEventLevel.Debug)
#else
                .MinimumLevel.Override("CoreFW", LogEventLevel.Information)
#endif
                .Enrich.FromLogContext()
            .WriteTo.Async(c => c.File("Logs/logs.txt"))
            .WriteTo.Async(c => c.Console())
            .CreateLogger();

        await CreateHostBuilder(args).RunConsoleAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .AddAppSettingsSecretsJson()
            .ConfigureLogging((context, logging) => logging.ClearProviders())
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<DbMigratorHostedService>();
            });
}
````

## File: src/CoreFW.Domain/Data/CoreFWDbMigrationService.cs
````csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.TenantManagement;

namespace CoreFW.Data;

public class CoreFWDbMigrationService : ITransientDependency
{
    public ILogger<CoreFWDbMigrationService> Logger { get; set; }

    private readonly IDataSeeder _dataSeeder;
    private readonly IEnumerable<ICoreFWDbSchemaMigrator> _dbSchemaMigrators;
    private readonly ITenantRepository _tenantRepository;
    private readonly ICurrentTenant _currentTenant;

    public CoreFWDbMigrationService(
        IDataSeeder dataSeeder,
        IEnumerable<ICoreFWDbSchemaMigrator> dbSchemaMigrators,
        ITenantRepository tenantRepository,
        ICurrentTenant currentTenant)
    {
        _dataSeeder = dataSeeder;
        _dbSchemaMigrators = dbSchemaMigrators;
        _tenantRepository = tenantRepository;
        _currentTenant = currentTenant;

        Logger = NullLogger<CoreFWDbMigrationService>.Instance;
    }

    public async Task MigrateAsync()
    {
        var initialMigrationAdded = AddInitialMigrationIfNotExist();

        if (initialMigrationAdded)
        {
            return;
        }

        Logger.LogInformation("Started database migrations...");

        await MigrateDatabaseSchemaAsync();
        await SeedDataAsync();

        Logger.LogInformation($"Successfully completed host database migrations.");

        var tenants = await _tenantRepository.GetListAsync(includeDetails: true);

        var migratedDatabaseSchemas = new HashSet<string>();
        foreach (var tenant in tenants)
        {
            using (_currentTenant.Change(tenant.Id))
            {
                if (tenant.ConnectionStrings.Any())
                {
                    var tenantConnectionStrings = tenant.ConnectionStrings
                        .Select(x => x.Value)
                        .ToList();

                    if (!migratedDatabaseSchemas.IsSupersetOf(tenantConnectionStrings))
                    {
                        await MigrateDatabaseSchemaAsync(tenant);

                        migratedDatabaseSchemas.AddIfNotContains(tenantConnectionStrings);
                    }
                }

                await SeedDataAsync(tenant);
            }

            Logger.LogInformation($"Successfully completed {tenant.Name} tenant database migrations.");
        }

        Logger.LogInformation("Successfully completed all database migrations.");
        Logger.LogInformation("You can safely end this process...");
    }

    private async Task MigrateDatabaseSchemaAsync(Tenant? tenant = null)
    {
        Logger.LogInformation(
            $"Migrating schema for {(tenant == null ? "host" : tenant.Name + " tenant")} database...");

        foreach (var migrator in _dbSchemaMigrators)
        {
            await migrator.MigrateAsync();
        }
    }

    private async Task SeedDataAsync(Tenant? tenant = null)
    {
        Logger.LogInformation($"Executing {(tenant == null ? "host" : tenant.Name + " tenant")} database seed...");

        await _dataSeeder.SeedAsync(new DataSeedContext(tenant?.Id)
            .WithProperty(IdentityDataSeedContributor.AdminEmailPropertyName, IdentityDataSeedContributor.AdminEmailDefaultValue)
            .WithProperty(IdentityDataSeedContributor.AdminPasswordPropertyName, IdentityDataSeedContributor.AdminPasswordDefaultValue)
        );
    }

    private bool AddInitialMigrationIfNotExist()
    {
        try
        {
            if (!DbMigrationsProjectExists())
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }

        try
        {
            if (!MigrationsFolderExists())
            {
                AddInitialMigration();
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception e)
        {
            Logger.LogWarning("Couldn't determinate if any migrations exist : " + e.Message);
            return false;
        }
    }

    private bool DbMigrationsProjectExists()
    {
        var dbMigrationsProjectFolder = GetEntityFrameworkCoreProjectFolderPath();

        return dbMigrationsProjectFolder != null;
    }

    private bool MigrationsFolderExists()
    {
        var dbMigrationsProjectFolder = GetEntityFrameworkCoreProjectFolderPath();
        return dbMigrationsProjectFolder != null && Directory.Exists(Path.Combine(dbMigrationsProjectFolder, "Migrations"));
    }

    private void AddInitialMigration()
    {
        Logger.LogInformation("Creating initial migration...");

        string argumentPrefix;
        string fileName;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) || RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            argumentPrefix = "-c";
            fileName = "/bin/bash";
        }
        else
        {
            argumentPrefix = "/C";
            fileName = "cmd.exe";
        }

        var procStartInfo = new ProcessStartInfo(fileName,
            $"{argumentPrefix} \"abp create-migration-and-run-migrator \"{GetEntityFrameworkCoreProjectFolderPath()}\"\""
        );

        try
        {
            Process.Start(procStartInfo);
        }
        catch (Exception)
        {
            throw new Exception("Couldn't run ABP CLI...");
        }
    }

    private string? GetEntityFrameworkCoreProjectFolderPath()
    {
        var slnDirectoryPath = GetSolutionDirectoryPath();

        if (slnDirectoryPath == null)
        {
            throw new Exception("Solution folder not found!");
        }

        var srcDirectoryPath = Path.Combine(slnDirectoryPath, "src");

        return Directory.GetDirectories(srcDirectoryPath)
            .FirstOrDefault(d => d.EndsWith(".EntityFrameworkCore"));
    }

    private string? GetSolutionDirectoryPath()
    {
        var currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());

        while (currentDirectory != null && Directory.GetParent(currentDirectory.FullName) != null)
        {
            currentDirectory = Directory.GetParent(currentDirectory.FullName);

            if (currentDirectory != null && Directory.GetFiles(currentDirectory.FullName).FirstOrDefault(f => f.EndsWith(".sln")) != null)
            {
                return currentDirectory.FullName;
            }
        }

        return null;
    }
}
````

## File: src/CoreFW.Domain/Data/ICoreFWDbSchemaMigrator.cs
````csharp
using System.Threading.Tasks;

namespace CoreFW.Data;

public interface ICoreFWDbSchemaMigrator
{
    Task MigrateAsync();
}
````

## File: src/CoreFW.Domain/Data/NullCoreFWDbSchemaMigrator.cs
````csharp
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CoreFW.Data;

/* This is used if database provider does't define
 * ICoreFWDbSchemaMigrator implementation.
 */
public class NullCoreFWDbSchemaMigrator : ICoreFWDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
````

## File: src/CoreFW.Domain/OpenIddict/OpenIddictDataSeedContributor.cs
````csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using OpenIddict.Abstractions;
using Volo.Abp;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.OpenIddict.Applications;
using Volo.Abp.OpenIddict.Scopes;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Uow;

namespace CoreFW.OpenIddict;

/* Creates initial data that is needed to property run the application
 * and make client-to-server communication possible.
 */
public class OpenIddictDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IConfiguration _configuration;
    private readonly IOpenIddictApplicationRepository _openIddictApplicationRepository;
    private readonly IAbpApplicationManager _applicationManager;
    private readonly IOpenIddictScopeRepository _openIddictScopeRepository;
    private readonly IOpenIddictScopeManager _scopeManager;
    private readonly IPermissionDataSeeder _permissionDataSeeder;
    private readonly IStringLocalizer<OpenIddictResponse> L;

    public OpenIddictDataSeedContributor(
        IConfiguration configuration,
        IOpenIddictApplicationRepository openIddictApplicationRepository,
        IAbpApplicationManager applicationManager,
        IOpenIddictScopeRepository openIddictScopeRepository,
        IOpenIddictScopeManager scopeManager,
        IPermissionDataSeeder permissionDataSeeder,
        IStringLocalizer<OpenIddictResponse> l )
    {
        _configuration = configuration;
        _openIddictApplicationRepository = openIddictApplicationRepository;
        _applicationManager = applicationManager;
        _openIddictScopeRepository = openIddictScopeRepository;
        _scopeManager = scopeManager;
        _permissionDataSeeder = permissionDataSeeder;
        L = l;
    }

    [UnitOfWork]
    public virtual async Task SeedAsync(DataSeedContext context)
    {
        await CreateScopesAsync();
        await CreateApplicationsAsync();
    }

    private async Task CreateScopesAsync()
    {
        if (await _openIddictScopeRepository.FindByNameAsync("CoreFW") == null)
        {
            await _scopeManager.CreateAsync(new OpenIddictScopeDescriptor {
                Name = "CoreFW", DisplayName = "CoreFW API", Resources = { "CoreFW" }
            });
        }
    }

    private async Task CreateApplicationsAsync()
    {
        var commonScopes = new List<string> {
            OpenIddictConstants.Permissions.Scopes.Address,
            OpenIddictConstants.Permissions.Scopes.Email,
            OpenIddictConstants.Permissions.Scopes.Phone,
            OpenIddictConstants.Permissions.Scopes.Profile,
            OpenIddictConstants.Permissions.Scopes.Roles,
            "CoreFW"
        };

        var configurationSection = _configuration.GetSection("OpenIddict:Applications");






        // Swagger Client
        var swaggerClientId = configurationSection["CoreFW_Swagger:ClientId"];
        if (!swaggerClientId.IsNullOrWhiteSpace())
        {
            var swaggerRootUrl = configurationSection["CoreFW_Swagger:RootUrl"]?.TrimEnd('/');

            await CreateApplicationAsync(
                name: swaggerClientId!,
                type: OpenIddictConstants.ClientTypes.Public,
                consentType: OpenIddictConstants.ConsentTypes.Implicit,
                displayName: "Swagger Application",
                secret: null,
                grantTypes: new List<string> { OpenIddictConstants.GrantTypes.AuthorizationCode, },
                scopes: commonScopes,
                redirectUri: $"{swaggerRootUrl}/swagger/oauth2-redirect.html",
                clientUri: swaggerRootUrl
            );
        }
    }

    private async Task CreateApplicationAsync(
        [NotNull] string name,
        [NotNull] string type,
        [NotNull] string consentType,
        string displayName,
        string? secret,
        List<string> grantTypes,
        List<string> scopes,
        string? clientUri = null,
        string? redirectUri = null,
        string? postLogoutRedirectUri = null,
        List<string>? permissions = null)
    {
        if (!string.IsNullOrEmpty(secret) && string.Equals(type, OpenIddictConstants.ClientTypes.Public,
                StringComparison.OrdinalIgnoreCase))
        {
            throw new BusinessException(L["NoClientSecretCanBeSetForPublicApplications"]);
        }

        if (string.IsNullOrEmpty(secret) && string.Equals(type, OpenIddictConstants.ClientTypes.Confidential,
                StringComparison.OrdinalIgnoreCase))
        {
            throw new BusinessException(L["TheClientSecretIsRequiredForConfidentialApplications"]);
        }

        var client = await _openIddictApplicationRepository.FindByClientIdAsync(name);

        var application = new AbpApplicationDescriptor {
            ClientId = name,
            ClientType = type,
            ClientSecret = secret,
            ConsentType = consentType,
            DisplayName = displayName,
            ClientUri = clientUri,
        };

        Check.NotNullOrEmpty(grantTypes, nameof(grantTypes));
        Check.NotNullOrEmpty(scopes, nameof(scopes));

        if (new[] { OpenIddictConstants.GrantTypes.AuthorizationCode, OpenIddictConstants.GrantTypes.Implicit }.All(
                grantTypes.Contains))
        {
            application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeIdToken);

            if (string.Equals(type, OpenIddictConstants.ClientTypes.Public, StringComparison.OrdinalIgnoreCase))
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeIdTokenToken);
                application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeToken);
            }
        }

        if (!redirectUri.IsNullOrWhiteSpace() || !postLogoutRedirectUri.IsNullOrWhiteSpace())
        {
            application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Logout);
        }

        var buildInGrantTypes = new[] {
            OpenIddictConstants.GrantTypes.Implicit, OpenIddictConstants.GrantTypes.Password,
            OpenIddictConstants.GrantTypes.AuthorizationCode, OpenIddictConstants.GrantTypes.ClientCredentials,
            OpenIddictConstants.GrantTypes.DeviceCode, OpenIddictConstants.GrantTypes.RefreshToken
        };

        foreach (var grantType in grantTypes)
        {
            if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.AuthorizationCode);
                application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.Code);
            }

            if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode ||
                grantType == OpenIddictConstants.GrantTypes.Implicit)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Authorization);
            }

            if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode ||
                grantType == OpenIddictConstants.GrantTypes.ClientCredentials ||
                grantType == OpenIddictConstants.GrantTypes.Password ||
                grantType == OpenIddictConstants.GrantTypes.RefreshToken ||
                grantType == OpenIddictConstants.GrantTypes.DeviceCode)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Token);
                application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Revocation);
                application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Introspection);
            }

            if (grantType == OpenIddictConstants.GrantTypes.ClientCredentials)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.ClientCredentials);
            }

            if (grantType == OpenIddictConstants.GrantTypes.Implicit)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.Implicit);
            }

            if (grantType == OpenIddictConstants.GrantTypes.Password)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.Password);
            }

            if (grantType == OpenIddictConstants.GrantTypes.RefreshToken)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.RefreshToken);
            }

            if (grantType == OpenIddictConstants.GrantTypes.DeviceCode)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.DeviceCode);
                application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Device);
            }

            if (grantType == OpenIddictConstants.GrantTypes.Implicit)
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.IdToken);
                if (string.Equals(type, OpenIddictConstants.ClientTypes.Public, StringComparison.OrdinalIgnoreCase))
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.IdTokenToken);
                    application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.Token);
                }
            }

            if (!buildInGrantTypes.Contains(grantType))
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.Prefixes.GrantType + grantType);
            }
        }

        var buildInScopes = new[] {
            OpenIddictConstants.Permissions.Scopes.Address, OpenIddictConstants.Permissions.Scopes.Email,
            OpenIddictConstants.Permissions.Scopes.Phone, OpenIddictConstants.Permissions.Scopes.Profile,
            OpenIddictConstants.Permissions.Scopes.Roles
        };

        foreach (var scope in scopes)
        {
            if (buildInScopes.Contains(scope))
            {
                application.Permissions.Add(scope);
            }
            else
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.Prefixes.Scope + scope);
            }
        }

        if (redirectUri != null)
        {
            if (!redirectUri.IsNullOrEmpty())
            {
                if (!Uri.TryCreate(redirectUri, UriKind.Absolute, out var uri) || !uri.IsWellFormedOriginalString())
                {
                    throw new BusinessException(L["InvalidRedirectUri", redirectUri]);
                }

                if (application.RedirectUris.All(x => x != uri))
                {
                    application.RedirectUris.Add(uri);
                }
            }
        }

        if (postLogoutRedirectUri != null)
        {
            if (!postLogoutRedirectUri.IsNullOrEmpty())
            {
                if (!Uri.TryCreate(postLogoutRedirectUri, UriKind.Absolute, out var uri) ||
                    !uri.IsWellFormedOriginalString())
                {
                    throw new BusinessException(L["InvalidPostLogoutRedirectUri", postLogoutRedirectUri]);
                }

                if (application.PostLogoutRedirectUris.All(x => x != uri))
                {
                    application.PostLogoutRedirectUris.Add(uri);
                }
            }
        }

        if (permissions != null)
        {
            await _permissionDataSeeder.SeedAsync(
                ClientPermissionValueProvider.ProviderName,
                name,
                permissions,
                null
            );
        }

        if (client == null)
        {
            await _applicationManager.CreateAsync(application);
            return;
        }

        if (!HasSameRedirectUris(client, application))
        {
            client.RedirectUris = JsonSerializer.Serialize(application.RedirectUris.Select(q => q.ToString().TrimEnd('/')));
            client.PostLogoutRedirectUris = JsonSerializer.Serialize(application.PostLogoutRedirectUris.Select(q => q.ToString().TrimEnd('/')));

            await _applicationManager.UpdateAsync(client.ToModel());
        }

        if (!HasSameScopes(client, application))
        {
            client.Permissions = JsonSerializer.Serialize(application.Permissions.Select(q => q.ToString()));
            await _applicationManager.UpdateAsync(client.ToModel());
        }
    }

    private bool HasSameRedirectUris(OpenIddictApplication existingClient, AbpApplicationDescriptor application)
    {
        return existingClient.RedirectUris == JsonSerializer.Serialize(application.RedirectUris.Select(q => q.ToString().TrimEnd('/')));
    }

    private bool HasSameScopes(OpenIddictApplication existingClient, AbpApplicationDescriptor application)
    {
        return existingClient.Permissions == JsonSerializer.Serialize(application.Permissions.Select(q => q.ToString().TrimEnd('/')));
    }
}
````

## File: src/CoreFW.Domain/Properties/AssemblyInfo.cs
````csharp
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleToAttribute("CoreFW.Domain.Tests")]
[assembly:InternalsVisibleToAttribute("CoreFW.TestBase")]
````

## File: src/CoreFW.Domain/Settings/CoreFWSettingDefinitionProvider.cs
````csharp
using Volo.Abp.Settings;

namespace CoreFW.Settings;

public class CoreFWSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CoreFWSettings.MySetting1));
    }
}
````

## File: src/CoreFW.Domain/Settings/CoreFWSettings.cs
````csharp
namespace CoreFW.Settings;

public static class CoreFWSettings
{
    private const string Prefix = "CoreFW";

    //Add your own setting names here. Example:
    //public const string MySetting1 = Prefix + ".MySetting1";
}
````

## File: src/CoreFW.Domain/CoreFW.Domain.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\CoreFW.Domain.Shared\CoreFW.Domain.Shared.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.Emailing" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Identity.Domain" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.PermissionManagement.Domain.Identity" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.BackgroundJobs.Domain" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.AuditLogging.Domain" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.TenantManagement.Domain" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.FeatureManagement.Domain" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.SettingManagement.Domain" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.OpenIddict.Domain" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.PermissionManagement.Domain.OpenIddict" Version="8.3.4" />
  </ItemGroup>

</Project>
````

## File: src/CoreFW.Domain/CoreFWConsts.cs
````csharp
namespace CoreFW;

public static class CoreFWConsts
{
    public const string DbTablePrefix = "App";

    public const string DbSchema = null;
}
````

## File: src/CoreFW.Domain/CoreFWDomainModule.cs
````csharp
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using CoreFW.MultiTenancy;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Emailing;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.OpenIddict;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.OpenIddict;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWDomainSharedModule),
    typeof(AbpAuditLoggingDomainModule),
    typeof(AbpBackgroundJobsDomainModule),
    typeof(AbpFeatureManagementDomainModule),
    typeof(AbpIdentityDomainModule),
    typeof(AbpOpenIddictDomainModule),
    typeof(AbpPermissionManagementDomainOpenIddictModule),
    typeof(AbpPermissionManagementDomainIdentityModule),
    typeof(AbpSettingManagementDomainModule),
    typeof(AbpTenantManagementDomainModule),
    typeof(AbpEmailingModule)
)]
public class CoreFWDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Languages.Add(new LanguageInfo("ar", "ar", "العربية"));
            options.Languages.Add(new LanguageInfo("cs", "cs", "Čeština"));
            options.Languages.Add(new LanguageInfo("en", "en", "English"));
            options.Languages.Add(new LanguageInfo("en-GB", "en-GB", "English (UK)"));
            options.Languages.Add(new LanguageInfo("hu", "hu", "Magyar"));
            options.Languages.Add(new LanguageInfo("hr", "hr", "Croatian"));
            options.Languages.Add(new LanguageInfo("fi", "fi", "Finnish"));
            options.Languages.Add(new LanguageInfo("fr", "fr", "Français"));
            options.Languages.Add(new LanguageInfo("hi", "hi", "Hindi"));
            options.Languages.Add(new LanguageInfo("it", "it", "Italiano"));
            options.Languages.Add(new LanguageInfo("pt-BR", "pt-BR", "Português"));
            options.Languages.Add(new LanguageInfo("ru", "ru", "Русский"));
            options.Languages.Add(new LanguageInfo("sk", "sk", "Slovak"));
            options.Languages.Add(new LanguageInfo("tr", "tr", "Türkçe"));
            options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文"));
            options.Languages.Add(new LanguageInfo("zh-Hant", "zh-Hant", "繁體中文"));
            options.Languages.Add(new LanguageInfo("de-DE", "de-DE", "Deutsch"));
            options.Languages.Add(new LanguageInfo("es", "es", "Español"));
        });

        Configure<AbpMultiTenancyOptions>(options =>
        {
            options.IsEnabled = MultiTenancyConsts.IsEnabled;
        });

#if DEBUG
        context.Services.Replace(ServiceDescriptor.Singleton<IEmailSender, NullEmailSender>());
#endif
    }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/ar.json
````json
{
  "culture": "ar",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "الصفحة الرئيسية",
    "Welcome": "مرحباً",
    "LongWelcomeMessage": "مرحبا بكم في التطبيق. هذا مشروع بدء تشغيل يعتمد على إطار عمل ABP. لمزيد من المعلومات ، يرجى زيارة abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/cs.json
````json
{
  "culture": "cs",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Úvod",
    "Welcome": "Vítejte",
    "LongWelcomeMessage": "Vítejte v aplikaci. Toto je startovací projekt založený na ABP frameworku. Pro více informací, navštivte abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/de.json
````json
{
  "culture": "de",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Home",
    "Welcome": "Willkommen",
    "LongWelcomeMessage": "Willkommen bei der Anwendung. Dies ist ein Startup-Projekt, das auf dem ABP-Framework basiert. Weitere Informationen finden Sie unter abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/en-GB.json
````json
{
  "culture": "en-GB",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Home",
    "Welcome": "Welcome",
    "LongWelcomeMessage": "Welcome to the application. This is a startup project based on the ABP framework. For more information, visit abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/en.json
````json
{
  "culture": "en",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Home",
    "Welcome": "Welcome",
    "LongWelcomeMessage": "Welcome to the application. This is a startup project based on the ABP framework. For more information, visit abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/es.json
````json
{
  "culture": "es",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Inicio",
    "Welcome": "Bienvenido",
    "LongWelcomeMessage": "Bienvenido a la aplicación, este es un proyecto base basado en el framework ABP. Para más información, visita abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/fi.json
````json
{
  "culture": "fi",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Koti",
    "Welcome": "Tervetuloa",
    "LongWelcomeMessage": "Tervetuloa sovellukseen. Tämä on ABP-kehykseen perustuva käynnistysprojekti. Lisätietoja on osoitteessa abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/fr.json
````json
{
 "culture": "fr",
 "texts": {
  "AppName": "CoreFW",
  "Menu:Home": "Accueil",
  "Welcome": "Bienvenue",
  "LongWelcomeMessage": "Bienvenue dans l'application. Il s'agit d'un projet de démarrage basé sur le framework ABP. Pour plus d'informations, visitez abp.io."
 }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/hi.json
````json
{
  "culture": "hi",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "घर",
    "Welcome": "स्वागत हे",
    "LongWelcomeMessage": "आवेदन करने के लिए आपका स्वागत है। यह एबीपी ढांचे पर आधारित एक स्टार्टअप परियोजना है। अधिक जानकारी के लिए, abp.io पर जाएं।"
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/hr.json
````json
{
    "culture": "hr",
    "texts": {
        "AppName": "CoreFW",
        "Menu:Home": "Početna",
        "Welcome": "Dobrodošli",
        "LongWelcomeMessage": "Dobrodošli u aplikaciju. Ovo je startup projekt temeljen na ABP framework-u. Za više informacija posjetite abp.io."
    }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/hu.json
````json
{
  "culture": "hu",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Kezdőlap",
    "Welcome": "Üdvözlöm",
    "LongWelcomeMessage": "Üdvözöljük az alkalmazásban. Ez egy ABP keretrendszeren alapuló startup projekt. További információkért látogasson el az abp.io oldalra."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/is.json
````json
{
  "culture": "is",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Heim",
    "Welcome": "Velkomin",
    "LongWelcomeMessage": "Verið velkomin í forritið. Þetta er startup verkefni sem byggir á ABP. Nánari upplýsingar er að finna á abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/it.json
````json
{
  "culture": "it",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Home",
    "Welcome": "Benvenuto",
    "LongWelcomeMessage": "Benvenuto nell'applicazione. Questo è un progetto di avvio basato sul framework ABP. Per ulteriori informazioni, visita abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/nl.json
````json
{
  "culture": "nl",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Home",
    "Welcome": "Welkom",
    "LongWelcomeMessage": "Welkom bij de applicatie. Dit is een startup-project gebaseerd op het ABP-framework. Bezoek abp.io voor meer informatie."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/pl-PL.json
````json
{
  "culture": "pl-PL",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Home",
    "Welcome": "Witaj",
    "LongWelcomeMessage": "Witaj w aplikacji. To jest inicjalny projekt bazujący na ABP framework. Po więcej informacji odwiedź stronę abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/pt-BR.json
````json
{
  "culture": "pt-BR",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Principal",
    "Welcome": "Seja bem-vindo!",
    "LongWelcomeMessage": "Bem-vindo a esta aplicação. Este é um projeto inicial baseado no ABP framework. Para mais informações, visite abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/ro-RO.json
````json
{
  "culture": "ro-RO",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Acasă",
    "Welcome": "Bun venit",
    "LongWelcomeMessage": "Bun venit la aplicaţie. Acesta este un proiect de pornire bazat pe framework-ul ABP. Pentru mai multe informaţii, vizitaţi, visit abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/ru.json
````json
{
  "culture": "ru",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Главная",
    "Welcome": "Добро пожаловать",
    "LongWelcomeMessage": "Добро пожаловать в приложение. Этот запущенный проект основан на фреймворке ABP. Для получения дополнительной информации посетите сайт abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/sk.json
````json
{
  "culture": "sk",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Domov",
    "Welcome": "Vitajte",
    "LongWelcomeMessage": "Vitajte v aplikácii. Toto je štartovací projekt založený na ABP frameworku. Viac informácií nájdete na stránke abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/sl.json
````json
{
  "culture": "sl",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Domov",
    "Welcome": "Dobrodošli",
    "LongWelcomeMessage": "Dobrodošli v aplikaciji. To je začetni projekt na osnovi okolja ABP. Za več informacij obiščite abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/sv.json
````json
{
  "culture": "sv",
  "texts": {
    "AppName": "MittProjektNamn",
    "Menu:Home": "Hem",
    "Welcome": "Välkommen",
    "LongWelcomeMessage": "Välkommen till applikationen. Detta är ett startup-projekt baserat på ABP-ramverket. För mer information, besök abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/tr.json
````json
{
  "culture": "tr",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Ana sayfa",
    "Welcome": "Hoşgeldiniz",
    "LongWelcomeMessage": "Uygulamaya hoşgeldiniz. Bu, ABP framework'ü üzerine bina edilmiş bir başlangıç projesidir. Daha fazla bilgi için abp.io adresini ziyaret edebilirsiniz."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/vi.json
````json
{
  "culture": "vi",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "Trang chủ",
    "Welcome": "Chào mừng bạn",
    "LongWelcomeMessage": "Chào mừng bạn đến ứng dụng. Đây là một dự án khởi nghiệp dựa trên khung ABP. Để biết thêm thông tin, hãy truy cập abp.io."
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/zh-Hans.json
````json
{
  "culture": "zh-Hans",
  "texts": {
    "AppName": "CoreFW",
    "Menu:Home": "首页",
    "Welcome": "欢迎",
    "LongWelcomeMessage": "欢迎使用本应用程序。这是一个基于 ABP 框架的启动项目。更多信息，请访问 abp.io。"
  }
}
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFW/zh-Hant.json
````json
{
    "culture": "zh-Hant",
    "texts": {
      "AppName": "CoreFW",
      "Menu:Home": "首頁",
      "Welcome": "歡迎",
      "LongWelcomeMessage": "歡迎來到此應用程式. 這是一個基於ABP框架的起始專案. 有關更多訊息, 請瀏覽 abp.io."
    }
  }
````

## File: src/CoreFW.Domain.Shared/Localization/CoreFWResource.cs
````csharp
using Volo.Abp.Localization;

namespace CoreFW.Localization;

[LocalizationResourceName("CoreFW")]
public class CoreFWResource
{

}
````

## File: src/CoreFW.Domain.Shared/MultiTenancy/MultiTenancyConsts.cs
````csharp
namespace CoreFW.MultiTenancy;

public static class MultiTenancyConsts
{
    /* Enable/disable multi-tenancy easily in a single point.
     * If you will never need to multi-tenancy, you can remove
     * related modules and code parts, including this file.
     */
    public const bool IsEnabled = true;
}
````

## File: src/CoreFW.Domain.Shared/CoreFW.Domain.Shared.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
    <GenerateEmbeddedFilesManifest>true</GenerateEmbeddedFilesManifest>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.Identity.Domain.Shared" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.BackgroundJobs.Domain.Shared" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.AuditLogging.Domain.Shared" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.TenantManagement.Domain.Shared" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.FeatureManagement.Domain.Shared" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.PermissionManagement.Domain.Shared" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.SettingManagement.Domain.Shared" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.OpenIddict.Domain.Shared" Version="8.3.4" />
  </ItemGroup>

  <ItemGroup>
    <EmbeddedResource Include="Localization\CoreFW\*.json" />
    <Content Remove="Localization\CoreFW\*.json" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.Extensions.FileProviders.Embedded" Version="8.0.4" />
  </ItemGroup>

</Project>
````

## File: src/CoreFW.Domain.Shared/CoreFWDomainErrorCodes.cs
````csharp
namespace CoreFW;

public static class CoreFWDomainErrorCodes
{
    /* You can add your business exception error codes here, as constants */
}
````

## File: src/CoreFW.Domain.Shared/CoreFWDomainSharedModule.cs
````csharp
using CoreFW.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace CoreFW;

[DependsOn(
    typeof(AbpAuditLoggingDomainSharedModule),
    typeof(AbpBackgroundJobsDomainSharedModule),
    typeof(AbpFeatureManagementDomainSharedModule),
    typeof(AbpIdentityDomainSharedModule),
    typeof(AbpOpenIddictDomainSharedModule),
    typeof(AbpPermissionManagementDomainSharedModule),
    typeof(AbpSettingManagementDomainSharedModule),
    typeof(AbpTenantManagementDomainSharedModule)    
    )]
public class CoreFWDomainSharedModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        CoreFWGlobalFeatureConfigurator.Configure();
        CoreFWModuleExtensionConfigurator.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CoreFWDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<CoreFWResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/CoreFW");

            options.DefaultResourceType = typeof(CoreFWResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("CoreFW", typeof(CoreFWResource));
        });
    }
}
````

## File: src/CoreFW.Domain.Shared/CoreFWGlobalFeatureConfigurator.cs
````csharp
using Volo.Abp.Threading;

namespace CoreFW;

public static class CoreFWGlobalFeatureConfigurator
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        OneTimeRunner.Run(() =>
        {
                /* You can configure (enable/disable) global features of the used modules here.
                 *
                 * YOU CAN SAFELY DELETE THIS CLASS AND REMOVE ITS USAGES IF YOU DON'T NEED TO IT!
                 *
                 * Please refer to the documentation to lear more about the Global Features System:
                 * https://docs.abp.io/en/abp/latest/Global-Features
                 */
        });
    }
}
````

## File: src/CoreFW.Domain.Shared/CoreFWModuleExtensionConfigurator.cs
````csharp
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace CoreFW;

public static class CoreFWModuleExtensionConfigurator
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        OneTimeRunner.Run(() =>
        {
            ConfigureExistingProperties();
            ConfigureExtraProperties();
        });
    }

    private static void ConfigureExistingProperties()
    {
        /* You can change max lengths for properties of the
         * entities defined in the modules used by your application.
         *
         * Example: Change user and role name max lengths

           AbpUserConsts.MaxNameLength = 99;
           IdentityRoleConsts.MaxNameLength = 99;

         * Notice: It is not suggested to change property lengths
         * unless you really need it. Go with the standard values wherever possible.
         *
         * If you are using EF Core, you will need to run the add-migration command after your changes.
         */
    }

    private static void ConfigureExtraProperties()
    {
        /* You can configure extra properties for the
         * entities defined in the modules used by your application.
         *
         * This class can be used to define these extra properties
         * with a high level, easy to use API.
         *
         * Example: Add a new property to the user entity of the identity module

           ObjectExtensionManager.Instance.Modules()
              .ConfigureIdentity(identity =>
              {
                  identity.ConfigureUser(user =>
                  {
                      user.AddOrUpdateProperty<string>( //property type: string
                          "SocialSecurityNumber", //property name
                          property =>
                          {
                              //validation rules
                              property.Attributes.Add(new RequiredAttribute());
                              property.Attributes.Add(new StringLengthAttribute(64) {MinimumLength = 4});
                              
                              property.Configuration[IdentityModuleExtensionConsts.ConfigurationNames.AllowUserToEdit] = true;

                              //...other configurations for this property
                          }
                      );
                  });
              });

         * See the documentation for more:
         * https://docs.abp.io/en/abp/latest/Module-Entity-Extensions
         */
    }
}
````

## File: src/CoreFW.EntityFrameworkCore/EntityFrameworkCore/CoreFWDbContext.cs
````csharp
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace CoreFW.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class CoreFWDbContext :
    AbpDbContext<CoreFWDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }
    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public CoreFWDbContext(DbContextOptions<CoreFWDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(CoreFWConsts.DbTablePrefix + "YourEntities", CoreFWConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }
}
````

## File: src/CoreFW.EntityFrameworkCore/EntityFrameworkCore/CoreFWDbContextFactory.cs
````csharp
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CoreFW.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class CoreFWDbContextFactory : IDesignTimeDbContextFactory<CoreFWDbContext>
{
    public CoreFWDbContext CreateDbContext(string[] args)
    {
        CoreFWEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<CoreFWDbContext>()
            .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);

        return new CoreFWDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CoreFW.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
````

## File: src/CoreFW.EntityFrameworkCore/EntityFrameworkCore/CoreFWEfCoreEntityExtensionMappings.cs
````csharp
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace CoreFW.EntityFrameworkCore;

public static class CoreFWEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        CoreFWGlobalFeatureConfigurator.Configure();
        CoreFWModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
                /* You can configure extra properties for the
                 * entities defined in the modules used by your application.
                 *
                 * This class can be used to map these extra properties to table fields in the database.
                 *
                 * USE THIS CLASS ONLY TO CONFIGURE EF CORE RELATED MAPPING.
                 * USE CoreFWModuleExtensionConfigurator CLASS (in the Domain.Shared project)
                 * FOR A HIGH LEVEL API TO DEFINE EXTRA PROPERTIES TO ENTITIES OF THE USED MODULES
                 *
                 * Example: Map a property to a table field:

                     ObjectExtensionManager.Instance
                         .MapEfCoreProperty<IdentityUser, string>(
                             "MyProperty",
                             (entityBuilder, propertyBuilder) =>
                             {
                                 propertyBuilder.HasMaxLength(128);
                             }
                         );

                 * See the documentation for more:
                 * https://docs.abp.io/en/abp/latest/Customizing-Application-Modules-Extending-Entities
                 */
        });
    }
}
````

## File: src/CoreFW.EntityFrameworkCore/EntityFrameworkCore/CoreFWEntityFrameworkCoreModule.cs
````csharp
using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Uow;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace CoreFW.EntityFrameworkCore;

[DependsOn(
    typeof(CoreFWDomainModule),
    typeof(AbpIdentityEntityFrameworkCoreModule),
    typeof(AbpOpenIddictEntityFrameworkCoreModule),
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreMySQLModule),
    typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),
    typeof(AbpTenantManagementEntityFrameworkCoreModule),
    typeof(AbpFeatureManagementEntityFrameworkCoreModule)
    )]
public class CoreFWEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        CoreFWEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<CoreFWDbContext>(options =>
        {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
                /* The main point to change your DBMS.
                 * See also CoreFWMigrationsDbContextFactory for EF Core tooling. */
            options.UseMySQL();
        });

    }
}
````

## File: src/CoreFW.EntityFrameworkCore/EntityFrameworkCore/EntityFrameworkCoreCoreFWDbSchemaMigrator.cs
````csharp
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoreFW.Data;
using Volo.Abp.DependencyInjection;

namespace CoreFW.EntityFrameworkCore;

public class EntityFrameworkCoreCoreFWDbSchemaMigrator
    : ICoreFWDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCoreFWDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CoreFWDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CoreFWDbContext>()
            .Database
            .MigrateAsync();
    }
}
````

## File: src/CoreFW.EntityFrameworkCore/Migrations/20250321103701_Initial.cs
````csharp
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreFW.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpAuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ApplicationName = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    TenantName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImpersonatorUserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ImpersonatorUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImpersonatorTenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ImpersonatorTenantName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExecutionTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "int", nullable: false),
                    ClientIpAddress = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CorrelationId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BrowserInfo = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HttpMethod = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Exceptions = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Comments = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HttpStatusCode = table.Column<int>(type: "int", nullable: true),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpBackgroundJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    JobName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JobArgs = table.Column<string>(type: "longtext", maxLength: 1048576, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TryCount = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NextTryTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastTryTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsAbandoned = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Priority = table.Column<byte>(type: "tinyint unsigned", nullable: false, defaultValue: (byte)15),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpBackgroundJobs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpClaimTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Required = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsStatic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Regex = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegexDescription = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValueType = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpClaimTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpFeatureGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatureGroups", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GroupName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParentName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultValue = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsVisibleToClients = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsAvailableToHost = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AllowedProviders = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValueType = table.Column<string>(type: "varchar(2048)", maxLength: 2048, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatures", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpFeatureValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatureValues", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpLinkUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SourceUserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SourceTenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    TargetUserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TargetTenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpLinkUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ParentId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Code = table.Column<string>(type: "varchar(95)", maxLength: 95, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntityVersion = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpOrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpPermissionGrants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPermissionGrants", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpPermissionGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPermissionGroups", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpPermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GroupName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParentName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MultiTenancySide = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Providers = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StateCheckers = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPermissions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsStatic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EntityVersion = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpSecurityLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ApplicationName = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Identity = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Action = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CorrelationId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientIpAddress = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BrowserInfo = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSecurityLogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpSessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SessionId = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Device = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeviceInfo = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ClientId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IpAddresses = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SignedIn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessed = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSessions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpSettingDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultValue = table.Column<string>(type: "varchar(2048)", maxLength: 2048, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsVisibleToClients = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Providers = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsInherited = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsEncrypted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSettingDefinitions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "varchar(2048)", maxLength: 2048, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSettings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpTenants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntityVersion = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpTenants", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpUserDelegations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SourceUserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TargetUserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserDelegations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    PasswordHash = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsExternal = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    PhoneNumber = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ShouldChangePasswordOnNextLogin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EntityVersion = table.Column<int>(type: "int", nullable: false),
                    LastPasswordChangeTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpenIddictApplications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ApplicationType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientSecret = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConsentType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayNames = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JsonWebKeySet = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Permissions = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostLogoutRedirectUris = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Properties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RedirectUris = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Requirements = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Settings = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientUri = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogoUri = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenIddictApplications", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpenIddictScopes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descriptions = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayNames = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Properties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resources = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenIddictScopes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpAuditLogActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    AuditLogId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ServiceName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MethodName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Parameters = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExecutionTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpAuditLogActions_AbpAuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "AbpAuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpEntityChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AuditLogId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ChangeTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ChangeType = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    EntityTenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    EntityId = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntityTypeFullName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityChanges_AbpAuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "AbpAuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpOrganizationUnitRoles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    OrganizationUnitId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpOrganizationUnitRoles", x => new { x.OrganizationUnitId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnitRoles_AbpOrganizationUnits_OrganizationUn~",
                        column: x => x.OrganizationUnitId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnitRoles_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpRoleClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ClaimType = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpTenantConnectionStrings",
                columns: table => new
                {
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpTenantConnectionStrings", x => new { x.TenantId, x.Name });
                    table.ForeignKey(
                        name: "FK_AbpTenantConnectionStrings_AbpTenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AbpTenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpUserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ClaimType = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUserClaims_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LoginProvider = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ProviderKey = table.Column<string>(type: "varchar(196)", maxLength: 196, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserLogins", x => new { x.UserId, x.LoginProvider });
                    table.ForeignKey(
                        name: "FK_AbpUserLogins_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpUserOrganizationUnits",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    OrganizationUnitId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserOrganizationUnits", x => new { x.OrganizationUnitId, x.UserId });
                    table.ForeignKey(
                        name: "FK_AbpUserOrganizationUnits_AbpOrganizationUnits_OrganizationUn~",
                        column: x => x.OrganizationUnitId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpUserOrganizationUnits_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AbpUserRoles_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpUserRoles_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LoginProvider = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AbpUserTokens_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpenIddictAuthorizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ApplicationId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Properties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Scopes = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subject = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenIddictAuthorizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenIddictAuthorizations_OpenIddictApplications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "OpenIddictApplications",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AbpEntityPropertyChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    EntityChangeId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    NewValue = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OriginalValue = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PropertyName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PropertyTypeFullName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalTable: "AbpEntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpenIddictTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ApplicationId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    AuthorizationId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Payload = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Properties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RedemptionDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ReferenceId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subject = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenIddictTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenIddictTokens_OpenIddictApplications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "OpenIddictApplications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpenIddictTokens_OpenIddictAuthorizations_AuthorizationId",
                        column: x => x.AuthorizationId,
                        principalTable: "OpenIddictAuthorizations",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogActions_AuditLogId",
                table: "AbpAuditLogActions",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogActions_TenantId_ServiceName_MethodName_Execution~",
                table: "AbpAuditLogActions",
                columns: new[] { "TenantId", "ServiceName", "MethodName", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "UserId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                columns: new[] { "IsAbandoned", "NextTryTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_AuditLogId",
                table: "AbpEntityChanges",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_TenantId_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                columns: new[] { "TenantId", "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatureGroups_Name",
                table: "AbpFeatureGroups",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_GroupName",
                table: "AbpFeatures",
                column: "GroupName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_Name",
                table: "AbpFeatures",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatureValues_Name_ProviderName_ProviderKey",
                table: "AbpFeatureValues",
                columns: new[] { "Name", "ProviderName", "ProviderKey" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_Target~",
                table: "AbpLinkUsers",
                columns: new[] { "SourceUserId", "SourceTenantId", "TargetUserId", "TargetTenantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnitRoles_RoleId_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                columns: new[] { "RoleId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_Code",
                table: "AbpOrganizationUnits",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissionGrants_TenantId_Name_ProviderName_ProviderKey",
                table: "AbpPermissionGrants",
                columns: new[] { "TenantId", "Name", "ProviderName", "ProviderKey" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissionGroups_Name",
                table: "AbpPermissionGroups",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissions_GroupName",
                table: "AbpPermissions",
                column: "GroupName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissions_Name",
                table: "AbpPermissions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoleClaims_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_NormalizedName",
                table: "AbpRoles",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_Action",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "Action" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_ApplicationName",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "ApplicationName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_Identity",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "Identity" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_UserId",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSessions_Device",
                table: "AbpSessions",
                column: "Device");

            migrationBuilder.CreateIndex(
                name: "IX_AbpSessions_SessionId",
                table: "AbpSessions",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpSessions_TenantId_UserId",
                table: "AbpSessions",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettingDefinitions_Name",
                table: "AbpSettingDefinitions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettings_Name_ProviderName_ProviderKey",
                table: "AbpSettings",
                columns: new[] { "Name", "ProviderName", "ProviderKey" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_Name",
                table: "AbpTenants",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_NormalizedName",
                table: "AbpTenants",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserClaims_UserId",
                table: "AbpUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserOrganizationUnits_UserId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                columns: new[] { "UserId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserRoles_RoleId_UserId",
                table: "AbpUserRoles",
                columns: new[] { "RoleId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_Email",
                table: "AbpUsers",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_NormalizedEmail",
                table: "AbpUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_NormalizedUserName",
                table: "AbpUsers",
                column: "NormalizedUserName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_UserName",
                table: "AbpUsers",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictApplications_ClientId",
                table: "OpenIddictApplications",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictAuthorizations_ApplicationId_Status_Subject_Type",
                table: "OpenIddictAuthorizations",
                columns: new[] { "ApplicationId", "Status", "Subject", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictScopes_Name",
                table: "OpenIddictScopes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictTokens_ApplicationId_Status_Subject_Type",
                table: "OpenIddictTokens",
                columns: new[] { "ApplicationId", "Status", "Subject", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictTokens_AuthorizationId",
                table: "OpenIddictTokens",
                column: "AuthorizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictTokens_ReferenceId",
                table: "OpenIddictTokens",
                column: "ReferenceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpAuditLogActions");

            migrationBuilder.DropTable(
                name: "AbpBackgroundJobs");

            migrationBuilder.DropTable(
                name: "AbpClaimTypes");

            migrationBuilder.DropTable(
                name: "AbpEntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "AbpFeatureGroups");

            migrationBuilder.DropTable(
                name: "AbpFeatures");

            migrationBuilder.DropTable(
                name: "AbpFeatureValues");

            migrationBuilder.DropTable(
                name: "AbpLinkUsers");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnitRoles");

            migrationBuilder.DropTable(
                name: "AbpPermissionGrants");

            migrationBuilder.DropTable(
                name: "AbpPermissionGroups");

            migrationBuilder.DropTable(
                name: "AbpPermissions");

            migrationBuilder.DropTable(
                name: "AbpRoleClaims");

            migrationBuilder.DropTable(
                name: "AbpSecurityLogs");

            migrationBuilder.DropTable(
                name: "AbpSessions");

            migrationBuilder.DropTable(
                name: "AbpSettingDefinitions");

            migrationBuilder.DropTable(
                name: "AbpSettings");

            migrationBuilder.DropTable(
                name: "AbpTenantConnectionStrings");

            migrationBuilder.DropTable(
                name: "AbpUserClaims");

            migrationBuilder.DropTable(
                name: "AbpUserDelegations");

            migrationBuilder.DropTable(
                name: "AbpUserLogins");

            migrationBuilder.DropTable(
                name: "AbpUserOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpUserRoles");

            migrationBuilder.DropTable(
                name: "AbpUserTokens");

            migrationBuilder.DropTable(
                name: "OpenIddictScopes");

            migrationBuilder.DropTable(
                name: "OpenIddictTokens");

            migrationBuilder.DropTable(
                name: "AbpEntityChanges");

            migrationBuilder.DropTable(
                name: "AbpTenants");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpRoles");

            migrationBuilder.DropTable(
                name: "AbpUsers");

            migrationBuilder.DropTable(
                name: "OpenIddictAuthorizations");

            migrationBuilder.DropTable(
                name: "AbpAuditLogs");

            migrationBuilder.DropTable(
                name: "OpenIddictApplications");
        }
    }
}
````

## File: src/CoreFW.EntityFrameworkCore/Migrations/20250321103701_Initial.Designer.cs
````csharp
// <auto-generated />
using System;
using CoreFW.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace CoreFW.Migrations
{
    [DbContext(typeof(CoreFWDbContext))]
    [Migration("20250321103701_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ApplicationName")
                        .HasMaxLength(96)
                        .HasColumnType("varchar(96)")
                        .HasColumnName("ApplicationName");

                    b.Property<string>("BrowserInfo")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("BrowserInfo");

                    b.Property<string>("ClientId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("ClientId");

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("ClientIpAddress");

                    b.Property<string>("ClientName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("ClientName");

                    b.Property<string>("Comments")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Comments");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("CorrelationId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("CorrelationId");

                    b.Property<string>("Exceptions")
                        .HasColumnType("longtext");

                    b.Property<int>("ExecutionDuration")
                        .HasColumnType("int")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("HttpMethod")
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("HttpMethod");

                    b.Property<int?>("HttpStatusCode")
                        .HasColumnType("int")
                        .HasColumnName("HttpStatusCode");

                    b.Property<Guid?>("ImpersonatorTenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("ImpersonatorTenantId");

                    b.Property<string>("ImpersonatorTenantName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("ImpersonatorTenantName");

                    b.Property<Guid?>("ImpersonatorUserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("ImpersonatorUserId");

                    b.Property<string>("ImpersonatorUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("ImpersonatorUserName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<string>("TenantName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("TenantName");

                    b.Property<string>("Url")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Url");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ExecutionTime");

                    b.HasIndex("TenantId", "UserId", "ExecutionTime");

                    b.ToTable("AbpAuditLogs", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLogAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AuditLogId")
                        .HasColumnType("char(36)")
                        .HasColumnName("AuditLogId");

                    b.Property<int>("ExecutionDuration")
                        .HasColumnType("int")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ExecutionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("MethodName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("MethodName");

                    b.Property<string>("Parameters")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("Parameters");

                    b.Property<string>("ServiceName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("ServiceName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("TenantId", "ServiceName", "MethodName", "ExecutionTime");

                    b.ToTable("AbpAuditLogActions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AuditLogId")
                        .HasColumnType("char(36)")
                        .HasColumnName("AuditLogId");

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ChangeTime");

                    b.Property<byte>("ChangeType")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("ChangeType");

                    b.Property<string>("EntityId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("EntityId");

                    b.Property<Guid?>("EntityTenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("EntityTypeFullName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("EntityTypeFullName");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("TenantId", "EntityTypeFullName", "EntityId");

                    b.ToTable("AbpEntityChanges", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityPropertyChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EntityChangeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("NewValue")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("NewValue");

                    b.Property<string>("OriginalValue")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("OriginalValue");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("PropertyName");

                    b.Property<string>("PropertyTypeFullName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("PropertyTypeFullName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("EntityChangeId");

                    b.ToTable("AbpEntityPropertyChanges", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.BackgroundJobs.BackgroundJobRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsAbandoned")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("JobArgs")
                        .IsRequired()
                        .HasMaxLength(1048576)
                        .HasColumnType("longtext");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("LastTryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NextTryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<byte>("Priority")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned")
                        .HasDefaultValue((byte)15);

                    b.Property<short>("TryCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.HasKey("Id");

                    b.HasIndex("IsAbandoned", "NextTryTime");

                    b.ToTable("AbpBackgroundJobs", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.FeatureManagement.FeatureDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AllowedProviders")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("DefaultValue")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("IsAvailableToHost")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsVisibleToClients")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ParentName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ValueType")
                        .HasMaxLength(2048)
                        .HasColumnType("varchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("GroupName");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpFeatures", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.FeatureManagement.FeatureGroupDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpFeatureGroups", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.FeatureManagement.FeatureValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpFeatureValues", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityClaimType", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Regex")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("RegexDescription")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("Required")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ValueType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AbpClaimTypes", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityLinkUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SourceTenantId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SourceUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TargetTenantId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TargetUserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("SourceUserId", "SourceTenantId", "TargetUserId", "TargetTenantId")
                        .IsUnique();

                    b.ToTable("AbpLinkUsers", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRole", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsDefault");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsPublic");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsStatic");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName");

                    b.ToTable("AbpRoles", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRoleClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AbpRoleClaims", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentitySecurityLog", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Action")
                        .HasMaxLength(96)
                        .HasColumnType("varchar(96)");

                    b.Property<string>("ApplicationName")
                        .HasMaxLength(96)
                        .HasColumnType("varchar(96)");

                    b.Property<string>("BrowserInfo")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("ClientId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("CorrelationId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Identity")
                        .HasMaxLength(96)
                        .HasColumnType("varchar(96)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<string>("TenantName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Action");

                    b.HasIndex("TenantId", "ApplicationName");

                    b.HasIndex("TenantId", "Identity");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpSecurityLogs", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentitySession", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ClientId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Device")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("DeviceInfo")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("IpAddresses")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("LastAccessed")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("SignedIn")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Device");

                    b.HasIndex("SessionId");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpSessions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Email");

                    b.Property<bool>("EmailConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("EmailConfirmed");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<bool>("IsExternal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsExternal");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<DateTimeOffset?>("LastPasswordChangeTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("LockoutEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Name");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("NormalizedEmail");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("NormalizedUserName");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("SecurityStamp");

                    b.Property<bool>("ShouldChangePasswordOnNextLogin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Surname")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Surname");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<bool>("TwoFactorEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("NormalizedEmail");

                    b.HasIndex("NormalizedUserName");

                    b.HasIndex("UserName");

                    b.ToTable("AbpUsers", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AbpUserClaims", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserDelegation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("SourceUserId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("TargetUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("AbpUserDelegations", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserLogin", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(196)
                        .HasColumnType("varchar(196)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("UserId", "LoginProvider");

                    b.HasIndex("LoginProvider", "ProviderKey");

                    b.ToTable("AbpUserLogins", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserOrganizationUnit", b =>
                {
                    b.Property<Guid>("OrganizationUnitId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("OrganizationUnitId", "UserId");

                    b.HasIndex("UserId", "OrganizationUnitId");

                    b.ToTable("AbpUserOrganizationUnits", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId", "UserId");

                    b.ToTable("AbpUserRoles", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AbpUserTokens", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(95)
                        .HasColumnType("varchar(95)")
                        .HasColumnName("Code");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("DisplayName");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("ParentId");

                    b.ToTable("AbpOrganizationUnits", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnitRole", b =>
                {
                    b.Property<Guid>("OrganizationUnitId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("OrganizationUnitId", "RoleId");

                    b.HasIndex("RoleId", "OrganizationUnitId");

                    b.ToTable("AbpOrganizationUnitRoles", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ApplicationType")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ClientId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("longtext");

                    b.Property<string>("ClientType")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ClientUri")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("ConsentType")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("DisplayNames")
                        .HasColumnType("longtext");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<string>("JsonWebKeySet")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("LogoUri")
                        .HasColumnType("longtext");

                    b.Property<string>("Permissions")
                        .HasColumnType("longtext");

                    b.Property<string>("PostLogoutRedirectUris")
                        .HasColumnType("longtext");

                    b.Property<string>("Properties")
                        .HasColumnType("longtext");

                    b.Property<string>("RedirectUris")
                        .HasColumnType("longtext");

                    b.Property<string>("Requirements")
                        .HasColumnType("longtext");

                    b.Property<string>("Settings")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("OpenIddictApplications", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ApplicationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Properties")
                        .HasColumnType("longtext");

                    b.Property<string>("Scopes")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Subject")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictAuthorizations", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Scopes.OpenIddictScope", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Descriptions")
                        .HasColumnType("longtext");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("DisplayNames")
                        .HasColumnType("longtext");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Properties")
                        .HasColumnType("longtext");

                    b.Property<string>("Resources")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("OpenIddictScopes", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Tokens.OpenIddictToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ApplicationId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AuthorizationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Payload")
                        .HasColumnType("longtext");

                    b.Property<string>("Properties")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("RedemptionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ReferenceId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Subject")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("ReferenceId");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictTokens", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.PermissionManagement.PermissionDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte>("MultiTenancySide")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ParentName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Providers")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("StateCheckers")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("GroupName");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpPermissions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.PermissionManagement.PermissionGrant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpPermissionGrants", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.PermissionManagement.PermissionGroupDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpPermissionGroups", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.SettingManagement.Setting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("varchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpSettings", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.SettingManagement.SettingDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DefaultValue")
                        .HasMaxLength(2048)
                        .HasColumnType("varchar(2048)");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsEncrypted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsInherited")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsVisibleToClients")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Providers")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpSettingDefinitions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.TenantManagement.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("NormalizedName");

                    b.ToTable("AbpTenants", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.TenantManagement.TenantConnectionString", b =>
                {
                    b.Property<Guid>("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("TenantId", "Name");

                    b.ToTable("AbpTenantConnectionStrings", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLogAction", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.AuditLog", null)
                        .WithMany("Actions")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.AuditLog", null)
                        .WithMany("EntityChanges")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityPropertyChange", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.EntityChange", null)
                        .WithMany("PropertyChanges")
                        .HasForeignKey("EntityChangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRoleClaim", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityRole", null)
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserClaim", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserLogin", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserOrganizationUnit", b =>
                {
                    b.HasOne("Volo.Abp.Identity.OrganizationUnit", null)
                        .WithMany()
                        .HasForeignKey("OrganizationUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("OrganizationUnits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserRole", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserToken", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnit", b =>
                {
                    b.HasOne("Volo.Abp.Identity.OrganizationUnit", null)
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnitRole", b =>
                {
                    b.HasOne("Volo.Abp.Identity.OrganizationUnit", null)
                        .WithMany("Roles")
                        .HasForeignKey("OrganizationUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Volo.Abp.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", b =>
                {
                    b.HasOne("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", null)
                        .WithMany()
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Tokens.OpenIddictToken", b =>
                {
                    b.HasOne("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", null)
                        .WithMany()
                        .HasForeignKey("ApplicationId");

                    b.HasOne("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", null)
                        .WithMany()
                        .HasForeignKey("AuthorizationId");
                });

            modelBuilder.Entity("Volo.Abp.TenantManagement.TenantConnectionString", b =>
                {
                    b.HasOne("Volo.Abp.TenantManagement.Tenant", null)
                        .WithMany("ConnectionStrings")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLog", b =>
                {
                    b.Navigation("Actions");

                    b.Navigation("EntityChanges");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.Navigation("PropertyChanges");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRole", b =>
                {
                    b.Navigation("Claims");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUser", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("OrganizationUnits");

                    b.Navigation("Roles");

                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnit", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Volo.Abp.TenantManagement.Tenant", b =>
                {
                    b.Navigation("ConnectionStrings");
                });
#pragma warning restore 612, 618
        }
    }
}
````

## File: src/CoreFW.EntityFrameworkCore/Migrations/CoreFWDbContextModelSnapshot.cs
````csharp
// <auto-generated />
using System;
using CoreFW.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace CoreFW.Migrations
{
    [DbContext(typeof(CoreFWDbContext))]
    partial class CoreFWDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ApplicationName")
                        .HasMaxLength(96)
                        .HasColumnType("varchar(96)")
                        .HasColumnName("ApplicationName");

                    b.Property<string>("BrowserInfo")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("BrowserInfo");

                    b.Property<string>("ClientId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("ClientId");

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("ClientIpAddress");

                    b.Property<string>("ClientName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("ClientName");

                    b.Property<string>("Comments")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Comments");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("CorrelationId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("CorrelationId");

                    b.Property<string>("Exceptions")
                        .HasColumnType("longtext");

                    b.Property<int>("ExecutionDuration")
                        .HasColumnType("int")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("HttpMethod")
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("HttpMethod");

                    b.Property<int?>("HttpStatusCode")
                        .HasColumnType("int")
                        .HasColumnName("HttpStatusCode");

                    b.Property<Guid?>("ImpersonatorTenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("ImpersonatorTenantId");

                    b.Property<string>("ImpersonatorTenantName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("ImpersonatorTenantName");

                    b.Property<Guid?>("ImpersonatorUserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("ImpersonatorUserId");

                    b.Property<string>("ImpersonatorUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("ImpersonatorUserName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<string>("TenantName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("TenantName");

                    b.Property<string>("Url")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Url");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ExecutionTime");

                    b.HasIndex("TenantId", "UserId", "ExecutionTime");

                    b.ToTable("AbpAuditLogs", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLogAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AuditLogId")
                        .HasColumnType("char(36)")
                        .HasColumnName("AuditLogId");

                    b.Property<int>("ExecutionDuration")
                        .HasColumnType("int")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ExecutionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("MethodName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("MethodName");

                    b.Property<string>("Parameters")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("Parameters");

                    b.Property<string>("ServiceName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("ServiceName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("TenantId", "ServiceName", "MethodName", "ExecutionTime");

                    b.ToTable("AbpAuditLogActions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AuditLogId")
                        .HasColumnType("char(36)")
                        .HasColumnName("AuditLogId");

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ChangeTime");

                    b.Property<byte>("ChangeType")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("ChangeType");

                    b.Property<string>("EntityId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("EntityId");

                    b.Property<Guid?>("EntityTenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("EntityTypeFullName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("EntityTypeFullName");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("TenantId", "EntityTypeFullName", "EntityId");

                    b.ToTable("AbpEntityChanges", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityPropertyChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EntityChangeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("NewValue")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("NewValue");

                    b.Property<string>("OriginalValue")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("OriginalValue");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("PropertyName");

                    b.Property<string>("PropertyTypeFullName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("PropertyTypeFullName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("EntityChangeId");

                    b.ToTable("AbpEntityPropertyChanges", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.BackgroundJobs.BackgroundJobRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsAbandoned")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("JobArgs")
                        .IsRequired()
                        .HasMaxLength(1048576)
                        .HasColumnType("longtext");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("LastTryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NextTryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<byte>("Priority")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned")
                        .HasDefaultValue((byte)15);

                    b.Property<short>("TryCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.HasKey("Id");

                    b.HasIndex("IsAbandoned", "NextTryTime");

                    b.ToTable("AbpBackgroundJobs", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.FeatureManagement.FeatureDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AllowedProviders")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("DefaultValue")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("IsAvailableToHost")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsVisibleToClients")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ParentName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ValueType")
                        .HasMaxLength(2048)
                        .HasColumnType("varchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("GroupName");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpFeatures", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.FeatureManagement.FeatureGroupDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpFeatureGroups", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.FeatureManagement.FeatureValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpFeatureValues", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityClaimType", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Regex")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("RegexDescription")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("Required")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ValueType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AbpClaimTypes", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityLinkUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SourceTenantId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SourceUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TargetTenantId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TargetUserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("SourceUserId", "SourceTenantId", "TargetUserId", "TargetTenantId")
                        .IsUnique();

                    b.ToTable("AbpLinkUsers", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRole", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsDefault");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsPublic");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsStatic");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName");

                    b.ToTable("AbpRoles", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRoleClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AbpRoleClaims", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentitySecurityLog", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Action")
                        .HasMaxLength(96)
                        .HasColumnType("varchar(96)");

                    b.Property<string>("ApplicationName")
                        .HasMaxLength(96)
                        .HasColumnType("varchar(96)");

                    b.Property<string>("BrowserInfo")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("ClientId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("CorrelationId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Identity")
                        .HasMaxLength(96)
                        .HasColumnType("varchar(96)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<string>("TenantName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Action");

                    b.HasIndex("TenantId", "ApplicationName");

                    b.HasIndex("TenantId", "Identity");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpSecurityLogs", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentitySession", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ClientId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Device")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("DeviceInfo")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("IpAddresses")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("LastAccessed")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("SignedIn")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Device");

                    b.HasIndex("SessionId");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpSessions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Email");

                    b.Property<bool>("EmailConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("EmailConfirmed");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<bool>("IsExternal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsExternal");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<DateTimeOffset?>("LastPasswordChangeTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("LockoutEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Name");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("NormalizedEmail");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("NormalizedUserName");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("SecurityStamp");

                    b.Property<bool>("ShouldChangePasswordOnNextLogin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Surname")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Surname");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<bool>("TwoFactorEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("NormalizedEmail");

                    b.HasIndex("NormalizedUserName");

                    b.HasIndex("UserName");

                    b.ToTable("AbpUsers", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AbpUserClaims", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserDelegation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("SourceUserId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("TargetUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("AbpUserDelegations", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserLogin", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(196)
                        .HasColumnType("varchar(196)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("UserId", "LoginProvider");

                    b.HasIndex("LoginProvider", "ProviderKey");

                    b.ToTable("AbpUserLogins", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserOrganizationUnit", b =>
                {
                    b.Property<Guid>("OrganizationUnitId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("OrganizationUnitId", "UserId");

                    b.HasIndex("UserId", "OrganizationUnitId");

                    b.ToTable("AbpUserOrganizationUnits", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId", "UserId");

                    b.ToTable("AbpUserRoles", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AbpUserTokens", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(95)
                        .HasColumnType("varchar(95)")
                        .HasColumnName("Code");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("DisplayName");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("ParentId");

                    b.ToTable("AbpOrganizationUnits", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnitRole", b =>
                {
                    b.Property<Guid>("OrganizationUnitId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("OrganizationUnitId", "RoleId");

                    b.HasIndex("RoleId", "OrganizationUnitId");

                    b.ToTable("AbpOrganizationUnitRoles", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ApplicationType")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ClientId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("longtext");

                    b.Property<string>("ClientType")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ClientUri")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("ConsentType")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("DisplayNames")
                        .HasColumnType("longtext");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<string>("JsonWebKeySet")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("LogoUri")
                        .HasColumnType("longtext");

                    b.Property<string>("Permissions")
                        .HasColumnType("longtext");

                    b.Property<string>("PostLogoutRedirectUris")
                        .HasColumnType("longtext");

                    b.Property<string>("Properties")
                        .HasColumnType("longtext");

                    b.Property<string>("RedirectUris")
                        .HasColumnType("longtext");

                    b.Property<string>("Requirements")
                        .HasColumnType("longtext");

                    b.Property<string>("Settings")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("OpenIddictApplications", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ApplicationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Properties")
                        .HasColumnType("longtext");

                    b.Property<string>("Scopes")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Subject")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictAuthorizations", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Scopes.OpenIddictScope", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Descriptions")
                        .HasColumnType("longtext");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("DisplayNames")
                        .HasColumnType("longtext");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Properties")
                        .HasColumnType("longtext");

                    b.Property<string>("Resources")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("OpenIddictScopes", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Tokens.OpenIddictToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ApplicationId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AuthorizationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Payload")
                        .HasColumnType("longtext");

                    b.Property<string>("Properties")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("RedemptionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ReferenceId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Subject")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("ReferenceId");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictTokens", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.PermissionManagement.PermissionDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte>("MultiTenancySide")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ParentName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Providers")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("StateCheckers")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("GroupName");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpPermissions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.PermissionManagement.PermissionGrant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpPermissionGrants", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.PermissionManagement.PermissionGroupDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpPermissionGroups", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.SettingManagement.Setting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("varchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpSettings", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.SettingManagement.SettingDefinitionRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DefaultValue")
                        .HasMaxLength(2048)
                        .HasColumnType("varchar(2048)");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsEncrypted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsInherited")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsVisibleToClients")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Providers")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AbpSettingDefinitions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.TenantManagement.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletionTime");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("NormalizedName");

                    b.ToTable("AbpTenants", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.TenantManagement.TenantConnectionString", b =>
                {
                    b.Property<Guid>("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("TenantId", "Name");

                    b.ToTable("AbpTenantConnectionStrings", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLogAction", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.AuditLog", null)
                        .WithMany("Actions")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.AuditLog", null)
                        .WithMany("EntityChanges")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityPropertyChange", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.EntityChange", null)
                        .WithMany("PropertyChanges")
                        .HasForeignKey("EntityChangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRoleClaim", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityRole", null)
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserClaim", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserLogin", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserOrganizationUnit", b =>
                {
                    b.HasOne("Volo.Abp.Identity.OrganizationUnit", null)
                        .WithMany()
                        .HasForeignKey("OrganizationUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("OrganizationUnits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserRole", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserToken", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser", null)
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnit", b =>
                {
                    b.HasOne("Volo.Abp.Identity.OrganizationUnit", null)
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnitRole", b =>
                {
                    b.HasOne("Volo.Abp.Identity.OrganizationUnit", null)
                        .WithMany("Roles")
                        .HasForeignKey("OrganizationUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Volo.Abp.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", b =>
                {
                    b.HasOne("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", null)
                        .WithMany()
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Tokens.OpenIddictToken", b =>
                {
                    b.HasOne("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", null)
                        .WithMany()
                        .HasForeignKey("ApplicationId");

                    b.HasOne("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", null)
                        .WithMany()
                        .HasForeignKey("AuthorizationId");
                });

            modelBuilder.Entity("Volo.Abp.TenantManagement.TenantConnectionString", b =>
                {
                    b.HasOne("Volo.Abp.TenantManagement.Tenant", null)
                        .WithMany("ConnectionStrings")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLog", b =>
                {
                    b.Navigation("Actions");

                    b.Navigation("EntityChanges");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.Navigation("PropertyChanges");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRole", b =>
                {
                    b.Navigation("Claims");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUser", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("OrganizationUnits");

                    b.Navigation("Roles");

                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("Volo.Abp.Identity.OrganizationUnit", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Volo.Abp.TenantManagement.Tenant", b =>
                {
                    b.Navigation("ConnectionStrings");
                });
#pragma warning restore 612, 618
        }
    }
}
````

## File: src/CoreFW.EntityFrameworkCore/Properties/AssemblyInfo.cs
````csharp
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleToAttribute("CoreFW.EntityFrameworkCore.Tests")]
````

## File: src/CoreFW.EntityFrameworkCore/CoreFW.EntityFrameworkCore.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\CoreFW.Domain\CoreFW.Domain.csproj" />
    <PackageReference Include="Volo.Abp.EntityFrameworkCore.MySQL" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.PermissionManagement.EntityFrameworkCore" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.SettingManagement.EntityFrameworkCore" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Identity.EntityFrameworkCore" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.BackgroundJobs.EntityFrameworkCore" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.AuditLogging.EntityFrameworkCore" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.TenantManagement.EntityFrameworkCore" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.FeatureManagement.EntityFrameworkCore" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.OpenIddict.EntityFrameworkCore" Version="8.3.4" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.4">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
    </PackageReference>
  </ItemGroup>

</Project>
````

## File: src/CoreFW.HttpApi/Controllers/CoreFWController.cs
````csharp
using CoreFW.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CoreFW.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CoreFWController : AbpControllerBase
{
    protected CoreFWController()
    {
        LocalizationResource = typeof(CoreFWResource);
    }
}
````

## File: src/CoreFW.HttpApi/Models/Test/TestModel.cs
````csharp
using System;

namespace CoreFW.Models.Test;

public class TestModel
{
    public string? Name { get; set; }

    public DateTime BirthDate { get; set; }
}
````

## File: src/CoreFW.HttpApi/CoreFW.HttpApi.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\CoreFW.Application.Contracts\CoreFW.Application.Contracts.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.Account.HttpApi" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Identity.HttpApi" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.PermissionManagement.HttpApi" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.TenantManagement.HttpApi" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.FeatureManagement.HttpApi" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.SettingManagement.HttpApi" Version="8.3.4" />
  </ItemGroup>

</Project>
````

## File: src/CoreFW.HttpApi/CoreFWHttpApiModule.cs
````csharp
using Localization.Resources.AbpUi;
using CoreFW.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
public class CoreFWHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CoreFWResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
````

## File: src/CoreFW.HttpApi.Client/CoreFW.HttpApi.Client.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\CoreFW.Application.Contracts\CoreFW.Application.Contracts.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.Account.HttpApi.Client" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Identity.HttpApi.Client" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.PermissionManagement.HttpApi.Client" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.TenantManagement.HttpApi.Client" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.FeatureManagement.HttpApi.Client" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.SettingManagement.HttpApi.Client" Version="8.3.4" />
  </ItemGroup>

  <ItemGroup>
    <EmbeddedResource Include="**\*generate-proxy.json" />
    <Content Remove="**\*generate-proxy.json" />
  </ItemGroup>

</Project>
````

## File: src/CoreFW.HttpApi.Client/CoreFWHttpApiClientModule.cs
````csharp
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWApplicationContractsModule),
    typeof(AbpAccountHttpApiClientModule),
    typeof(AbpIdentityHttpApiClientModule),
    typeof(AbpPermissionManagementHttpApiClientModule),
    typeof(AbpTenantManagementHttpApiClientModule),
    typeof(AbpFeatureManagementHttpApiClientModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
public class CoreFWHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CoreFWApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CoreFWHttpApiClientModule>();
        });
    }
}
````

## File: test/CoreFW.Application.Tests/Samples/SampleAppServiceTests.cs
````csharp
using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Xunit;

namespace CoreFW.Samples;

/* This is just an example test class.
 * Normally, you don't test code of the modules you are using
 * (like IIdentityUserAppService here).
 * Only test your own application services.
 */
public abstract class SampleAppServiceTests<TStartupModule> : CoreFWApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IIdentityUserAppService _userAppService;

    protected SampleAppServiceTests()
    {
        _userAppService = GetRequiredService<IIdentityUserAppService>();
    }

    [Fact]
    public async Task Initial_Data_Should_Contain_Admin_User()
    {
        //Act
        var result = await _userAppService.GetListAsync(new GetIdentityUsersInput());

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(u => u.UserName == "admin");
    }
}
````

## File: test/CoreFW.Application.Tests/CoreFW.Application.Tests.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\src\CoreFW.Application\CoreFW.Application.csproj" />
    <ProjectReference Include="..\CoreFW.Domain.Tests\CoreFW.Domain.Tests.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.8.0" />
  </ItemGroup>

</Project>
````

## File: test/CoreFW.Application.Tests/CoreFWApplicationTestBase.cs
````csharp
using Volo.Abp.Modularity;

namespace CoreFW;

public abstract class CoreFWApplicationTestBase<TStartupModule> : CoreFWTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
````

## File: test/CoreFW.Application.Tests/CoreFWApplicationTestModule.cs
````csharp
using Volo.Abp.Modularity;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWApplicationModule),
    typeof(CoreFWDomainTestModule)
)]
public class CoreFWApplicationTestModule : AbpModule
{

}
````

## File: test/CoreFW.Domain.Tests/Samples/SampleDomainTests.cs
````csharp
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Xunit;

namespace CoreFW.Samples;

/* This is just an example test class.
 * Normally, you don't test code of the modules you are using
 * (like IdentityUserManager here).
 * Only test your own domain services.
 */
public abstract class SampleDomainTests<TStartupModule> : CoreFWDomainTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IIdentityUserRepository _identityUserRepository;
    private readonly IdentityUserManager _identityUserManager;

    protected SampleDomainTests()
    {
        _identityUserRepository = GetRequiredService<IIdentityUserRepository>();
        _identityUserManager = GetRequiredService<IdentityUserManager>();
    }

    [Fact]
    public async Task Should_Set_Email_Of_A_User()
    {
        IdentityUser adminUser;

        /* Need to manually start Unit Of Work because
         * FirstOrDefaultAsync should be executed while db connection / context is available.
         */
        await WithUnitOfWorkAsync(async () =>
        {
            adminUser = await _identityUserRepository
                .FindByNormalizedUserNameAsync("ADMIN");

            await _identityUserManager.SetEmailAsync(adminUser, "newemail@abp.io");
            await _identityUserRepository.UpdateAsync(adminUser);
        });

        adminUser = await _identityUserRepository.FindByNormalizedUserNameAsync("ADMIN");
        adminUser.Email.ShouldBe("newemail@abp.io");
    }
}
````

## File: test/CoreFW.Domain.Tests/CoreFW.Domain.Tests.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.8.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\src\CoreFW.Domain\CoreFW.Domain.csproj" />
    <ProjectReference Include="..\CoreFW.TestBase\CoreFW.TestBase.csproj" />
  </ItemGroup>

</Project>
````

## File: test/CoreFW.Domain.Tests/CoreFWDomainTestBase.cs
````csharp
using Volo.Abp.Modularity;

namespace CoreFW;

/* Inherit from this class for your domain layer tests. */
public abstract class CoreFWDomainTestBase<TStartupModule> : CoreFWTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
````

## File: test/CoreFW.Domain.Tests/CoreFWDomainTestModule.cs
````csharp
using Volo.Abp.Modularity;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWDomainModule),
    typeof(CoreFWTestBaseModule)
)]
public class CoreFWDomainTestModule : AbpModule
{

}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/EntityFrameworkCore/Applications/EfCoreSampleAppServiceTests.cs
````csharp
using CoreFW.Samples;
using Xunit;

namespace CoreFW.EntityFrameworkCore.Applications;

[Collection(CoreFWTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CoreFWEntityFrameworkCoreTestModule>
{

}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/EntityFrameworkCore/Domains/EfCoreSampleDomainTests.cs
````csharp
using CoreFW.Samples;
using Xunit;

namespace CoreFW.EntityFrameworkCore.Domains;

[Collection(CoreFWTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CoreFWEntityFrameworkCoreTestModule>
{

}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/EntityFrameworkCore/Samples/SampleRepositoryTests.cs
````csharp
using Microsoft.EntityFrameworkCore;
using Shouldly;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Xunit;

namespace CoreFW.EntityFrameworkCore.Samples;

/* This is just an example test class.
 * Normally, you don't test ABP framework code
 * (like default AppUser repository IRepository<AppUser, Guid> here).
 * Only test your custom repository methods.
 */
[Collection(CoreFWTestConsts.CollectionDefinitionName)]
public class SampleRepositoryTests : CoreFWEntityFrameworkCoreTestBase
{
    private readonly IRepository<IdentityUser, Guid> _appUserRepository;

    public SampleRepositoryTests()
    {
        _appUserRepository = GetRequiredService<IRepository<IdentityUser, Guid>>();
    }

    [Fact]
    public async Task Should_Query_AppUser()
    {
        /* Need to manually start Unit Of Work because
         * FirstOrDefaultAsync should be executed while db connection / context is available.
         */
        await WithUnitOfWorkAsync(async () =>
        {
                //Act
                var adminUser = await (await _appUserRepository.GetQueryableAsync())
                .Where(u => u.UserName == "admin")
                .FirstOrDefaultAsync();

                //Assert
                adminUser.ShouldNotBeNull();
        });
    }
}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreFWEntityFrameworkCoreCollection.cs
````csharp
using Xunit;

namespace CoreFW.EntityFrameworkCore;

[CollectionDefinition(CoreFWTestConsts.CollectionDefinitionName)]
public class CoreFWEntityFrameworkCoreCollection : ICollectionFixture<CoreFWEntityFrameworkCoreFixture>
{

}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreFWEntityFrameworkCoreCollectionFixtureBase.cs
````csharp
using CoreFW.EntityFrameworkCore;
using Xunit;

namespace CoreFW.EntityFrameworkCore;

public class CoreFWEntityFrameworkCoreCollectionFixtureBase : ICollectionFixture<CoreFWEntityFrameworkCoreFixture>
{

}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreFWEntityFrameworkCoreFixture.cs
````csharp
using System;

namespace CoreFW.EntityFrameworkCore;

public class CoreFWEntityFrameworkCoreFixture : IDisposable
{
    public void Dispose()
    {

    }
}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreFWEntityFrameworkCoreTestBase.cs
````csharp
using Volo.Abp;

namespace CoreFW.EntityFrameworkCore;

public abstract class CoreFWEntityFrameworkCoreTestBase : CoreFWTestBase<CoreFWEntityFrameworkCoreTestModule>
{

}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreFWEntityFrameworkCoreTestModule.cs
````csharp
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.Uow;

namespace CoreFW.EntityFrameworkCore;

[DependsOn(
    typeof(CoreFWApplicationTestModule),
    typeof(CoreFWEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqliteModule)
    )]
public class CoreFWEntityFrameworkCoreTestModule : AbpModule
{
    private SqliteConnection? _sqliteConnection;

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<FeatureManagementOptions>(options =>
        {
            options.SaveStaticFeaturesToDatabase = false;
            options.IsDynamicFeatureStoreEnabled = false;
        });
        Configure<PermissionManagementOptions>(options =>
        {
            options.SaveStaticPermissionsToDatabase = false;
            options.IsDynamicPermissionStoreEnabled = false;
        });
        Configure<SettingManagementOptions>(options =>
        {
            options.SaveStaticSettingsToDatabase = false;
            options.IsDynamicSettingStoreEnabled = false;
        });
        context.Services.AddAlwaysDisableUnitOfWorkTransaction();

        ConfigureInMemorySqlite(context.Services);
    }

    private void ConfigureInMemorySqlite(IServiceCollection services)
    {
        _sqliteConnection = CreateDatabaseAndGetConnection();

        services.Configure<AbpDbContextOptions>(options =>
        {
            options.Configure(context =>
            {
                context.DbContextOptions.UseSqlite(_sqliteConnection);
            });
        });
    }

    public override void OnApplicationShutdown(ApplicationShutdownContext context)
    {
        _sqliteConnection?.Dispose();
    }

    private static SqliteConnection CreateDatabaseAndGetConnection()
    {
        var connection = new AbpUnitTestSqliteConnection("Data Source=:memory:");
        connection.Open();

        var options = new DbContextOptionsBuilder<CoreFWDbContext>()
            .UseSqlite(connection)
            .Options;

        using (var context = new CoreFWDbContext(options))
        {
            context.GetService<IRelationalDatabaseCreator>().CreateTables();
        }

        return connection;
    }
}
````

## File: test/CoreFW.EntityFrameworkCore.Tests/CoreFW.EntityFrameworkCore.Tests.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\src\CoreFW.EntityFrameworkCore\CoreFW.EntityFrameworkCore.csproj" />
    <ProjectReference Include="..\CoreFW.Application.Tests\CoreFW.Application.Tests.csproj" />
    <PackageReference Include="Volo.Abp.EntityFrameworkCore.Sqlite" Version="8.3.4" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.8.0" />
  </ItemGroup>

</Project>
````

## File: test/CoreFW.HttpApi.Client.ConsoleTestApp/appsettings.json
````json
{
  "RemoteServices": {
    "Default": {
      "BaseUrl": "https://localhost:44313"
    }
  },
  "IdentityClients": {
    "Default": {
      "GrantType": "password",
      "ClientId": "CoreFW_App",
      "UserName": "admin",
      "UserPassword": "1q2w3E*",
      "Authority": "https://localhost:44313",
      "Scope": "CoreFW"
    }
  }
}
````

## File: test/CoreFW.HttpApi.Client.ConsoleTestApp/appsettings.secrets.json
````json
{
}
````

## File: test/CoreFW.HttpApi.Client.ConsoleTestApp/ClientDemoService.cs
````csharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Account;
using Volo.Abp.DependencyInjection;

namespace CoreFW.HttpApi.Client.ConsoleTestApp;

public class ClientDemoService : ITransientDependency
{
    private readonly IProfileAppService _profileAppService;

    public ClientDemoService(IProfileAppService profileAppService)
    {
        _profileAppService = profileAppService;
    }

    public async Task RunAsync()
    {
        var output = await _profileAppService.GetAsync();
        Console.WriteLine($"UserName : {output.UserName}");
        Console.WriteLine($"Email    : {output.Email}");
        Console.WriteLine($"Name     : {output.Name}");
        Console.WriteLine($"Surname  : {output.Surname}");
    }
}
````

## File: test/CoreFW.HttpApi.Client.ConsoleTestApp/ConsoleTestAppHostedService.cs
````csharp
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace CoreFW.HttpApi.Client.ConsoleTestApp;

public class ConsoleTestAppHostedService : IHostedService
{
    private readonly IConfiguration _configuration;

    public ConsoleTestAppHostedService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using (var application = await AbpApplicationFactory.CreateAsync<CoreFWConsoleApiClientModule>(options =>
        {
           options.Services.ReplaceConfiguration(_configuration);
           options.UseAutofac();
        }))
        {
            await application.InitializeAsync();

            var demo = application.ServiceProvider.GetRequiredService<ClientDemoService>();
            await demo.RunAsync();

            await application.ShutdownAsync();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
````

## File: test/CoreFW.HttpApi.Client.ConsoleTestApp/CoreFW.HttpApi.Client.ConsoleTestApp.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <None Remove="appsettings.json" />
    <Content Include="appsettings.json">
      <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <None Remove="appsettings.secrets.json" />
    <Content Include="appsettings.secrets.json">
      <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.Http.Client.IdentityModel" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Autofac" Version="8.3.4" />
    <ProjectReference Include="..\..\src\CoreFW.HttpApi.Client\CoreFW.HttpApi.Client.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.Extensions.Hosting" Version="8.0.0" />
    <PackageReference Include="Microsoft.Extensions.Http.Polly" Version="8.0.0" />
  </ItemGroup>

</Project>
````

## File: test/CoreFW.HttpApi.Client.ConsoleTestApp/CoreFWConsoleApiClientModule.cs
````csharp
using System;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CoreFW.HttpApi.Client.ConsoleTestApp;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CoreFWHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class CoreFWConsoleApiClientModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<AbpHttpClientBuilderOptions>(options =>
        {
            options.ProxyClientBuildActions.Add((remoteServiceName, clientBuilder) =>
            {
                clientBuilder.AddTransientHttpErrorPolicy(
                    policyBuilder => policyBuilder.WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(Math.Pow(2, i)))
                );
            });
        });
    }
}
````

## File: test/CoreFW.HttpApi.Client.ConsoleTestApp/Program.cs
````csharp
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoreFW.HttpApi.Client.ConsoleTestApp;

class Program
{
    static async Task Main(string[] args)
    {
        await CreateHostBuilder(args).RunConsoleAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .AddAppSettingsSecretsJson()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<ConsoleTestAppHostedService>();
            });
}
````

## File: test/CoreFW.TestBase/Security/FakeCurrentPrincipalAccessor.cs
````csharp
using System.Collections.Generic;
using System.Security.Claims;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Security.Claims;

namespace CoreFW.Security;

[Dependency(ReplaceServices = true)]
public class FakeCurrentPrincipalAccessor : ThreadCurrentPrincipalAccessor
{
    protected override ClaimsPrincipal GetClaimsPrincipal()
    {
        return GetPrincipal();
    }

    private ClaimsPrincipal GetPrincipal()
    {
        return new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
        {
            new Claim(AbpClaimTypes.UserId, "2e701e62-0953-4dd3-910b-dc6cc93ccb0d"),
            new Claim(AbpClaimTypes.UserName, "admin"),
            new Claim(AbpClaimTypes.Email, "admin@abp.io")
        }));
    }
}
````

## File: test/CoreFW.TestBase/CoreFW.TestBase.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <Import Project="..\..\common.props" />

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <RootNamespace>CoreFW</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Volo.Abp.TestBase" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Autofac" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.Authorization" Version="8.3.4" />
    <PackageReference Include="Volo.Abp.BackgroundJobs.Abstractions" Version="8.3.4" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.8.0" />
    <PackageReference Include="NSubstitute" Version="5.1.0" />
    <PackageReference Include="NSubstitute.Analyzers.CSharp" Version="1.0.16">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Shouldly" Version="4.2.1" />
    <PackageReference Include="xunit" Version="2.6.1" />
    <PackageReference Include="xunit.extensibility.execution" Version="2.6.1" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.5.3" />
  </ItemGroup>

</Project>
````

## File: test/CoreFW.TestBase/CoreFWTestBase.cs
````csharp
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;
using Volo.Abp.Testing;

namespace CoreFW;

/* All test classes are derived from this class, directly or indirectly.
 */
public abstract class CoreFWTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule>
    where TStartupModule : IAbpModule
{
    protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
    {
        options.UseAutofac();
    }

    protected virtual Task WithUnitOfWorkAsync(Func<Task> func)
    {
        return WithUnitOfWorkAsync(new AbpUnitOfWorkOptions(), func);
    }

    protected virtual async Task WithUnitOfWorkAsync(AbpUnitOfWorkOptions options, Func<Task> action)
    {
        using (var scope = ServiceProvider.CreateScope())
        {
            var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

            using (var uow = uowManager.Begin(options))
            {
                await action();

                await uow.CompleteAsync();
            }
        }
    }

    protected virtual Task<TResult> WithUnitOfWorkAsync<TResult>(Func<Task<TResult>> func)
    {
        return WithUnitOfWorkAsync(new AbpUnitOfWorkOptions(), func);
    }

    protected virtual async Task<TResult> WithUnitOfWorkAsync<TResult>(AbpUnitOfWorkOptions options, Func<Task<TResult>> func)
    {
        using (var scope = ServiceProvider.CreateScope())
        {
            var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

            using (var uow = uowManager.Begin(options))
            {
                var result = await func();
                await uow.CompleteAsync();
                return result;
            }
        }
    }
}
````

## File: test/CoreFW.TestBase/CoreFWTestBaseModule.cs
````csharp
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Authorization;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Threading;

namespace CoreFW;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpTestBaseModule),
    typeof(AbpAuthorizationModule),
    typeof(AbpBackgroundJobsAbstractionsModule)
    )]
public class CoreFWTestBaseModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });

        context.Services.AddAlwaysAllowAuthorization();
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        SeedTestData(context);
    }

    private static void SeedTestData(ApplicationInitializationContext context)
    {
        AsyncHelper.RunSync(async () =>
        {
            using (var scope = context.ServiceProvider.CreateScope())
            {
                await scope.ServiceProvider
                    .GetRequiredService<IDataSeeder>()
                    .SeedAsync();
            }
        });
    }
}
````

## File: test/CoreFW.TestBase/CoreFWTestConsts.cs
````csharp
namespace CoreFW;

public static class CoreFWTestConsts
{
    public const string CollectionDefinitionName = "CoreFW collection";
}
````

## File: test/CoreFW.TestBase/CoreFWTestDataSeedContributor.cs
````csharp
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace CoreFW;

public class CoreFWTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    public Task SeedAsync(DataSeedContext context)
    {
        /* Seed additional test data... */

        return Task.CompletedTask;
    }
}
````

## File: .gitattributes
````
**/wwwroot/libs/** linguist-vendored
````

## File: .gitignore
````
## Ignore Visual Studio temporary files, build results, and
## files generated by popular Visual Studio add-ons.

# User-specific files
*.suo
*.user
*.userosscache
*.sln.docstates

# User-specific files (MonoDevelop/Xamarin Studio)
*.userprefs

# Build results
[Dd]ebug/
[Dd]ebugPublic/
[Rr]elease/
[Rr]eleases/
x64/
x86/
bld/
[Bb]in/
[Oo]bj/
[Ll]og/

# Visual Studio 2015 cache/options directory
.vs/
# Uncomment if you have tasks that create the project's static files in wwwroot
#wwwroot/

# MSTest test Results
[Tt]est[Rr]esult*/
[Bb]uild[Ll]og.*

# NUNIT
*.VisualState.xml
TestResult.xml

# Build Results of an ATL Project
[Dd]ebugPS/
[Rr]eleasePS/
dlldata.c

# DNX
project.lock.json
artifacts/

*_i.c
*_p.c
*_i.h
*.ilk
*.meta
*.obj
*.pch
*.pdb
*.pgc
*.pgd
*.rsp
*.sbr
*.tlb
*.tli
*.tlh
*.tmp
*.tmp_proj
*.log
*.vspscc
*.vssscc
.builds
*.pidb
*.svclog
*.scc

# Chutzpah Test files
_Chutzpah*

# Visual C++ cache files
ipch/
*.aps
*.ncb
*.opendb
*.opensdf
*.sdf
*.cachefile
*.VC.db
*.VC.VC.opendb

# Visual Studio profiler
*.psess
*.vsp
*.vspx
*.sap

# TFS 2012 Local Workspace
$tf/

# Guidance Automation Toolkit
*.gpState

# ReSharper is a .NET coding add-in
_ReSharper*/
*.[Rr]e[Ss]harper
*.DotSettings.user

# JustCode is a .NET coding add-in
.JustCode

# TeamCity is a build add-in
_TeamCity*

# DotCover is a Code Coverage Tool
*.dotCover

# NCrunch
_NCrunch_*
.*crunch*.local.xml
nCrunchTemp_*

# MightyMoose
*.mm.*
AutoTest.Net/

# Web workbench (sass)
.sass-cache/

# Installshield output folder
[Ee]xpress/

# DocProject is a documentation generator add-in
DocProject/buildhelp/
DocProject/Help/*.HxT
DocProject/Help/*.HxC
DocProject/Help/*.hhc
DocProject/Help/*.hhk
DocProject/Help/*.hhp
DocProject/Help/Html2
DocProject/Help/html

# Click-Once directory
publish/

# Publish Web Output
*.[Pp]ublish.xml
*.azurePubxml
# TODO: Comment the next line if you want to checkin your web deploy settings
# but database connection strings (with potential passwords) will be unencrypted
*.pubxml
*.publishproj

# Microsoft Azure Web App publish settings. Comment the next line if you want to
# checkin your Azure Web App publish settings, but sensitive information contained
# in these scripts will be unencrypted
PublishScripts/

# NuGet Packages
*.nupkg
# The packages folder can be ignored because of Package Restore
**/packages/*
# except build/, which is used as an MSBuild target.
!**/packages/build/
# Uncomment if necessary however generally it will be regenerated when needed
#!**/packages/repositories.config
# NuGet v3's project.json files produces more ignoreable files
*.nuget.props
*.nuget.targets

# Microsoft Azure Build Output
csx/
*.build.csdef

# Microsoft Azure Emulator
ecf/
rcf/

# Windows Store app package directories and files
AppPackages/
BundleArtifacts/
Package.StoreAssociation.xml
_pkginfo.txt

# Visual Studio cache files
# files ending in .cache can be ignored
*.[Cc]ache
# but keep track of directories ending in .cache
!*.[Cc]ache/

# Others
ClientBin/
~$*
*~
*.dbmdl
*.dbproj.schemaview
*.pfx
*.publishsettings
node_modules/
orleans.codegen.cs

# Since there are multiple workflows, uncomment next line to ignore bower_components
# (https://github.com/github/gitignore/pull/1529#issuecomment-104372622)
#bower_components/

# RIA/Silverlight projects
Generated_Code/

# Backup & report files from converting an old project file
# to a newer Visual Studio version. Backup files are not needed,
# because we have git ;-)
_UpgradeReport_Files/
Backup*/
UpgradeLog*.XML
UpgradeLog*.htm

# SQL Server files
*.mdf
*.ldf

# Business Intelligence projects
*.rdl.data
*.bim.layout
*.bim_*.settings

# Microsoft Fakes
FakesAssemblies/

# GhostDoc plugin setting file
*.GhostDoc.xml

# Node.js Tools for Visual Studio
.ntvs_analysis.dat

# Visual Studio 6 build log
*.plg

# Visual Studio 6 workspace options file
*.opt

# Visual Studio LightSwitch build output
**/*.HTMLClient/GeneratedArtifacts
**/*.DesktopClient/GeneratedArtifacts
**/*.DesktopClient/ModelManifest.xml
**/*.Server/GeneratedArtifacts
**/*.Server/ModelManifest.xml
_Pvt_Extensions

# Paket dependency manager
.paket/paket.exe
paket-files/

# FAKE - F# Make
.fake/

# JetBrains Rider
.idea/
*.sln.iml

# CoreFW
src/CoreFW.Web/Logs/*
src/CoreFW.Web.Host/Logs/*
src/CoreFW.AuthServer/Logs/*
src/CoreFW.HttpApi.Host/Logs/*
src/CoreFW.HttpApi.HostWithIds/Logs/*
src/CoreFW.DbMigrator/Logs/*
src/CoreFW.Blazor/Logs/*
src/CoreFW.Blazor.Tiered/Logs/*

# Use abp install-libs to restore.
**/wwwroot/libs/*
````

## File: .prettierrc
````
{
    "singleQuote": true,
    "useTabs": false,
    "tabWidth": 4
}
````

## File: common.props
````
<Project>
  <PropertyGroup>
    <LangVersion>latest</LangVersion>
    <Version>1.0.0</Version>
    <NoWarn>$(NoWarn);CS1591</NoWarn>
	<AbpProjectType>app</AbpProjectType>
  </PropertyGroup>

  <Target Name="NoWarnOnRazorViewImportedTypeConflicts" BeforeTargets="RazorCoreCompile">
    <PropertyGroup>
      <NoWarn>$(NoWarn);0436</NoWarn>
    </PropertyGroup>
  </Target>

  <ItemGroup>
    <Content Remove="$(UserProfile)\.nuget\packages\*\*\contentFiles\any\*\*.abppkg*" />
  </ItemGroup>

</Project>
````

## File: CoreFW.sln
````
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.13.35913.81 d17.13
MinimumVisualStudioVersion = 10.0.40219.1
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.Domain", "src\CoreFW.Domain\CoreFW.Domain.csproj", "{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.Application", "src\CoreFW.Application\CoreFW.Application.csproj", "{1A94A50E-06DC-43C1-80B5-B662820EC3EB}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.EntityFrameworkCore", "src\CoreFW.EntityFrameworkCore\CoreFW.EntityFrameworkCore.csproj", "{C956DD76-69C8-4A9C-83EA-D17DF83340FD}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "src", "src", "{CA9AC87F-097E-4F15-8393-4BC07735A5B0}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "test", "test", "{04DBDB01-70F4-4E06-B468-8F87850B22BE}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.Application.Tests", "test\CoreFW.Application.Tests\CoreFW.Application.Tests.csproj", "{50B2631D-129C-47B3-A587-029CCD6099BC}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.Domain.Shared", "src\CoreFW.Domain.Shared\CoreFW.Domain.Shared.csproj", "{42F719ED-8413-4895-B5B4-5AB56079BC66}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.Application.Contracts", "src\CoreFW.Application.Contracts\CoreFW.Application.Contracts.csproj", "{520659C8-C734-4298-A3DA-B539DB9DFC0B}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.HttpApi", "src\CoreFW.HttpApi\CoreFW.HttpApi.csproj", "{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.HttpApi.Client", "src\CoreFW.HttpApi.Client\CoreFW.HttpApi.Client.csproj", "{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.EntityFrameworkCore.Tests", "test\CoreFW.EntityFrameworkCore.Tests\CoreFW.EntityFrameworkCore.Tests.csproj", "{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.TestBase", "test\CoreFW.TestBase\CoreFW.TestBase.csproj", "{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.Domain.Tests", "test\CoreFW.Domain.Tests\CoreFW.Domain.Tests.csproj", "{E512F4D9-9375-480F-A2F6-A46509F9D824}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.HttpApi.Client.ConsoleTestApp", "test\CoreFW.HttpApi.Client.ConsoleTestApp\CoreFW.HttpApi.Client.ConsoleTestApp.csproj", "{EF480016-9127-4916-8735-D2466BDBC582}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "CoreFW.DbMigrator", "src\CoreFW.DbMigrator\CoreFW.DbMigrator.csproj", "{AA94D832-1CCC-4715-95A9-A483F23A1A5D}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "CoreFW.Blazor", "src\CoreFW.Blazor\CoreFW.Blazor.csproj", "{16F0BF4E-7D73-4278-8D9A-7CDE37105C6B}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "1.Application", "1.Application", "{02EA681E-C7D8-13C7-8484-4AC65E1B71E8}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "2.Domain", "2.Domain", "{FA2BF189-584C-47AA-A77D-FE02DAB6D83C}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "3.Infrastructure", "3.Infrastructure", "{34428CFB-DBF7-47B2-8FBC-442153498C70}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "4.Host", "4.Host", "{5B3EE994-F324-43EC-92DE-DC5E63C6851E}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}.Release|Any CPU.Build.0 = Release|Any CPU
		{1A94A50E-06DC-43C1-80B5-B662820EC3EB}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{1A94A50E-06DC-43C1-80B5-B662820EC3EB}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{1A94A50E-06DC-43C1-80B5-B662820EC3EB}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{1A94A50E-06DC-43C1-80B5-B662820EC3EB}.Release|Any CPU.Build.0 = Release|Any CPU
		{C956DD76-69C8-4A9C-83EA-D17DF83340FD}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{C956DD76-69C8-4A9C-83EA-D17DF83340FD}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{C956DD76-69C8-4A9C-83EA-D17DF83340FD}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{C956DD76-69C8-4A9C-83EA-D17DF83340FD}.Release|Any CPU.Build.0 = Release|Any CPU
		{50B2631D-129C-47B3-A587-029CCD6099BC}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{50B2631D-129C-47B3-A587-029CCD6099BC}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{50B2631D-129C-47B3-A587-029CCD6099BC}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{50B2631D-129C-47B3-A587-029CCD6099BC}.Release|Any CPU.Build.0 = Release|Any CPU
		{42F719ED-8413-4895-B5B4-5AB56079BC66}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{42F719ED-8413-4895-B5B4-5AB56079BC66}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{42F719ED-8413-4895-B5B4-5AB56079BC66}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{42F719ED-8413-4895-B5B4-5AB56079BC66}.Release|Any CPU.Build.0 = Release|Any CPU
		{520659C8-C734-4298-A3DA-B539DB9DFC0B}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{520659C8-C734-4298-A3DA-B539DB9DFC0B}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{520659C8-C734-4298-A3DA-B539DB9DFC0B}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{520659C8-C734-4298-A3DA-B539DB9DFC0B}.Release|Any CPU.Build.0 = Release|Any CPU
		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}.Release|Any CPU.Build.0 = Release|Any CPU
		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}.Release|Any CPU.Build.0 = Release|Any CPU
		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}.Release|Any CPU.Build.0 = Release|Any CPU
		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}.Release|Any CPU.Build.0 = Release|Any CPU
		{E512F4D9-9375-480F-A2F6-A46509F9D824}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{E512F4D9-9375-480F-A2F6-A46509F9D824}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{E512F4D9-9375-480F-A2F6-A46509F9D824}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{E512F4D9-9375-480F-A2F6-A46509F9D824}.Release|Any CPU.Build.0 = Release|Any CPU
		{EF480016-9127-4916-8735-D2466BDBC582}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{EF480016-9127-4916-8735-D2466BDBC582}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{EF480016-9127-4916-8735-D2466BDBC582}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{EF480016-9127-4916-8735-D2466BDBC582}.Release|Any CPU.Build.0 = Release|Any CPU
		{AA94D832-1CCC-4715-95A9-A483F23A1A5D}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{AA94D832-1CCC-4715-95A9-A483F23A1A5D}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{AA94D832-1CCC-4715-95A9-A483F23A1A5D}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{AA94D832-1CCC-4715-95A9-A483F23A1A5D}.Release|Any CPU.Build.0 = Release|Any CPU
		{16F0BF4E-7D73-4278-8D9A-7CDE37105C6B}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{16F0BF4E-7D73-4278-8D9A-7CDE37105C6B}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{16F0BF4E-7D73-4278-8D9A-7CDE37105C6B}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{16F0BF4E-7D73-4278-8D9A-7CDE37105C6B}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(NestedProjects) = preSolution
		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F} = {FA2BF189-584C-47AA-A77D-FE02DAB6D83C}
		{1A94A50E-06DC-43C1-80B5-B662820EC3EB} = {02EA681E-C7D8-13C7-8484-4AC65E1B71E8}
		{C956DD76-69C8-4A9C-83EA-D17DF83340FD} = {34428CFB-DBF7-47B2-8FBC-442153498C70}
		{50B2631D-129C-47B3-A587-029CCD6099BC} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
		{42F719ED-8413-4895-B5B4-5AB56079BC66} = {FA2BF189-584C-47AA-A77D-FE02DAB6D83C}
		{520659C8-C734-4298-A3DA-B539DB9DFC0B} = {02EA681E-C7D8-13C7-8484-4AC65E1B71E8}
		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27} = {5B3EE994-F324-43EC-92DE-DC5E63C6851E}
		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC} = {5B3EE994-F324-43EC-92DE-DC5E63C6851E}
		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
		{E512F4D9-9375-480F-A2F6-A46509F9D824} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
		{EF480016-9127-4916-8735-D2466BDBC582} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
		{AA94D832-1CCC-4715-95A9-A483F23A1A5D} = {34428CFB-DBF7-47B2-8FBC-442153498C70}
		{16F0BF4E-7D73-4278-8D9A-7CDE37105C6B} = {5B3EE994-F324-43EC-92DE-DC5E63C6851E}
		{02EA681E-C7D8-13C7-8484-4AC65E1B71E8} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
		{FA2BF189-584C-47AA-A77D-FE02DAB6D83C} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
		{34428CFB-DBF7-47B2-8FBC-442153498C70} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
		{5B3EE994-F324-43EC-92DE-DC5E63C6851E} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {28315BFD-90E7-4E14-A2EA-F3D23AF4126F}
	EndGlobalSection
EndGlobal
````

## File: CoreFW.sln.DotSettings
````
<wpf:ResourceDictionary xml:space="preserve" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" xmlns:s="clr-namespace:System;assembly=mscorlib" xmlns:ss="urn:shemas-jetbrains-com:settings-storage-xaml" xmlns:wpf="http://schemas.microsoft.com/winfx/2006/xaml/presentation">
	<s:Boolean x:Key="/Default/CodeEditing/Intellisense/CodeCompletion/IntelliSenseCompletingCharacters/CSharpCompletingCharacters/UpgradedFromVSSettings/@EntryValue">True</s:Boolean>
	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceDoWhileStatementBraces/@EntryIndexedValue">WARNING</s:String>
	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceFixedStatementBraces/@EntryIndexedValue">WARNING</s:String>
	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceForeachStatementBraces/@EntryIndexedValue">WARNING</s:String>
	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceForStatementBraces/@EntryIndexedValue">WARNING</s:String>
	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceIfStatementBraces/@EntryIndexedValue">WARNING</s:String>
	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceLockStatementBraces/@EntryIndexedValue">WARNING</s:String>
	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceUsingStatementBraces/@EntryIndexedValue">WARNING</s:String>
	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceWhileStatementBraces/@EntryIndexedValue">WARNING</s:String>
	<s:String x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_FOR_FOR/@EntryValue">Required</s:String>
	<s:String x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_FOR_FOREACH/@EntryValue">Required</s:String>
	<s:String x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_FOR_IFELSE/@EntryValue">Required</s:String>
	<s:String x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_FOR_WHILE/@EntryValue">Required</s:String>
	<s:Boolean x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_REDUNDANT/@EntryValue">False</s:Boolean>
	<s:Boolean x:Key="/Default/CodeStyle/Generate/=Implementations/@KeyIndexDefined">True</s:Boolean>
	<s:String x:Key="/Default/CodeStyle/Generate/=Implementations/Options/=Async/@EntryIndexedValue">False</s:String>
	<s:String x:Key="/Default/CodeStyle/Generate/=Implementations/Options/=Mutable/@EntryIndexedValue">False</s:String>
	<s:Boolean x:Key="/Default/CodeStyle/Generate/=Overrides/@KeyIndexDefined">True</s:Boolean>
	<s:String x:Key="/Default/CodeStyle/Generate/=Overrides/Options/=Async/@EntryIndexedValue">False</s:String>
	<s:String x:Key="/Default/CodeStyle/Generate/=Overrides/Options/=Mutable/@EntryIndexedValue">False</s:String>
	<s:String x:Key="/Default/CodeStyle/Naming/CSharpNaming/Abbreviations/=SQL/@EntryIndexedValue">SQL</s:String>
</wpf:ResourceDictionary>
````

## File: CoreRequiment.txt
````
Technical
	ABP Framework
	Blazor
	Devexpress
	MySQL, SQL Server (swicth option)
	Solid Architecture (Built with best practices)
		Clean source code in a well-defined solution structure
		Layered & modular architecture
		Domain Driven Design implementation
		Dependency injection everywhere
	Based on Strong Frameworks (Built on tools you already know)
		.NET Core 8.x (cross-platform support)
		ASP.NET Core / ASP.NET MVC & Web API
		EntityFramework Code-First and Migrations
		Bootstrap, AutoMapper...	
Feature
	Multi-Tenancy (Complete SaaS development kit)
		Tenant and Edition (package) management for SaaS applications
		Subscription management & recurring payments
		PayPal & Stripe integration
		Basic invoice for payments
		Dashboard for edition, tenant & income statistics
		Single database, database per tenant and hybrid database suppor
		Custom tenant logo and CSS support
		Can work in multi-tenant and single-tenant modes
	Authentication & Authorization (Rich login options and complete authorization system)
		Based on ASP.NET Identity Framework
		User & role management pages
		Hierarchical organization units system to group users and entities
		User login, register, password-reset and email validation pages
		User, role and permission based flexible authorization
		User and Tenant impersonation
		User account linking
		Two Factor Authentication (Email, SMS, Google Authenticator)
		User Lockout
		LDAP(and LDAPS)/Active Directory login support
		Active Directory Federation Service (ADFS) Authentication
		Social media logins (Facebook, Twitter, Google+ and Microsoft Account implemented)
		OpenId Connect Authentication
		Log and show all login attempts for users
		Password complexity settings
		Automatic Cross-Site Request Forgery (CSRF) protection
		OpenIddict integration
		User Delegation
		Session Timeout and Lock Screen
		Multitenant LDAP support
	HTTP API (API for Clients)
		HTTP/REST API for all the application functionalities.
		GraphQL API infrastructure for 3rd-party clients.
	Dynamic UI Localization (Control Localization in your application)
		Fully localized UI
		Can add, remove and translate languages on UI
		RTL and LTR support
		English, VietName, Chinese localizations are included
	Setting Management (Manage the application settings)
		Host & tenant-specific setting pages
		Hierarchical setting management infrastructure
		Easily configurable
	Cross-Cutting Concerns (Automates repeating tasks... DRY!)
		Validation
		Logging
		Exception handling
		Caching
		Automatic audit/security logging
		Automatic database connection management and unit of work implementation
		Periodic Audit Log Deletion
	Automated Testing (Testabiliy is so important)
		Testable architecture
		Includes unit & integration test written with xUnit
		Includes UI tests written with Playwright
	Other highlights
		Webhook Feature
		Dynamic Entity Properties
		Pre-configured to deploy as Docker containers
		Real-time push notification system (with SignalR integration)
		Real-time chat system (with SignalR integration)
		Background job system (with Hangfire integration)
		Multiple time zone support for application, tenants and users
		Twilio integration option for sending SMS
		Show and download logs from UI
		Built-in global event bus for server-side events with pre-defined events for entity changes)
		Show entity histories
		Cookie consent & download users collected data (GDPR)
		Application setup screen
		Personalization of layout, header, menu and footer per user
		Swagger integration
		Tested on major PAAS providers (Azure, AWS)
		Healthchecks
		Helm charts for deployment
````

## File: NuGet.Config
````
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
  </packageSources>
</configuration>
````

## File: README.md
````markdown
# CoreFW

## About this solution

This is a layered startup solution based on [Domain Driven Design (DDD)](https://abp.io/docs/latest/framework/architecture/domain-driven-design) practises. All the fundamental ABP modules are already installed. 

### Pre-requirements

* [.NET 8.0+ SDK](https://dotnet.microsoft.com/download/dotnet)
* [Node v18 or 20](https://nodejs.org/en)

### Configurations

The solution comes with a default configuration that works out of the box. However, you may consider to change the following configuration before running your solution:

* Check the `ConnectionStrings` in `appsettings.json` files under the `CoreFW.Blazor` and `CoreFW.DbMigrator` projects and change it if you need.

### Before running the application

#### Generating a Signing Certificate

In the production environment, you need to use a production signing certificate. ABP Framework sets up signing and encryption certificates in your application and expects an `openiddict.pfx` file in your application.

This certificate is already generated by ABP CLI, so most of the time you don't need to generate it yourself. However, if you need to generate a certificate, you can use the following command:

```bash
dotnet dev-certs https -v -ep openiddict.pfx -p b35f0cf8-1c4b-4414-bd75-d79555e50386
```

> `b35f0cf8-1c4b-4414-bd75-d79555e50386` is the password of the certificate, you can change it to any password you want.

It is recommended to use **two** RSA certificates, distinct from the certificate(s) used for HTTPS: one for encryption, one for signing.

For more information, please refer to: https://documentation.openiddict.com/configuration/encryption-and-signing-credentials.html#registering-a-certificate-recommended-for-production-ready-scenarios

> Also, see the [Configuring OpenIddict](https://abp.io/docs/latest/deployment/configuring-openiddict#production-environment) documentation for more information.

#### Install Client-Side Libraries

Run the following command in the directory of your final application:

```bash
abp install-libs
```

> This command installs all NPM packages for MVC/Razor Pages and Blazor Server UIs and this command is already run by the ABP CLI, so most of the time you don't need to run this command manually.

#### Create the Database

Run `CoreFW.DbMigrator` to create the initial database. This should be done in the first run. It is also needed if a new database migration is added to the solution later.

### Solution structure

This is a layered monolith application that consists of the following applications:

* `CoreFW.DbMigrator`: A console application which applies the migrations and also seeds the initial data. It is useful on development as well as on production environment.
* `CoreFW.Blazor`: ASP.NET Core Blazor Server application that is the essential web application of the solution.

### Deploying the application

Deploying an ABP application is not different than deploying any .NET or ASP.NET Core application. However, there are some topics that you should care about when you are deploying your applications. You can check ABP's [Deployment documentation](https://abp.io/docs/latest/deployment) before deploying your application.

### Additional resources

You can see the following resources to learn more about your solution and the ABP Framework:

* [Web Application Development Tutorial](https://abp.io/docs/latest/tutorials/book-store/part-01?UI=Blazor&DB=EF)
* [Application Startup Template Structure](https://abp.io/docs/latest/solution-templates/layered-web-application)
* [LeptonX Lite Blazor UI](https://abp.io/docs/latest/ui-themes/lepton-x-lite/blazor?UI=BlazorServer)
````
