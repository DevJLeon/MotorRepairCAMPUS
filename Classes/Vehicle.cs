using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorRepairCAMPUS.Classes;
public class Vehicle
{
    public string Vrn {get;set;}
    public string Model {get;set;}
    public string Brand {get;set;}
    public string Color {get;set;}
    public int Kilometrage {get;set;}
    public List<int> KmHistory{get;set;}

    public Vehicle (string vrn, string model, string brand, string color, int kilometrage, List<int>kmHistory){
        this.Vrn = vrn;
        this.Model = model;
        this.Brand = brand;
        this.Color = color;
        this.Kilometrage=kilometrage;
        this.KmHistory = kmHistory;
    }
}
