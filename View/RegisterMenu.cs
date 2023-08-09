using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorRepairCAMPUS.View;
public class RegisterMenu
{
        public int Menu(){
        Console.Clear();
        Console.WriteLine("Menu de Opciones");
        Console.WriteLine("1. Register Customer");
        Console.WriteLine("2. Register Employee");
        Console.WriteLine("3. Register Vehicle");
        Console.WriteLine("4. Return to main menu");
        
        return int.Parse(Console.ReadLine());
    }
}
