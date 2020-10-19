using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace OBS.HRMS.Common.Models
{
    public class Employee
    {
        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }


        //public string Status { get; set; }

        public EmployeePersonal PersonalDetails { get; set; }
        public EmployeeContacts Contact { get; set; }
        public EmployeeJobDetails JobDetails { get; set; }
        public EmployeeLoginInfo LoginInfo { get; set; }


        //[BsonRepresentation(BsonType.ObjectId)]
        public List<string> Roles { get; set; }


        ////[BsonRepresentation(BsonType.ObjectId)]
        public List<string> Skills { get; set; }


        ////[BsonRepresentation(BsonType.ObjectId)]
        public List<string> ProjectDetails { get; set; }
    }

    public class EmployeePersonal
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public string Gender { get; set; }

        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public long? Phone { get; set; }
        public string Email { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string Token { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime? TokenExpiry { get; set; }
        public int? InvalidCount { get; set; }
        public bool? Status { get; set; }
        public string Skill { get; set; }
    }
    public class EmployeeContacts
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<string> Address { get; set; }
    }


    public class EmployeeJobDetails
    {
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfExit { get; set; }
        public List<EmployeeHistory> History { get; set; }
    }

    public class EmployeeHistory
    {
        public string Title { get; set; }
        public string BusinessUnit { get; set; }
        public string SubBusinessUnit { get; set; }
        public string Manager { get; set; }
    }

    public class EmployeeLoginInfo
    {
        public bool IsEmailConfirmed { get; set; }
        public bool IsPhoneNumberConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public bool FAEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string LockoutEnd { get; set; }
        public bool LockOutEnabled { get; set; }
    }
}
