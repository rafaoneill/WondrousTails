using AetherCurrents.Controllers;
using AetherCurrents.Database.Entities;
using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AetherCurrents.Tests
{
    /// <summary>
    /// Set of tests for the JournalController
    /// </summary>
    public class JournalControllerTest : IDisposable
    {
        private JournalController _controller;
        private AetherCurrentsContext _context;
        private Fixture _fixture;

        /// <summary>
        /// Test setup
        /// </summary>
        public JournalControllerTest()
        {
            _fixture = new Fixture();
            var options = new DbContextOptionsBuilder<AetherCurrentsContext>()
                .UseInMemoryDatabase(databaseName: "journal").Options;
            _context = new AetherCurrentsContext(options);
            _controller = new JournalController(_context);
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
        /// Tests that the GetJournalSections method returns data
        /// </summary>
        [Trait("Area", "Api")]
        [Trait("Domain", "Controller")]
        [Trait("Controller", "Journal")]
        [Fact]
        public void GetJournalSections_WhenAvailable_ReturnsData()
        {
            var sections = _fixture.CreateMany<JournalSection>(3);
            _context.JournalSection.AddRange(sections);
            _context.SaveChanges();

            var result = _controller.GetJournalSections().Result as OkObjectResult;
            var data = result.Value as IEnumerable<JournalSection>;

            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(3, data.Count());
            Assert.Equal(sections, data);
        }

        /// <summary>
        /// Tests that the GetJournalSections method returns NoContent
        /// </summary>
        [Trait("Area", "Api")]
        [Trait("Domain", "Controller")]
        [Trait("Controller", "Journal")]
        [Fact]
        public void GetJournalSections_WhenNotAvailable_ReturnsNoContent()
        {
            var result = _controller.GetJournalSections().Result;

            Assert.IsType<NoContentResult>(result);
        }

        /// <summary>
        /// Tests that the GetJournalSection method returns data
        /// </summary>
        [Trait("Area", "Api")]
        [Trait("Domain", "Controller")]
        [Trait("Controller", "Journal")]
        [Fact]
        public void GetJournalSection_WhenAvailable_ReturnsData()
        {
            var section = _fixture.Create<JournalSection>();
            _context.JournalSection.Add(section);
            _context.SaveChanges();

            var result = _controller.GetJournalSection(section.Id).Result;
            
            Assert.IsType<OkObjectResult>(result);
            var data = (result as OkObjectResult).Value;
            Assert.Equal(section, data);
        }

        /// <summary>
        /// Tests that the GetJournalSection method returns NotFound
        /// </summary>
        [Trait("Area", "Api")]
        [Trait("Domain", "Controller")]
        [Trait("Controller", "Journal")]
        [Fact]
        public void GetJournalSection_WhenNotAvailable_ReturnsNotFound()
        {
            var result = _controller.GetJournalSection(1).Result;

            Assert.IsType<NotFoundResult>(result);
        }

        /// <summary>
        /// Tests that the GetJournalCategoriesInSection method returns data
        /// </summary>
        [Trait("Area", "Api")]
        [Trait("Domain", "Controller")]
        [Trait("Controller", "Journal")]
        [Fact]
        public void GetJournalCategoriesInSection_WhenAvailable_ReturnsData()
        {
            var category = _fixture.Create<JournalCategory>();
            _context.JournalCategory.Add(category);
            _context.SaveChanges();

            var result = _controller.GetJournalCategoriesInSection(category.JournalSectionId).Result;
            
            Assert.IsType<OkObjectResult>(result);
            var data = (result as OkObjectResult).Value as List<JournalCategory>;
            Assert.Single(data);
            Assert.Equal(category, data.ElementAt(0));
        }

        /// <summary>
        /// Tests that the GetJournalCategoriesInSection method returns NotContent
        /// </summary>
        [Trait("Area", "Api")]
        [Trait("Domain", "Controller")]
        [Trait("Controller", "Journal")]
        [Fact]
        public void GetJournalCategoriesInSection_WhenNotAvailable_ReturnsNoContent()
        {
            var result = _controller.GetJournalCategoriesInSection(1).Result;
            
            Assert.IsType<NoContentResult>(result);
        }

    }
}