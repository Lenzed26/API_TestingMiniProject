using APIClient.RickAndMortyIOService.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.url, Is.EqualTo("https://rickandmortyapi.com/api/episode/1"));
            Assert.That(_singleEpisodeService.SingleEpisodeDTO.Response.created.ToString, Is.EqualTo("10/11/2017 12:56:33"));
        }
    }
}
