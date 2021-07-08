using Midnight;
using Xunit;
using FluentAssertions;
using System;

namespace MidnightTest
{
    public class AlertServiceTest : IClassFixture<AlertServiceFixture>
    {
        private readonly AlertServiceFixture _alertServiceFixture;

        public AlertServiceTest(AlertServiceFixture alertServiceFixture)
        {
            _alertServiceFixture = alertServiceFixture;
        }

        [Fact]
        public void ShouldReturnTrueIsObjectImplementsIAlertDAO()
        {
            typeof(IAlertDAO).IsAssignableFrom(typeof(AlertDAO)).Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnGuidToInvokeRaiseAlertMethod()
        {
            var result = _alertServiceFixture.alertService.RaiseAlert();
            var resultType = result.GetType();
            resultType.FullName.Should().Be("System.Guid");
        }

        [Fact]
        public void ShouldReturnDateTimeToInvokeGetAlertTimeMethod()
        {
            var result = _alertServiceFixture.alertService.GetAlertTime(_alertServiceFixture.guidForTest);
            var resultType = result.GetType();
            resultType.FullName.Should().Be("System.DateTime");
        }
    }
}
