using System.Runtime.InteropServices;
using Xunit;

namespace XUnitTests
{
    public class OSInformation
    {
        private bool InWindows = false;

        [SkippableFact]
        public void IsRunningOnLinux()
        {
            Skip.If(InWindows, "Linux test, skip if in Windows environment");
            Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Linux));
        }

        [SkippableFact]
        public void IsRunningOnWinodws()
        {
            Skip.IfNot(InWindows, "Windows test, skip if in Linux environment");
            Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
        }
    }
}
