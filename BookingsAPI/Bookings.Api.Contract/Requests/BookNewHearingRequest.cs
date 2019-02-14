using System;
using System.Collections.Generic;

namespace Bookings.Api.Contract.Requests
{
    public class BookNewHearingRequest
    {
        public BookNewHearingRequest()
        {
            Cases = new List<CaseRequest>();
            Participants = new List<ParticipantRequest>();
        }
        
        /// <summary>
        ///     The date and time for a hearing
        /// </summary>
        public DateTime ScheduledDateTime { get; set; }
        
        /// <summary>
        ///     The duration of a hearing (number of minutes)
        /// </summary>
        public int ScheduledDuration { get; set; }
        
        /// <summary>
        ///     The name of the hearing venue
        /// </summary>
        public string HearingVenueName { get; set; }
        
        /// <summary>
        ///     The name of the case type
        /// </summary>
        public string CaseTypeName { get; set; }
        
        /// <summary>
        ///     The name of the hearing type
        /// </summary>
        public string HearingTypeName { get; set; } 
        
        /// <summary>
        ///     List of cases associated to the hearing
        /// </summary>
        public List<CaseRequest> Cases { get; set; }
        
        /// <summary>
        ///     List of participants in hearing
        /// </summary>
        public List<ParticipantRequest> Participants { get; set; }
    }
}