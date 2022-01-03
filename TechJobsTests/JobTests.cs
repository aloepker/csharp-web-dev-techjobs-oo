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
        [TestMethod]
        public void ToStringTest1()
        {
            //When passed a Job object, it should return a string that contains a blank line before and after the job information.
            Assert.AreEqual(testJob3.Name.ToString(), " Product tester ");
        }
        [TestMethod]
        public void ToStringTest2()
        {
            //The string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line.
          
            //why the hell arnt we cycling an array? or making a different string for each part of the object?
        }
        [TestMethod]
        public void ToStringTest3()
        {
            //If a field is empty, the method should add, “Data not available” after the label.

            //this is painful, i cant figure out why this is used to print all parts of an object instead of a custom method
            //for code readability, I feel more confused why we are editing tostring.. we are not really to-stringing anything

            //i cant figure out why tdd tests are not already written by the person who wants you to solve that section of the code correctly, ie the employer
            //like wouldnt they know what the code needs to basically have pluggd in already for you to solve those problems? 
            //and the 1 test at a time thing is extra stupid..
            //this is like trying to use gps, but every 10% of the map has to be guessed 80% succesfully ("succesful enough to pass") before loading the next 10%
            //which feels stupid and undermining, I can look at the entire map before starting a journey, not have to backtrack wrong turns forceably by design
           

        }
    }
}
