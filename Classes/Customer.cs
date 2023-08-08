using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorRepairCAMPUS.Classes;

public class Customer:Person
{
    public DateTime RegisterDate {get;set;}

    public Customer (string id, string name, string lastname, int phoneNumber, string email, DateTime registerDate):base(id,name,lastname,phoneNumber,email){
        this.Id = id;
        this.Name = name;
        this.Lastname = lastname;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.RegisterDate = registerDate;
    }
}
