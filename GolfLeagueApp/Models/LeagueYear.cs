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
    
    public partial class LeagueYear
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeagueYear()
        {
            this.Schedules = new HashSet<Schedule>();
            this.Teams = new HashSet<Team>();
        }
    
        public int YearID { get; set; }
        public Nullable<int> MaxScore { get; set; }
        public int LeagueID { get; set; }
        public int HandicapID { get; set; }
        public int PointID { get; set; }
        public int MaxScoreID { get; set; }
        public Nullable<int> TrackPutts { get; set; }
    
        public virtual HandicapMethod HandicapMethod { get; set; }
        public virtual League League { get; set; }
        public virtual MaxScore MaxScore1 { get; set; }
        public virtual PointSytem PointSytem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Team> Teams { get; set; }
    }
}