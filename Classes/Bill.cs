using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorRepairCAMPUS.Classes;
public class Bill
{
    public string Id {get;set;}
    public int IdServiceOrder {get;set;}
    public int ApprovalId {get;set;}
    public double Tax {get;set;}
    public int ManpowerPrice {get;set;}
    public DateTime Date{get;set;}

    public Bill (string id, int idServiceOrder, int approvalId, double tax, int manpowerPrice, DateTime date){
        this.Id = id;
        this.IdServiceOrder = idServiceOrder;
        this.ApprovalId = approvalId;
        this.Tax = tax;
        this.ManpowerPrice = manpowerPrice;
        this.Date = date;
    }
}
