# Hướng dẫn Triển khai và Sử dụng DevExpress Components

## Mục lục
1. [Tổng quan](#1-tổng-quan)
2. [Các Bước Triển khai](#2-các-bước-triển-khai)
3. [Chi tiết Components](#3-chi-tiết-components)
4. [Cách Sử dụng](#4-cách-sử-dụng)
5. [Best Practices](#5-best-practices)
6. [Testing](#6-testing)
7. [Documentation](#7-documentation)
8. [Quy trình Review và Kiểm thử](#8-quy-trình-review-và-kiểm-thử)

## 1. Tổng quan

### 1.1 Cấu trúc Thư mục
```
src/CoreFW.Blazor/
├── Components/
│   ├── Shared/
│   │   ├── DxGridComponent.razor
│   │   ├── DxFormComponent.razor
│   │   ├── DxTreeViewComponent.razor
│   │   └── DxTabControlComponent.razor
│   ├── Layouts/
│   │   ├── DxFormLayoutComponent.razor
│   │   └── DxPageLayoutComponent.razor
│   └── Controls/
│       ├── DxInputComponent.razor
│       └── DxValidationComponent.razor
```

### 1.2 Using Statements Cơ bản
```csharp
@using DevExpress.Blazor
@using DevExpress.Blazor.Grid
@using DevExpress.Blazor.Form
@using DevExpress.Blazor.TreeView
@using DevExpress.Blazor.TabControl
```

## 2. Các Bước Triển khai

### 2.1 Giai đoạn 1: Grid và Form
1. **DxGridComponent.razor**
   - Implement grid features
   - Add events handlers
   - Configure default settings

2. **DxFormComponent.razor**
   - Implement form layout
   - Add validation
   - Configure auto save

3. **DxFormLayoutComponent.razor**
   - Implement layout structure
   - Add responsive design
   - Configure styling

### 2.2 Giai đoạn 2: TreeView và TabControl
1. **DxTreeViewComponent.razor**
   - Implement tree structure
   - Add drag & drop
   - Configure context menu

2. **DxTabControlComponent.razor**
   - Implement tab control
   - Add drag & drop
   - Configure tab position

3. **DxPageLayoutComponent.razor**
   - Implement page layout
   - Add responsive design
   - Configure navigation

### 2.3 Giai đoạn 3: Controls và Common
1. **DxInputComponent.razor**
   - Implement input controls
   - Add validation
   - Configure styling

2. **DxValidationComponent.razor**
   - Implement validation logic
   - Add error messages
   - Configure validation rules

3. **DxLoadingIndicator.razor**
   - Implement loading state
   - Add animation
   - Configure styling

4. **DxErrorBoundary.razor**
   - Implement error handling
   - Add error messages
   - Configure recovery

## 3. Chi tiết Components

### 3.1 DxGridComponent.razor
```csharp
@inherits DxGridComponent
@using DevExpress.Blazor
@using DevExpress.Blazor.Grid

@code {
    [Parameter]
    public bool EnablePaging { get; set; } = true;

    [Parameter]
    public bool EnableSorting { get; set; } = true;

    [Parameter]
    public bool EnableFiltering { get; set; } = true;

    [Parameter]
    public bool EnableExport { get; set; } = true;

    [Parameter]
    public bool EnableSelection { get; set; } = true;

    [Parameter]
    public SelectionMode SelectionMode { get; set; } = SelectionMode.Single;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ConfigureDefaultSettings();
    }

    private void ConfigureDefaultSettings()
    {
        // Cấu hình mặc định cho grid
        ShowFilterRow = EnableFiltering;
        ShowPager = EnablePaging;
        AllowSort = EnableSorting;
        PageSize = 10;
        ShowPageSizeSelector = true;
        PageSizeSelectorVisible = true;
        
        // Cấu hình selection
        if (EnableSelection)
        {
            SelectionMode = this.SelectionMode;
        }

        // Cấu hình export
        if (EnableExport)
        {
            ConfigureExportOptions();
        }
    }

    private void ConfigureExportOptions()
    {
        // Cấu hình tùy chọn export
        ExportOptions = new GridExportOptions
        {
            ExportFormat = GridExportFormat.Excel,
            AllowExportSelectedDataOnly = true,
            FileName = "ExportData"
        };
    }
}
```

### 3.2 DxFormComponent.razor
```csharp
@inherits DxFormComponent
@using DevExpress.Blazor
@using DevExpress.Blazor.Form

@code {
    [Parameter]
    public bool EnableValidation { get; set; } = true;

    [Parameter]
    public bool EnableAutoSave { get; set; } = false;

    [Parameter]
    public ValidationMode ValidationMode { get; set; } = ValidationMode.Auto;

    [Parameter]
    public EventCallback<FormData> OnSubmit { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ConfigureDefaultSettings();
    }

    private void ConfigureDefaultSettings()
    {
        // Cấu hình mặc định cho form
        this.ValidationMode = ValidationMode;
        ShowValidationSummary = EnableValidation;
        
        if (EnableAutoSave)
        {
            ConfigureAutoSave();
        }
    }

    private void ConfigureAutoSave()
    {
        // Cấu hình auto save
        AutoSaveInterval = TimeSpan.FromSeconds(30);
        AutoSaveMode = AutoSaveMode.OnValueChanged;
    }
}
```

### 3.3 DxTreeViewComponent.razor
```csharp
@inherits DxTreeViewComponent
@using DevExpress.Blazor
@using DevExpress.Blazor.TreeView

@code {
    [Parameter]
    public bool EnableDragDrop { get; set; } = true;

    [Parameter]
    public bool EnableCheckboxes { get; set; } = false;

    [Parameter]
    public bool EnableContextMenu { get; set; } = true;

    [Parameter]
    public EventCallback<TreeNodeEventArgs> OnNodeClick { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ConfigureDefaultSettings();
    }

    private void ConfigureDefaultSettings()
    {
        // Cấu hình mặc định cho tree view
        AllowDragDrop = EnableDragDrop;
        ShowCheckboxes = EnableCheckboxes;
        ShowExpandButtons = true;
        EnableContextMenu = this.EnableContextMenu;
    }
}
```

### 3.4 DxTabControlComponent.razor
```csharp
@inherits DxTabControlComponent
@using DevExpress.Blazor
@using DevExpress.Blazor.TabControl

@code {
    [Parameter]
    public bool EnableCloseButton { get; set; } = true;

    [Parameter]
    public bool EnableDragDrop { get; set; } = true;

    [Parameter]
    public TabPosition TabPosition { get; set; } = TabPosition.Top;

    [Parameter]
    public EventCallback<TabPageEventArgs> OnTabClose { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ConfigureDefaultSettings();
    }

    private void ConfigureDefaultSettings()
    {
        // Cấu hình mặc định cho tab control
        ShowCloseButton = EnableCloseButton;
        AllowTabDragDrop = EnableDragDrop;
        this.TabPosition = TabPosition;
    }
}
```

## 4. Cách Sử dụng

### 4.1 Sử dụng DxGridComponent
```razor
<DxGridComponent T="UserDto"
            Data="@Users"
            EnablePaging="true"
            EnableSorting="true"
            EnableFiltering="true"
            EnableExport="true"
            EnableSelection="true"
            SelectionMode="SelectionMode.Multiple">
    <Columns>
        <DxGridDataColumn FieldName="@nameof(UserDto.UserName)" 
                         Caption="Tên người dùng" 
                         MinWidth="150" 
                         AllowGroup="false"
                         AllowSort="true"
                         AllowFilter="true" />
        <DxGridDataColumn FieldName="@nameof(UserDto.Email)" 
                         Caption="Email" 
                         MinWidth="200" 
                         AllowGroup="false"
                         AllowSort="true"
                         AllowFilter="true" />
        <DxGridDataColumn FieldName="@nameof(UserDto.CreationTime)" 
                         Caption="Ngày tạo" 
                         MinWidth="150" 
                         AllowGroup="false"
                         AllowSort="true"
                         AllowFilter="true" />
    </Columns>
</DxGridComponent>
```

### 4.2 Sử dụng DxFormComponent
```razor
<DxFormComponent EnableValidation="true"
            EnableAutoSave="true"
            ValidationMode="ValidationMode.Auto"
            OnSubmit="@HandleSubmit">
    <DxFormLayout>
        <DxFormLayoutGroup Caption="Thông tin người dùng">
            <DxTextBox @bind-Value="@User.UserName" 
                      ValidationMode="ValidationMode.Auto" />
            <DxTextBox @bind-Value="@User.Email" 
                      ValidationMode="ValidationMode.Auto" />
        </DxFormLayoutGroup>
    </DxFormLayout>
</DxFormComponent>
```

## 5. Best Practices

### 5.1 Naming Conventions
- Sử dụng prefix "Dx" cho tất cả components
- Thêm suffix "Component" cho tất cả components
- Sử dụng PascalCase cho tên file và class
- Đặt tên parameters theo quy tắc của DevExpress

### 5.2 Parameter Design
- Đặt tên parameters rõ ràng, dễ hiểu
- Sử dụng các kiểu dữ liệu phù hợp
- Thêm XML documentation cho parameters
- Tuân thủ quy tắc đặt tên của DevExpress

### 5.3 Event Handling
- Sử dụng EventCallback cho các events
- Implement các event handlers mặc định
- Cho phép override các event handlers
- Xử lý events theo cách của DevExpress

### 5.4 Styling
- Sử dụng CSS isolation
- Tạo các CSS variables cho customization
- Hỗ trợ theme switching
- Tuân thủ quy tắc styling của DevExpress

## 6. Testing

### 6.1 Unit Tests
```csharp
public class DxGridComponentTests
{
    [Fact]
    public void ConfigureDefaultSettings_ShouldSetCorrectValues()
    {
        // Arrange
        var grid = new DxGridComponent();

        // Act
        grid.ConfigureDefaultSettings();

        // Assert
        Assert.True(grid.ShowFilterRow);
        Assert.True(grid.ShowPager);
        Assert.True(grid.AllowSort);
    }
}
```

### 6.2 Integration Tests
```csharp
public class DxFormComponentIntegrationTests
{
    [Fact]
    public async Task FormSubmit_ShouldTriggerCallback()
    {
        // Arrange
        var form = new DxFormComponent();
        var callbackTriggered = false;
        form.OnSubmit = new EventCallback<FormData>(null, (data) => callbackTriggered = true);

        // Act
        await form.HandleSubmitAsync();

        // Assert
        Assert.True(callbackTriggered);
    }
}
```

## 7. Documentation

### 7.1 XML Documentation
```csharp
/// <summary>
/// DevExpress Grid component with common configurations
/// </summary>
/// <typeparam name="T">Type of data items</typeparam>
public class DxGridComponent<T> : DxGridComponent
{
    /// <summary>
    /// Gets or sets whether DevExpress Grid paging is enabled
    /// </summary>
    [Parameter]
    public bool EnablePaging { get; set; }
}
```

### 7.2 Usage Examples
```razor
@* Example usage of DevExpress Grid Component *@
<DxGridComponent T="ProductDto"
            Data="@Products"
            EnablePaging="true"
            EnableSorting="true"
            EnableSelection="true"
            SelectionMode="SelectionMode.Single">
    <Columns>
        <DxGridDataColumn FieldName="@nameof(ProductDto.Name)" 
                         Caption="Tên sản phẩm" 
                         MinWidth="200" 
                         AllowGroup="false"
                         AllowSort="true"
                         AllowFilter="true" />
        <DxGridDataColumn FieldName="@nameof(ProductDto.Price)" 
                         Caption="Giá" 
                         MinWidth="120" 
                         AllowGroup="false"
                         AllowSort="true"
                         AllowFilter="true" />
    </Columns>
</DxGridComponent>
```

## 8. Quy trình Review và Kiểm thử

### 8.1 Code Review
- Kiểm tra code style
- Kiểm tra best practices
- Kiểm tra performance
- Kiểm tra security

### 8.2 Performance Testing
- Load testing
- Stress testing
- Memory usage
- CPU usage

### 8.3 Security Review
- Input validation
- Output encoding
- Authentication
- Authorization

### 8.4 Accessibility Testing
- Screen reader compatibility
- Keyboard navigation
- Color contrast
- Focus management 