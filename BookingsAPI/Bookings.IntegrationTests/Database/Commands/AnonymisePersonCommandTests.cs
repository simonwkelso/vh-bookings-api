using System;
using System.Linq;
using System.Threading.Tasks;
using Bookings.DAL;
using Bookings.DAL.Commands;
using Bookings.DAL.Exceptions;
using Bookings.DAL.Queries;
using FluentAssertions;
using NUnit.Framework;

namespace Bookings.IntegrationTests.Database.Commands
{
    public class AnonymisePersonCommandTests : DatabaseTestsBase
    {
        private AnonymisePersonCommandHandler _commandHandler;
        private Guid _newHearingId;
        private GetHearingByIdQueryHandler _getHearingByIdQueryHandler;
        
        [SetUp]
        public void Setup()
        {
            var context = new BookingsDbContext(BookingsDbContextOptions);
            _commandHandler = new AnonymisePersonCommandHandler(context);
            _newHearingId = Guid.Empty;
            _getHearingByIdQueryHandler = new GetHearingByIdQueryHandler(context);
        }
        
        [TearDown]
        public new async Task TearDown()
        {
            TestContext.WriteLine("Cleaning hearings for AnonymisePersonCommandHandler");
            if (_newHearingId != Guid.Empty)
            {
                TestContext.WriteLine($"Removing test hearing {_newHearingId}");
                await Hooks.RemoveVideoHearing(_newHearingId);
            }
        }

        [Test]
        public void should_throw_exception_when_person_does_not_exist()
        {
            var username = "do_not_exist@test.com";
            var command = new AnonymisePersonCommand(username);
            Assert.ThrowsAsync<PersonNotFoundException>(() => _commandHandler.Handle(command));
        }

        [Test]
        public async Task should_anonymise_person()
        {
            var seededHearing = await Hooks.SeedPastHearings(DateTime.Today.AddMonths(-3));
            TestContext.WriteLine($"New seeded video hearing id: {seededHearing.Id}");
            _newHearingId = seededHearing.Id;

            var person = seededHearing.GetPersons().First();
            var command = new AnonymisePersonCommand(person.Username);
            await _commandHandler.Handle(command);
            
            var updatedHearing = await _getHearingByIdQueryHandler.Handle(new GetHearingByIdQuery(seededHearing.Id));
            var updatedPerson = updatedHearing.GetPersons().First(x => x.Id == person.Id);
            updatedPerson.FirstName.Should().NotBe(person.FirstName);
            updatedPerson.LastName.Should().NotBe(person.LastName);
            updatedPerson.Username.Should().NotBe(person.Username);
            updatedPerson.ContactEmail.Should().NotBe(person.ContactEmail);
        }
    }
}