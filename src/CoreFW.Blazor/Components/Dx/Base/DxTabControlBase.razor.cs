using System;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;

namespace CoreFW.Blazor.Components.Dx.Base
{
    public partial class DxTabControlBase : DxTabs
    {
        private string _cssClass = string.Empty;

        [Parameter]
        public new string CssClass 
        { 
            get => _cssClass;
            set => _cssClass = value;
        }

        [Parameter]
        public new int ActiveTabIndex { get; set; }

        [Parameter]
        public new EventCallback<int> ActiveTabIndexChanged { get; set; }

        [Parameter]
        public new RenderFragment ChildContent { get; set; } = null!;

        [Parameter]
        public bool ShowCloseButton { get; set; }

        [Parameter]
        public bool AllowDragDrop { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            ConfigureDefaultSettings();
        }

        private void ConfigureDefaultSettings()
        {
            if (string.IsNullOrEmpty(_cssClass))
            {
                _cssClass = "dx-tabs";
            }
        }
    }
} 