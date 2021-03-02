using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Image File", GUID = "eb6803cb-bacf-4bbd-8788-f8f8a885a948",
        Description = "Use this to upload image files")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {

        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }
    }
}