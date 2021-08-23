using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using APIClient.RickAndMortyIOService.Service;

namespace APIClient.Tests
{
    class WhenTheBulkCharacterServiceIsCalled
    {
        ListOfCharactersService _listOfCharactersService;
        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _listOfCharactersService = new ListOfCharactersService();
            await _listOfCharactersService.MakeRequestAsync();
        }

        [Test]
        [Category("Happy")]
        public void StatusCodeIs200()
        {
            Assert.That(_listOfCharactersService.CallManager.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Category("Happy")]
        public void ResponseIsNotNull()
        {
            Assert.That(_listOfCharactersService.Json_response.ToString(), Is.Not.Null);
        }

        [Test]
        [Category("Happy")]
        public void ResponseId1_ContainsRickSanchez()
        {
            Assert.That(_listOfCharactersService.ListOfCharactersDTO.Response.results[0].id, Is.EqualTo(1));
            Assert.That(_listOfCharactersService.ListOfCharactersDTO.Response.results[0].name, Is.EqualTo("Rick Sanchez"));

        }

        [Test]
        [Category("Happy")]
        public void Response_ReturnsCorrectResultCount()
        {
            Assert.That(_listOfCharactersService.ListOfCharactersDTO.Response.info.count, Is.EqualTo(671));
            Assert.That(_listOfCharactersService.ListOfCharactersDTO.Response.info.pages, Is.EqualTo(34)); //JSON response is too long so it is split up into 34 pages
        }


    }
}
