using System;
using System.Threading.Tasks;
using APIClient.RickAndMortyIOService.Service;
using NUnit.Framework;

namespace APIClient.Tests
{
    class WhenTheBulkEpisodeServiceIsCalled
    {
        private ListOfEpisodesService _listOfEpisodesService;
        [SetUp]
        public async Task SetUp()
        {
            _listOfEpisodesService = new ListOfEpisodesService();
            await _listOfEpisodesService.MakeBulkEpisodeRequest("episode");
        }

        [Test]
        [Category("Happy")]
        public void StatusCodeIs200()
        {
            Assert.That(_listOfEpisodesService.CallManager.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Category("Happy")]
        public void ResponseIsNotNull()
        {
            Assert.That(_listOfEpisodesService.Json_response.ToString(), Is.Not.Null);
        }

        [Test]
        [Category("Happy")]
        public void ResponseContains_FortyOneResults()
        {
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.info.count, Is.EqualTo(41));
        }

        [Test]
        [Category("Happy")]
        public void Response_ReturnsCorrectNumberOfPages()
        {
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.info.pages, Is.EqualTo(3));
        }

        [Test]
        [Category("Happy")]
        public void Response_ReturnsCorrectNextUrl()
        {
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.info.next.ToString, Is.EqualTo("https://rickandmortyapi.com/api/episode?page=2"));
        }

        [Test]
        [Category("Happy")]
        public void Response_ReturnsResults()
        {
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].id, Is.EqualTo(1));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].name, Is.EqualTo("Pilot"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].air_date, Is.EqualTo("December 2, 2013"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].episode, Is.EqualTo("S01E01"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].episode, Is.EqualTo("S01E01"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[0], Is.EqualTo("https://rickandmortyapi.com/api/character/1"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[1], Is.EqualTo("https://rickandmortyapi.com/api/character/2"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[2], Is.EqualTo("https://rickandmortyapi.com/api/character/35"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[3], Is.EqualTo("https://rickandmortyapi.com/api/character/38"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[4], Is.EqualTo("https://rickandmortyapi.com/api/character/62"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[5], Is.EqualTo("https://rickandmortyapi.com/api/character/92"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[6], Is.EqualTo("https://rickandmortyapi.com/api/character/127"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[7], Is.EqualTo("https://rickandmortyapi.com/api/character/144"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[8], Is.EqualTo("https://rickandmortyapi.com/api/character/158"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[9], Is.EqualTo("https://rickandmortyapi.com/api/character/175"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[10], Is.EqualTo("https://rickandmortyapi.com/api/character/179"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[11], Is.EqualTo("https://rickandmortyapi.com/api/character/181"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[12], Is.EqualTo("https://rickandmortyapi.com/api/character/239"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[13], Is.EqualTo("https://rickandmortyapi.com/api/character/249"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[14], Is.EqualTo("https://rickandmortyapi.com/api/character/271"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[15], Is.EqualTo("https://rickandmortyapi.com/api/character/338"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[16], Is.EqualTo("https://rickandmortyapi.com/api/character/394"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[17], Is.EqualTo("https://rickandmortyapi.com/api/character/395"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].characters[18], Is.EqualTo("https://rickandmortyapi.com/api/character/435"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].url, Is.EqualTo("https://rickandmortyapi.com/api/episode/1"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].created, Is.EqualTo(DateTime.Parse("2017-11-10T12:56:33.798Z")));
        }

        [Test]
        [Category("Sad")]
        public void Response_ReturnsPreviousAsNull()
        {
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.info.prev, Is.Null);
        }

        [Test]
        [Category("Sad")]
        public async Task StatusCodeIs404()
        {
            await _listOfEpisodesService.MakeBulkEpisodeRequest("anything");
            Assert.That(_listOfEpisodesService.CallManager.StatusCode, Is.EqualTo(404));
        }

        [Test]
        [Category("Sad")]
        public async Task GivenAWrongHTTPInput_ReturnsError_ThereIsNothingHere()
        {
            await _listOfEpisodesService.MakeBulkEpisodeRequest("a");
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.error, Is.EqualTo("There is nothing here."));
        }
    }
}
