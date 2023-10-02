using System.Security.Cryptography.X509Certificates;

namespace GrupparbetePolisen1984;

public class Uttryckingar
{
    static void Main(string[] args)
    { 
        Console.WriteLine("1: Registrering av uttryckningar \n 2: Rapporter \n 3:"); //bara kola om det fungarer 
        int val; //test
        switch(val)
        {

            //Console.WriteLine("1: Registrering av uttryckningar \n 2: Rapporter \n 3:");

            case 1:

                Console.WriteLine("Ange typ av brott:");
                string Typ = Console.ReadLine(); 

                Console.WriteLine("Ange plats:");
                string Plats = Console.ReadLine(); 

                Console.WriteLine("Ange tid:");
                double Tid = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ange vilka poliser som deltog:");
                string Poliser = Console.ReadLine(); 
                
                Console.WriteLine(Typ + "\n" + Plats + "\n" + Tid + "\n" + Poliser);
                break;

            case 2:

                Console.WriteLine("Reort nummer:");
                int Reportnumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Date:");
                double date = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Police sation:");
                string policeStation = Console.ReadLine();

                Console.WriteLine(Reportnumber + )

                

    
        }
    }
}
