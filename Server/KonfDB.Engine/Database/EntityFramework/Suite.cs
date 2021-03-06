//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonfDB.Engine.Database.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Suite
    {
        public Suite()
        {
            this.Applications = new HashSet<Application>();
            this.Environments = new HashSet<Environment>();
            this.Mappings = new HashSet<Mapping>();
            this.Parameters = new HashSet<Parameter>();
            this.Regions = new HashSet<Region>();
            this.Servers = new HashSet<Server>();
            this.SuiteUsers = new HashSet<SuiteUser>();
        }
    
        public long SuiteId { get; set; }
        public string SuiteName { get; set; }
        public bool IsActive { get; set; }
        public bool UsesSysEncryption { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public byte[] Timestamp { get; set; }
        public Nullable<int> SuiteType { get; set; }
    
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Environment> Environments { get; set; }
        public virtual ICollection<Mapping> Mappings { get; set; }
        public virtual ICollection<Parameter> Parameters { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<Server> Servers { get; set; }
        public virtual ICollection<SuiteUser> SuiteUsers { get; set; }
    }
}
