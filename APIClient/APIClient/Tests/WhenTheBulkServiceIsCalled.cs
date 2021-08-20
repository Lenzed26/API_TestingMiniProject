using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIClient.RickAndMortyIOService.Service;
using NUnit.Framework;

namespace APIClient.Tests
{
    class WhenTheBulkServiceIsCalled
    {
        private ListOfEpisodesService _listOfEpisodesService;
        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _listOfEpisodesService = new ListOfEpisodesService();
            await _listOfEpisodesService.MakeBulkEpisodeRequest("1");
        }
    }
}
