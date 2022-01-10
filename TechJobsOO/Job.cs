using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) :this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            string jobName;
            string emp;
            string local;
            string positionType;
            string competence;

            if (this.Name == "") { jobName = "Data not available"; } else { jobName = this.Name; }
            if (this.EmployerName.ToString() == "") {  emp = "Data not available"; } else { emp = this.EmployerName.ToString(); }
            if (this.EmployerLocation.ToString() == "") { local = "Data not available"; } else { local = this.EmployerLocation.ToString(); }
            if (this.JobType.ToString() == "") { positionType = "Data not available"; } else { positionType = this.JobType.ToString(); }
            if (this.JobCoreCompetency.ToString() == "") { competence = "Data not available"; } else { competence = this.JobCoreCompetency.ToString(); }

            return Environment.NewLine + " ID: " + this.Id + Environment.NewLine
                +" NAME: " + jobName + Environment.NewLine
                + " Employer: " + emp + Environment.NewLine
                + " Location: " + local + Environment.NewLine
                + " Position: " + positionType + Environment.NewLine
                + " Core Competency: " + competence + Environment.NewLine;
        }
    }
}
