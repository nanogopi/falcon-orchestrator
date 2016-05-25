//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FalconOrchestrator.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerIOCEvent
    {
        public int CustomIOCEventId { get; set; }
        public string Offset { get; set; }
        public int CustomerId { get; set; }
        public int DetectionDeviceId { get; set; }
        public string ProcessId { get; set; }
        public string ParentProcessId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string CommandLine { get; set; }
        public string MD5String { get; set; }
        public string IPv4 { get; set; }
        public string DomainName { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual DetectionDevice DetectionDevice { get; set; }
    }
}