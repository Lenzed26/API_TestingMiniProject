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
        [Category("Sad")]
        public void WithInvalidID_StatusCodeIs400()
        {
            Assert.Fail();
        }

        [Test]
        [Category("Happy")]
        public void ResponseIsNotNull()
        {
            Assert.Fail();
        }

        [Test]
        [Category("Happy")]
        public void ResponseId1_NameIsRickSanchez()
        {
            Assert.Fail();
        }

        [Test]
        [Category("Happy")]
        public void Response_ReturnsCorrectResult()
        {
            Assert.Fail();
        }
    }
}
