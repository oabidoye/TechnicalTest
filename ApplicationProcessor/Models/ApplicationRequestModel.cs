using System;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor.Models
{
    public class ApplicationRequestModel
    {
        public ApplicationRequestModel(string faculty, string courseCode, DateTime Startdate, string title, string firstName, string lastName, DateTime dateOfBirth, bool requiresVisa)
        {
            ApplicationId = new Guid();
            Faculty = faculty;
            CourseCode = courseCode;
            StartDate = Startdate;
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            RequiresVisa = requiresVisa;
            DateOfBirth = dateOfBirth;
        }

        public Guid ApplicationId { get; private set; }
        public string Faculty { get; private set; }
        public string CourseCode { get; private set; }
        public DateTime StartDate { get; private set; }
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public bool RequiresVisa { get; private set; }

        public DegreeGradeEnum DegreeGrade { get; set; }
        public DegreeSubjectEnum DegreeSubject { get; set; }
    }
}
