using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorRepairCAMPUS.View;

public class ConsultMenu
{
    public int Menu(){
        Console.Clear();
        Console.WriteLine("Menu de Opciones");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Consult information");
        Console.WriteLine("3. Bruh");
        Console.WriteLine("4. Exit");
        
        return int.Parse(Console.ReadLine());
    }
}