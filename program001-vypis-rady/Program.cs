string again = "a";
//.ToLower() převede vstup na malá písmena, takže program bude reagovat na "A" i "a"
while(again?.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Výpis řady ********************");
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Kristýna Húsková ***************");
    Console.WriteLine("************************************************");

//Vstup počáteční hodnoty - špatné řešení
//Console.Write("Zadejte první číslo řady: ");
//int first = int.Parse(Console.ReadLine());

//Vstup počáteční hodnoty - správné řešení
Console.Write("Zadejte první číslo řady(celé číslo): ");
int first;
while(!int.TryParse(Console.ReadLine(), out first))
{
    Console.WriteLine("Nezadali jste celé číslo. Zadejte poslední číslo řady(celé číslo):");
}
//vstup koncové hodnoty-správné řešení
Console.Write("Zadejte poslední číslo řady(celé číslo): ");
int last;
while(!int.TryParse(Console.ReadLine(), out last))
{
    Console.WriteLine("Nezadali jste celé číslo. Zadejte poslední číslo řady(kladnécelé číslo):");
}
//vstup diference s kontrolou kladné hodnot
Console.Write("Zadejte diferenci řady(celé číslo): ");
int step;
while(!int.TryParse(Console.ReadLine(), out step) || step <= 0)
{
    Console.WriteLine("Nezadali jste kladné celé číslo. Zadejte diferenci řady(celé číslo):");
}

//rekapitulace zadaných hodnot
//Console.WriteLine();
Console.WriteLine("================================");
//Console.WriteLine($"První číslo: {first}");
//Console.WriteLine($"Poslední číslo: {last}");
//Console.WriteLine($"Diference: {step}");
//vypis zadanych hodnot do jednoho řádku
Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Driference(krok): {step}");
Console.WriteLine("================================");
Console.WriteLine();

//jadro algoritmu - výpis řady
Console.WriteLine("Výpis řady:");
if(first <= last)
    {
        int current = first;
        while(current <= last) {
            Console.Write($"{current}; ");
            current = current + step;
            //da se napsat i: current += step



        }

    }
    else
    {
      Console.WriteLine("Radu nelze vypsat!");
      Console.WriteLine("Prní číslo je větší než poslední číslo.");
      Console.WriteLine("Tento program umí vypisovat pouze vzestupnou řadu (od menšího k většímu)");

    }


    //Dotaz na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování stiskněte a. Následně stiskněte Enter.");
    Console.WriteLine("Jakoukoli jinou kláveso program ukončíte.");
    Console.WriteLine("Chcete spustit program znovu?");
    again = Console.ReadLine() ?? "";

}