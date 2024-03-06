﻿namespace ADTTestProject
{
    public enum Gender { Male, Female };
    public class ClubMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
        }
    }
}
