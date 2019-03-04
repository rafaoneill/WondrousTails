using AetherCurrents.Controllers;
using AetherCurrents.Database.Entities;
using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace AetherCurrents.Tests
{
    /// <summary>
    /// Set of tests for the QuestController
    /// </summary>
    public sealed class QuestControllerTest : IDisposable
    {
        private QuestController _controller;
        private AetherCurrentsContext _context;
        private Fixture _fixture;

        /// <summary>
        /// Test setup
        /// </summary>
        public QuestControllerTest()
        {
            _fixture = new Fixture();
            var options = new DbContextOptionsBuilder<AetherCurrentsContext>()
                .UseInMemoryDatabase(databaseName: "quest").Options;
            _context = new AetherCurrentsContext(options);
            _controller = new QuestController(_context);
        }

        /// <summary>
        /// Test teardown
        /// </summary>
        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        /// <summary>
        /// Tests that the Get method returns data
        /// </summary>
        [Trait("Area", "Api")]
        [Trait("Domain", "Controller")]
        [Trait("Controller", "Quest")]
        [Fact]
        public void Get_WhenDataAvailable_ReturnsData()
        {
            var quest = _fixture.Create<Quest>();
            _context.Quest.Add(quest);
            _context.SaveChanges();

            var results = _controller.Get(quest.Id).Result as OkObjectResult;

            Assert.IsType<OkObjectResult>(results);
            Assert.Equal(quest, results.Value);
        }

        /// <summary>
        /// Tests that the Get method returns NotFound
        /// </summary>
        [Trait("Area", "Api")]
        [Trait("Domain", "Controller")]
        [Trait("Controller", "Quest")]
        [Fact]
        public void Get_WhenNoDataAvailable_ReturnsNotFound()
        {
            var results = _controller.Get(1);

            Assert.IsType<NotFoundResult>(results.Result);
        }
    }
}