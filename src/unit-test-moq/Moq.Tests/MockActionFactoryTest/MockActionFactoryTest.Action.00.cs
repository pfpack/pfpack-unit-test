#nullable enable

using Moq;
using Xunit;

namespace PrimeFuncPack.UnitTest.Moq.Tests
{
    partial class MockActionFactoryTest
    {
        [Fact]
        public void CreateMockAction_00_ThenInvoke_ExpectCallMockInvokeOnce()
        {
            var actualMock = MockActionFactory.CreateMockAction();

            actualMock.Object.Invoke();
            actualMock.Verify(f => f.Invoke(), Times.Once);
        }
    }
}