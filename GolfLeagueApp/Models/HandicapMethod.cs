//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GolfLeagueApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HandicapMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HandicapMethod()
        {
            this.LeagueYears = new HashSet<LeagueYear>();
        }
    
        public int HandicapID { get; set; }
        public string Method { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeagueYear> LeagueYears { get; set; }
    }
}
