using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorRepairCAMPUS.View;

public class VehicleMenu
{
    
    public int Menu(){
        Console.Clear();
        Console.WriteLine("Menu de Opciones");
        Console.WriteLine("1. Customers");
        Console.WriteLine("2. Vehicles");
        Console.WriteLine("3. Employees");
        Console.WriteLine("4. Exit");
        
        return int.Parse(Console.ReadLine());
    }
}