using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorRepairCAMPUS.Classes;
public class Person
{
    public string Id {get;set;}
    public string Name {get;set;}
    public string Lastname {get;set;}
    public int PhoneNumber {get;set;}
    public string Email {get;set;}

    public Person (string id, string name, string lastname, int phoneNumber, string email ){
        this.Id = id;
        this.Name = name;
        this.Lastname = lastname;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
    }

}
