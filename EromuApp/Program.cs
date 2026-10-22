using EromuApp;

List<Eromu> eromu = new List<Eromu>();
int hibasSorokSzama = 0;

foreach (File.ReadAllLines(eromuvek.txt).Skip(1))
{



    if (data[0] == "S" || data[0] == "Z")
    {
        hibasSorokSzama++;
        continue;
    }
}

string Eromu;
string Szelgenerator;
if (data[0] == "S")
{
    Eromu++;
}
if (data[0] == "Z")
{
    Szelgenerator++;
}


foreach (item eromu)
{
    Console.WriteLine($"Sikeresen beolvasott erőművek: {item} db");
}
Console.WriteLine($"Kiszűrt hibás sorok száma: {hibasSorokSzama} db");

Console.WriteLine();
Console.WriteLine("Beolvasott erőművek listája:");
foreach (itemek eromu)
{
    Console.WriteLine($"Erőmű {itemek.azonosito} | Kapacitás: {itemek.kapacitasKW} kW");
}

Console.WriteLine();
Console.WriteLine("Szélgenerátorok külön elemzése:");


Console.WriteLine();
Console.WriteLine($"Összesített energiatermelés 12 óra alatt: {Sum(e => e.NapiTermeles(12))}");
Console.WriteLine($"Erőmű példányok száma (static): 4 db");