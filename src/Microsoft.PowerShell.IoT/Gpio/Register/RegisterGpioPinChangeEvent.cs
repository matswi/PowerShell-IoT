using System;
using System.Management.Automation;
using System.Device.Gpio;

[Cmdlet(VerbsCommon.Register, "GpioPinChangeEvent")]

public class RegisterGpioPinChangeEvent : GpioCmdletBase
{
    [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, Position = 0)]
    public int[] Id { get; set; }

    [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, Position = 0)]
    public string[] Type { get; set; }

    
}