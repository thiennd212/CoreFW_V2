using System;
using System.Collections.Generic;
using DevExpress.Blazor;
using DevExpress.Blazor.Base;
using Microsoft.AspNetCore.Components;

namespace CoreFW.Blazor.Components.Dx.Base
{
    public partial class DxTreeViewBase<TItem> : DxTreeView
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
        public new bool AllowSelectNodes { get; set; } = true;

        [Parameter]
        public new bool ShowExpandButtons { get; set; } = true;

        [Parameter]
        public bool ShowCheckboxes { get; set; }

        [Parameter]
        public bool AllowSelectParentNodes { get; set; } = true;

        [Parameter]
        public bool AllowDragDrop { get; set; }

        [Parameter]
        public object SelectedNodeKey { get; set; } = null!;

        [Parameter]
        public EventCallback<object> SelectedNodeKeyChanged { get; set; }

        [Parameter]
        public new RenderFragment<DxTreeViewNode> NodeTemplate { get; set; } = null!;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            ConfigureDefaultSettings();
        }

        private void ConfigureDefaultSettings()
        {
            if (string.IsNullOrEmpty(_cssClass))
            {
                _cssClass = "dx-treeview";
            }
        }
    }
} 