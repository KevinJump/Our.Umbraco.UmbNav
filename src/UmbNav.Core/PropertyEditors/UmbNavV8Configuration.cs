﻿#if NETCOREAPP
using Umbraco.Cms.Core.PropertyEditors;

#else
using Umbraco.Core.PropertyEditors;
#endif

namespace UmbNav.Core.PropertyEditors
{
    public class UmbNavV8Configuration
    {
        [ConfigurationField("maxDepth", "Max Depth", "number", Description = "The maximum number of levels in the navigation")]
        public int MaxDepth { get; set; }

        [ConfigurationField("hideLabel", "Hide Label", "boolean", Description = "Hide the property label and let the item list span the full width of the editor window.")]
        public bool HideLabel { get; set; }

        [ConfigurationField("removeNaviHideItems", "Remove NaviHide Items", "boolean", Description = "Remove items where umbracoNaviHide is true")]
        public bool RemoveNaviHideItems { get; set; }

        [ConfigurationField("hideNoopener", "Hide noopener Toggle", "boolean", Description = "Hide the ability to toggle noopener")]
        public bool HideNoopener { get; set; }

        [ConfigurationField("hideNoreferrer", "Hide noreferrer Toggle", "boolean", Description = "Hide the ability to toggle noreferrer")]
        public bool HideNoreferrer { get; set; }

        [ConfigurationField("hideIncludeChildren", "Hide Include Child Nodes Toggle", "boolean", Description = "Hide the ability to include child nodes")]
        public bool HideIncludeChildren { get; set; }

        [ConfigurationField("allowDisplay", "Allow Member Visibility", "boolean", Description = "Allow the ability to hide menu items based on member authentication status")]
        public bool AllowDisplay { get; set; } = false;

        [ConfigurationField("allowDisplayAsLabel", "Allow a Link To Display as a Label", "boolean", Description = "Allow the ability to display a link item as a label")]
        public bool AllowDisplayAsLabel { get; set; } = false;

        [ConfigurationField("allowCustomClasses", "Allow Custom Classes", "boolean", Description = "Allow the ability to set custom classes on an item")]
        public bool AllowCustomClasses { get; set; } = false;

        [ConfigurationField("allowImageIcon", "Allow Image / Icon Url", "boolean", Description = "Allow the ability to enter a image / icon url or media id")]
        public bool AllowImageIcon { get; set; }

        [ConfigurationField("allowLabels", "Allow Labels", "boolean", Description = "Allow label menu items")]
        public bool AllowLabels { get; set; }

        [ConfigurationField("expandOnHover", "Allow Expand On Hover", "boolean",
            Description = "Expand the tree item on hover")]
        public bool ExpandOnHover { get; set; } = true;
        [ConfigurationField("expandOnHoverTimeout", "Expand On Hover", "number",
            Description = "The delay to wait before the tree item expands")]
        public int ExpandOnHoverTimeout { get; set; } = 500;

        [ConfigurationField("showTopAddButton", "Show \"Add Item\" Button", "boolean", Description = "Show the \"Add Item\" button above the nav items in the editor")]
        public bool ShowTopAddButton { get; set; } = true;
    }
}
