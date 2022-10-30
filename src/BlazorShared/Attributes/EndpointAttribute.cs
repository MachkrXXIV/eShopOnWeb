using System;

namespace BlazorShared.Attributes;

public class EndpointAttribute : Attribute
{
    public string Name { get; set; }
    public string Subtitle { get; set; }
}
