using APIClient.RickAndMortyIOService.HTTPManager;
using APIClient.RickAndMortyIOService.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.Tests
{
    class WhenTheSingleCharacterServiceIsCalled_WithOneID
    {
        SingleCharacterService _singleCharactersService;
        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singleCharactersService = new SingleCharacterService();
            await _singleCharactersService.MakeRequestAsync(1);
        }

        [Test]
        [Category("Happy")]
        public void StatusCodeIs200()
        {
            Assert.That(_singleCharactersService.CallManager.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Category("Happy")]
        public void ResponseIsNotNull()
        {
            Assert.That(_singleCharactersService.SingleCharactersDTO.Response, Is.Not.Null);
        }

        [Test]
        [Category("Happy")]
        public void ResponseId1_CharacterDetailsAreCorrect()
        {
            Assert.That(_singleCharactersService.SingleCharactersDTO.Response.name, Is.EqualTo("Rick Sanchez"));
            Assert.That(_singleCharactersService.SingleCharactersDTO.Response.status, Is.EqualTo("Alive"));
            Assert.That(_singleCharactersService.SingleCharactersDTO.Response.origin.url, Is.EqualTo("https://rickandmortyapi.com/api/location/1"));
            Assert.That(_singleCharactersService.SingleCharactersDTO.Response.location.url, Is.EqualTo("https://rickandmortyapi.com/api/location/20"));
            Assert.That(_singleCharactersService.SingleCharactersDTO.Response.episode[0], Is.EqualTo("https://rickandmortyapi.com/api/episode/1"));
        }

        [Test]
        [Category("Happy")]
        public void ResponseId1_CountsCorrectNumberOfEpisode()
        {
            Assert.That(_singleCharactersService.SingleCharactersDTO.Response.episode.Count<String>, Is.EqualTo(41));
        }
    }

    class WhenTheSingleCharacterServiceIsCalled_WithNegativeNumberInput
    {
        SingleCharacterService _singleCharactersService;
        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singleCharactersService = new SingleCharacterService();
            await _singleCharactersService.MakeRequestAsync(-5);
        }

        [Test]
        [Category("Sad")]
        public void StatusCodeIs404()
        {
            Assert.That(_singleCharactersService.CallManager.StatusCode, Is.EqualTo(404));
        }

        [Test]
        [Category("Sad")]
        public void ResponseIsNull()
        {
            Assert.That(_singleCharactersService.SingleCharactersDTO.Response.name, Is.Null);
        }
    }
}
