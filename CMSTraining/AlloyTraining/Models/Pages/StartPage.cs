using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "StartPage",
        GroupName =SiteGroupNames.Specialized, Order =10,
        GUID = "33a6eaf6-d315-4809-8fa2-47d9e01648e5", Description = "The home page for a website with an area for blocks and partial pages.")]

    [SiteStartIcon]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text",
        Description = "The footer text will be shown at the bottom of every page.",
        GroupName = SiteTabNames.SiteSettings, Order = 10)]
        public virtual string FooterText { get; set; }

    }
}