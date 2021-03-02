using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "SVG File", GUID = "f63b778b-d1b7-44a7-838d-027a3498ba86", 
        Description = "Use this to upload Scalable Vector Graphic (SVG) images.")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : ImageData
    {
            // instead of generating a smaller bitmap file for thumbnail,
            // use the same binary vector image for thumbnail
            public override Blob Thumbnail { get => base.BinaryData; }        
    }
}