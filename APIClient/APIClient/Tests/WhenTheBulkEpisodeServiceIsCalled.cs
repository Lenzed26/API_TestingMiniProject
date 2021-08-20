using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIClient.RickAndMortyIOService.Service;
using NUnit.Framework;

namespace APIClient.Tests
{
    class WhenTheBulkEpisodeServiceIsCalled
    {
        private ListOfEpisodesService _listOfEpisodesService;
        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _listOfEpisodesService = new ListOfEpisodesService();
            await _listOfEpisodesService.MakeBulkEpisodeRequest();
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
        [Category("Sad")]
        public void Response_ReturnsPreviousAsNull()
        {
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.info.prev, Is.Null);
        }

        [Test]
        [Category("Happy")]
        public void Response_ReturnsResults()
        {
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].id, Is.EqualTo(1));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].name, Is.EqualTo("Pilot"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].air_date, Is.EqualTo("December 2, 2013"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].episode, Is.EqualTo("S01E01"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].url, Is.EqualTo("https://rickandmortyapi.com/api/episode/1"));
            Assert.That(_listOfEpisodesService.ListOfEpisodesDTO.Response.results[0].created, Is.EqualTo(DateTime.Parse("2017-11-10T12:56:33.798Z")));
        }
    }
}
