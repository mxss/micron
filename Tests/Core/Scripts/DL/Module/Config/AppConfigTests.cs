using Core.DL.Config;
using NUnit.Framework;
using Tests.Utils.DB;

namespace Tests.Core.Scripts.DL.Module.Config {
    [TestFixture]
    public class AppConfigTests {
        [SetUp]
        public void SetUp() {
            DbCleaner.TruncateAll();
        }

        [Test]
        public void GetConnectionString_WithData_Ok() {
            var config = AppConfig.Get();
            Assert.AreNotEqual(config.GetConnectionString(), "Host=;Username=;Password=;Database=");
        }
    }
}