using Domain.Entities;
using NUnit.Framework;

namespace Domain.UnitTests
{
    [TestFixture]
    public class TodoTests
    {
        [Test]
        public void TestGetIsComplete()
        {
            var sut = new Todo();
            Assert.That(sut.IsComplete, Is.False);
        }
    }
}
