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
    
    public partial class Match
    {
        public int MatchID { get; set; }
        public System.DateTime MatchDate { get; set; }
        public Nullable<System.DateTime> FunDay { get; set; }
        public int Team1Points { get; set; }
        public int Team2Points { get; set; }
        public int ScheduleID { get; set; }
        public int CourseID { get; set; }
        public int Team1 { get; set; }
        public int Team2 { get; set; }
    
        public virtual Match Matches1 { get; set; }
        public virtual Match Match1 { get; set; }
    }
}
