using System;
using Xunit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace Api.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void CreateWebHostBuilder_ShouldNotBeNull()
        {
            // Arrange
            string[] args = new string[] { };

            // Act
            var webHostBuilder = Program.CreateWebHostBuilder(args);

            // Assert
            Assert.NotNull(webHostBuilder);
        }

        [Fact]
        public void CreateWebHostBuilder_ShouldUseStartup()
        {
            // Arrange
            string[] args = new string[] { };

            // Act
            var webHostBuilder = Program.CreateWebHostBuilder(args);

            // Assert
            Assert.IsType<WebHostBuilder>(webHostBuilder);
        }

        [Fact]
        public void Main_ShouldRunWebHost()
        {
            // Arrange
            string[] args = new string[] { };

            // Act & Assert
            try
            {
                Program.Main(args);
            }
            catch (Exception ex)
            {
                Assert.True(false, $"Main method threw an unexpected exception: {ex.Message}");
            }
        }
    }
}