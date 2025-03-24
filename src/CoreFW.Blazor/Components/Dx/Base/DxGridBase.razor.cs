using System;
using System.Collections.Generic;
using DevExpress.Blazor;
using DevExpress.Blazor.Base;
using DevExpress.Blazor.Internal.VirtualScrollViewer;
using Microsoft.AspNetCore.Components;

namespace CoreFW.Blazor.Components.Dx.Base
{
    public partial class DxGridBase<TItem> : DxGrid
    {
        private string _cssClass = string.Empty;

        [Parameter]
        public new string CssClass 
        { 
            get => _cssClass;
            set => _cssClass = value;
        }

        [Parameter]
        public new IEnumerable<TItem> Data { get; set; } = null!;

        [Parameter]
        public new bool ShowFilterRow { get; set; }

        [Parameter]
        public bool ShowPager { get; set; }

        [Parameter]
        public new PagerNavigationMode PagerNavigationMode { get; set; }

        [Parameter]
        public new SpacerPosition PagerPosition { get; set; }

        [Parameter]
        public new int PageSize { get; set; } = 10;

        [Parameter]
        public new GridSelectionMode SelectionMode { get; set; }

        [Parameter]
        public bool AllowColumnDragDrop { get; set; }

        [Parameter]
        public new bool ShowGroupPanel { get; set; }

        [Parameter]
        public new IEnumerable<TItem> SelectedDataItems { get; set; } = null!;

        [Parameter]
        public new EventCallback<IEnumerable<TItem>> SelectedDataItemsChanged { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; } = null!;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            ConfigureDefaultSettings();
        }

        private void ConfigureDefaultSettings()
        {
            if (string.IsNullOrEmpty(_cssClass))
            {
                _cssClass = "dx-grid";
            }
        }
    }
} 