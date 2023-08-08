using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorRepairCAMPUS.Classes;

public class Employee:Person
{
    public string Speciality {get;set;}
    public string Availability {get;set;}

    public Employee (string id, string name, string lastname, int phoneNumber, string email, string speciality, string availability):base(id,name,lastname,phoneNumber,email){
        this.Id = id;
        this.Name = name;
        this.Lastname = lastname;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.Speciality=speciality;
        this.Availability = availability;
    }
}
