using System;


namespace ConsoleApp4
{
    class Passport
    {
        public string PassportNumber;
        public string FullName;
        public DateTime IssueDate;

        public Passport(string passportNumber, string fullName, DateTime issueDate)
        {
            if (string.IsNullOrWhiteSpace(passportNumber))
                throw new ArgumentException("Passport number cannot be empty or whitespace.", "passportNumber");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name cannot be empty or whitespace.", "fullName");

            if (issueDate > DateTime.Now)
                throw new ArgumentException("Issue date cannot be in the future.", "issueDate");

            PassportNumber = passportNumber;
            FullName = fullName;
            IssueDate = issueDate;
        }
    }
}
