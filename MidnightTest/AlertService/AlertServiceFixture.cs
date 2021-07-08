using Midnight;
using System;

namespace MidnightTest
{
    public class AlertServiceFixture : IDisposable
    {
        public readonly AlertService alertService;
        public Guid guidForTest;

        public AlertServiceFixture()
        {
            var alert = new AlertDAO();
            alertService = new AlertService(alert);

            guidForTest = alertService.RaiseAlert();
        }

        public void Dispose(){}
    }
}
