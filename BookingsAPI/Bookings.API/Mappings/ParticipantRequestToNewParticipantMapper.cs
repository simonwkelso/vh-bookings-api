using System.Linq;
using Bookings.Api.Contract.Requests;
using Bookings.DAL.Commands;
using Bookings.Domain;
using Bookings.Domain.RefData;

namespace Bookings.API.Mappings
{
    /// <summary>
    /// This class is used to map a participant request object to the NewParticipant model
    /// used by the AddParticipantsToVideoHearingCommand.
    /// </summary>
    public class ParticipantRequestToNewParticipantMapper
    {
        public NewParticipant MapRequestToNewParticipant(ParticipantRequest requestParticipant, CaseType caseType)
        {
            var caseRole = caseType.CaseRoles.Single(x => x.Name == requestParticipant.CaseRoleName);
            var hearingRole = caseRole.HearingRoles.Single(x => x.Name == requestParticipant.HearingRoleName);
            Person person;
            if(hearingRole.UserRole.Name=="Individual")
            {
                var address = new Address(requestParticipant.HouseNumber, requestParticipant.Street, requestParticipant.Postcode, requestParticipant.City, requestParticipant.County);
                person = new Person(requestParticipant.Title, requestParticipant.FirstName, requestParticipant.LastName,
                requestParticipant.Username, address);
            }
            else
            {
                person = new Person(requestParticipant.Title, requestParticipant.FirstName, requestParticipant.LastName,
                requestParticipant.Username);
            }

            person.MiddleNames = requestParticipant.MiddleNames;
            person.ContactEmail = requestParticipant.ContactEmail;
            person.TelephoneNumber = requestParticipant.TelephoneNumber;
            
            return new NewParticipant
            {
                Person = person,
                CaseRole = caseRole,
                HearingRole = hearingRole,
                DisplayName = requestParticipant.DisplayName,
                Representee = requestParticipant.Representee,
                SolicitorsReference = requestParticipant.SolicitorsReference,
            };
        }
    }
}