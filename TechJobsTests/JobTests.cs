using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job testJob1;
        Job testJob2;
        Job testJob3;
        Job testJob4;
        [TestInitialize]
        public void StartingTestVariables()
        {
            testJob1 = new Job();
            testJob2 = new Job();
            testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(testJob1.Id, testJob2.Id -1);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsNotNull(testJob3.Name);
            Assert.IsNotNull(testJob3.EmployerName);
            Assert.IsNotNull(testJob3.EmployerLocation);
            Assert.IsNotNull(testJob3.JobType);
            Assert.IsNotNull(testJob3.JobCoreCompetency);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(testJob3.Equals(testJob4));
        }
    }
}
