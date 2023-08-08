using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorRepairCAMPUS.Classes;

public class Replacement
{
    public string Id {get;set;}
    public int ApprovalId {get;set;}
    public int EmployeeId {get;set;}
    public string Reference {get;set;}
    public double UnitPrice { get; set; }
    public int Quantity {get;set;}
    public bool Status {get;set;}
    public DateTime AddedDate {get;set;}

    public Replacement(string id, int approvalId, int employeeId, string reference, double unitPrice, int quantity, bool status, DateTime addedDate){
        this.Id = id;
        this.ApprovalId = approvalId;
        this.Reference = reference;
        this.UnitPrice = unitPrice;
        this.Quantity = quantity;
        this.Status = status;
        this.AddedDate = addedDate;
    }
}
