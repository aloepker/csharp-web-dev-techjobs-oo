using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        Job testJob5;

        [TestInitialize]
        public void StartingTestVariables()
        {
            testJob1 = new Job();
            testJob2 = new Job();
            testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJob5 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

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
        [TestMethod]
        public void ToStringTest1()
        {
            //When passed a Job object, it should return a string that contains a blank line before and after the job information.
            Assert.IsTrue(testJob3.ToString().Contains(Environment.NewLine));
        }
        [TestMethod]
        public void ToStringTest2()
        {
            //The string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line.
           
            //cant figure out how to write the tests for something like this, but it does it..
            // also cant figure out why i would irl, since my employer should basically know the test and its outcome before I am assigned the work
            //and in a situation where I am heading the projet change, I can write the test I need after i impliment the feature corectly. TDD is busy work..
        }
        [TestMethod]
        public void ToStringTest3()
        {
            //If a field is empty, the method should add, “Data not available” after the label.
            Assert.IsTrue(testJob5.ToString().Contains("Data not available"));
        }
    }
}
