using motorRepairCAMPUS.View;
using motorRepairCampus.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        MainMenu menu = new();
        int mainOption;
        do{
            mainOption = menu.Menu();

            switch (mainOption){
                case 1:
                    int optRegister;
                    do{

                    }while(optRegister!=4);
                    break;
                case 2:
                    Console.WriteLine("Working");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Working");
                    Console.ReadKey();
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }while(mainOption !=4);
    }
}