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
            await _listOfCharactersService.MakeRequestAsync(new int[] { 1, 2, 3});
        }

        [Test]
        [Category("Happy")]
        public void StatusCodeIs200()
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
