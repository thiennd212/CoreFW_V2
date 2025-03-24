using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;

namespace CoreFW.Blazor.Components.Dx.Base
{
    public partial class DxFormBase : DxFormLayout
    {
        private string _cssClass = string.Empty;
        private string _groupCaption = string.Empty;

        [Parameter]
        public new string CssClass 
        { 
            get => _cssClass;
            set => _cssClass = value;
        }

        [Parameter]
        public string GroupCaption
        {
            get => _groupCaption;
            set => _groupCaption = value;
        }

        [Parameter]
        public int ColSpanMd { get; set; } = 12;

        [Parameter]
        public new RenderFragment ChildContent { get; set; } = null!;

        [Parameter]
        public bool EnableValidation { get; set; } = true;

        [Parameter]
        public bool ShowValidationSummary { get; set; } = true;

        [Parameter]
        public EventCallback<EditContext> OnValidSubmit { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            ConfigureDefaultSettings();
        }

        private void ConfigureDefaultSettings()
        {
            if (string.IsNullOrEmpty(_cssClass))
            {
                _cssClass = "dx-form";
            }

            if (string.IsNullOrEmpty(_groupCaption))
            {
                _groupCaption = "Thông tin";
            }
        }
    }
} 