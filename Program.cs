// See https://aka.ms/new-console-template for more information
Console.Title = "Hod Kostkou"; 
Console.WindowHeight = 40;

Random numberGen = new Random(); 

int hod = 0;
int pokusy = 0;
Console.WriteLine("Jaké číslo odhadujes");
int odhadCislo = Convert.ToInt32(Console.ReadLine());
Console.Title = "Hod Kostkou";

Console.ForegroundColor = ConsoleColor.DarkRed;


while(odhadCislo < 1 || odhadCislo > 6){
    if(odhadCislo < 1){
    Console.WriteLine("pokud nechceš hádat tak vypni program");
    Console.WriteLine("Jaké číslo odhaduješ");
    odhadCislo = Convert.ToInt32(Console.ReadLine());
    }
    else if(odhadCislo > 6){
    Console.WriteLine("Zkusme to znova (kostka má 6 stěn)");
    Console.WriteLine("Jaké číslo odhaduješ");
    odhadCislo = Convert.ToInt32(Console.ReadLine());
    }
    else{
        Console.WriteLine("Co to je????");
        Console.WriteLine("Jaké číslo odhaduješ");
        odhadCislo = Convert.ToInt32(Console.ReadLine());
    }
}

//OLD CODE:
//while(odhadCislo < 1){
//   Console.WriteLine("pokud nechceš hádat tak vypni program");
// Console.WriteLine("Jaké číslo odhaduješ");
//   odhadCislo = Convert.ToInt32(Console.ReadLine());
//}
//while(odhadCislo > 6){
//    Console.WriteLine("Skusme to znova (kostka má 6 stěn)");
//    Console.WriteLine("Jaké číslo odhaduješ");
//    odhadCislo = Convert.ToInt32(Console.ReadLine());
//}



Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Hod kliknutím na enter");

while( hod != odhadCislo) {
    Console.ReadKey();

    hod = numberGen.Next(1, 7);
    Console.WriteLine("Padlo číslo " + hod);
    pokusy++;

}
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Trvalo ti to " + pokusy + " pokusů");

//čeká před koncem
Console.ReadKey();
