using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using APIClient.RickAndMortyIOService.Service;

namespace APIClient.Tests
{
    class WhenTheCharacterServiceIsCalled_WithAnArrayOfIds
    {
        ListOfCharactersService _listOfCharactersService;
        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _listOfCharactersService = new ListOfCharactersService();
            await _listOfCharactersService.MakeRequestAsync(new int[] { 1, 2, 3 });
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
        public void ResponseContains_RickSanchez()
        {
            Assert.That(_listOfCharactersService.Json_response[0]["name"].ToString(), Is.EqualTo("Rick Sanchez"));
        }

        [Test]
        [Category("Happy")]
        public void Response_ReturnsCorrectResult()
        {
            Assert.That(_listOfCharactersService.Json_response[0]["name"].ToString(), Is.EqualTo("Rick Sanchez"));
            Assert.That(_listOfCharactersService.Json_response[1]["name"].ToString(), Is.EqualTo("Morty Smith"));
            Assert.That(_listOfCharactersService.Json_response[2]["name"].ToString(), Is.EqualTo("Summer Smith"));
        }
    }
}
