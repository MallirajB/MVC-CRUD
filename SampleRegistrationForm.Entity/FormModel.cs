﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SampleRegistrationForm.Entity
{
    public partial class FormModel
    {
        public int User_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string User_Qualification { get; set; }
        public string User_Gender { get; set; }
        public long Phone_No { get; set; }
        public string User_Address { get; set; }
        public string User_Email { get; set; }
        public string User_Password { get; set; }
        public string Retype_Password { get; set; }
        public bool Is_Deleted { get; set; }
        public DateTime Created_TimeStamp { get; set; }
        public DateTime Updated_TimeStamp { get; set; }
    }
}