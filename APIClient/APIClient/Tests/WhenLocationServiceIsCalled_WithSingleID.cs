using System.Threading.Tasks;
using NUnit.Framework;
using APIClient.RickAndMortyIOService.Service;

namespace APIClient.Tests
{
    public class WhenLocationServiceIsCalled_WithSingleID
    {
        SingleLocationService _singleLocationService;

        [OneTimeSetUp]
        public async Task OneTimeSetupAsync()
        {
            _singleLocationService = new SingleLocationService();
            int testId = 1;
            await _singleLocationService.MakeRequestAsync(testId);
        }
        [Test]
        [Category ("Happy")]
        public void GivenViableRequest_StatusIs200()
        {
            Assert.That(_singleLocationService.StatusCode, Is.EqualTo(200));
        }
        [Test]
        [Category("Happy")]
        public void GivenValidId_ReturnCorrectLocation()
        {
            Assert.That(_singleLocationService.LocationsDTO.Response.name, Is.EqualTo("Earth (C-137)"));
        }
        [Test]
        [Category("Happy")]
        public void GivenValidId_CorrectNumberOfResidents()
        {
            Assert.That(_singleLocationService.GetListOfResidentsFromLocation().Count, Is.EqualTo(27));
        }
        
    }
    public class WhenLocationServiceIsCalled_WithInvalidID
    {
        SingleLocationService _singleLocationService;

        [OneTimeSetUp]
        public async Task OneTimeSetupAsync()
        {
            _singleLocationService = new SingleLocationService();
            int badId = -1;
            await _singleLocationService.MakeRequestAsync(badId);
        }
        [Test]
        [Category("Sad")]
        public void GivenInvalidId_ReturnNull()
        {
            Assert.That(_singleLocationService.LocationsDTO.Response.name, Is.EqualTo(null));
        }
        [Test]
        [Category("Sad")]
        public void GivenInvalidId_ReturnStatusCode404()
        {
            Assert.That(_singleLocationService.StatusCode, Is.EqualTo(404));
        }
    }
}
