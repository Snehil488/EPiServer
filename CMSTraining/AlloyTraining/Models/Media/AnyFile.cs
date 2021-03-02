using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "AnyFile", GUID = "c4103ba2-29d3-48a6-b6d7-262eb0057a5d", 
        Description = "Use this to upload any type of file.")]
    public class AnyFile : MediaData
    {
    }
}