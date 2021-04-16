using JellyFish.Business.Models;
using NUnit.Framework;
using System;

namespace JellyFish.Business.Services
{
    public class JellyFishServiceTest
    {
        private JellyFishService _service;

        [SetUp]
        public void Setup()
        {
            _service = new JellyFishService();
        }
        [Test]
        public void RequestPropertiesMustBeTheSameResponseProperties()
        {
            var request = new JellyFishCreateRequest()
            {
                Name = "My First Jelly Fish",
                Slug = "my-first-jelly-fish"
            };
            JellyFishCreateResponse response = _service.Create(request);
            Assert.AreEqual(response.Name, request.Name);
            Assert.AreEqual(response.Slug, request.Slug);
        }
        [Test]
        public void CreateMethodMustThrowArgumentNullExceptionIfRequestNull()
        {
            Assert.Throws<ArgumentNullException>(new TestDelegate(() => _service.Create(null)));
        }
        
    }
}
