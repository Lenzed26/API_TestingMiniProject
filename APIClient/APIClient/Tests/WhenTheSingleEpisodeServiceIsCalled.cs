using APIClient.RickAndMortyIOService.Service;
using NUnit.Framework;
using System.Threading.Tasks;

namespace APIClient.Tests
{
    class WhenTheSingleEpisodeServiceIsCalled
    {
        private SingleEpisodeService _singleEpisodeService;
        
        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _singleEpisodeService = new SingleEpisodeService();
            await _singleEpisodeService.MakeSingleEpisodeRequest("1");
        }

        [Test]
        [Category("Happy")]
        public void StatusIs200()
        {
            Assert.That(_singleEpisodeService.CallManager.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Category("Happy")]
        public void ResponseIsNotNull()
        {
            Assert.That(_singleEpisodeService.Json_response, Is.Not.Null);
        }

        [Test]
        [Category("Happy")]
        public void Response_ReturnEpisodeId_ReturnsRightDetails()
        {
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.id , Is.EqualTo(1));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.name, Is.EqualTo("Pilot"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.air_date, Is.EqualTo("December 2, 2013"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.episode, Is.EqualTo("S01E01"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[0], Is.EqualTo("https://rickandmortyapi.com/api/character/1"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[1], Is.EqualTo("https://rickandmortyapi.com/api/character/2"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[2], Is.EqualTo("https://rickandmortyapi.com/api/character/35"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[3], Is.EqualTo("https://rickandmortyapi.com/api/character/38"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[4], Is.EqualTo("https://rickandmortyapi.com/api/character/62"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[5], Is.EqualTo("https://rickandmortyapi.com/api/character/92"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[6], Is.EqualTo("https://rickandmortyapi.com/api/character/127"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[7], Is.EqualTo("https://rickandmortyapi.com/api/character/144"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[8], Is.EqualTo("https://rickandmortyapi.com/api/character/158"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[9], Is.EqualTo("https://rickandmortyapi.com/api/character/175"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[10], Is.EqualTo("https://rickandmortyapi.com/api/character/179"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[11], Is.EqualTo("https://rickandmortyapi.com/api/character/181"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[12], Is.EqualTo("https://rickandmortyapi.com/api/character/239"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[13], Is.EqualTo("https://rickandmortyapi.com/api/character/249"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[14], Is.EqualTo("https://rickandmortyapi.com/api/character/271"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[15], Is.EqualTo("https://rickandmortyapi.com/api/character/338"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[16], Is.EqualTo("https://rickandmortyapi.com/api/character/394"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[17], Is.EqualTo("https://rickandmortyapi.com/api/character/395"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.characters[18], Is.EqualTo("https://rickandmortyapi.com/api/character/435"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.url, Is.EqualTo("https://rickandmortyapi.com/api/episode/1"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.created.ToString, Is.EqualTo("10/11/2017 12:56:33"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.error, Is.Null);
        }

        [Test]
        [Category("Sad")]
        public async Task StatusCodeIs500()
        {
            await _singleEpisodeService.MakeSingleEpisodeRequest("a");
            Assert.That(_singleEpisodeService.CallManager.StatusCode, Is.EqualTo(500));
        }

        [Test]
        [Category("Sad")]
        public async Task ResponseIsNull()
        {
            await _singleEpisodeService.MakeSingleEpisodeRequest("a");
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.name, Is.Null);
        }

        [Test]
        [Category("Sad")]
        public async Task GivenAWrongIdInput_ReturnsError_ToProvideAnId()
        {
            await _singleEpisodeService.MakeSingleEpisodeRequest("a");
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.error, Is.EqualTo("Hey! you must provide an id"));
        }
    }
}
