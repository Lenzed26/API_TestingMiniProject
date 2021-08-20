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
        public void StatusIs200()
        {
            Assert.That(_singleEpisodeService.CallManager.StatusCode, Is.EqualTo(200));
        }
    }
}
