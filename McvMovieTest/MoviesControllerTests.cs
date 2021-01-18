using Moq;
using MvcMovie.Data;
using NUnit.Framework;

namespace McvMovieTest
{
    public class MoviesControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            var mvcMovieContextMock = new Mock<MvcMovieContext>();

            Assert.Pass();
        }
    }
}