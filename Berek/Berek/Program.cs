using Berek;

var dolgozok = File.ReadAllLines(@"../../../src/berek2020.txt").Skip(1).Select(line => new Dolgozok(line)).ToList();

Console.WriteLine("3. feladat");
Console.WriteLine($"Az itt dolgozok adatainak száma {dolgozok.Count}");
Console.WriteLine("4.feladat");
var avgber2020 = dolgozok.Average(x => x.Ber);
Console.WriteLine($"átlag bérek 2020ban {avgber2020}");
Console.WriteLine("5.feladat");
Console.Write("Kérem adja meg a részleg nevét: ");
string keresettReszleg = Console.ReadLine();

var keresettReszlegDolgozok = dolgozok.Where(d => d.Reszleg.Equals(keresettReszleg, StringComparison.OrdinalIgnoreCase)).ToList();

if (keresettReszlegDolgozok.Any())
{
    Console.WriteLine($"A {keresettReszleg} részlegen dolgozók:");
    foreach (var dolgozo in keresettReszlegDolgozok)
    {
        Console.WriteLine(dolgozo);
    }


    var legnagyobbBerDolgozo = keresettReszlegDolgozok.OrderByDescending(d => d.Ber).First();
    Console.WriteLine($"A legnagyobb bérrel rendelkező dolgozó: {legnagyobbBerDolgozo}");
}
else
{
    Console.WriteLine($"A megadott részleg nem létezik a cégnél!");
}

Console.WriteLine("7. feladat");
var reszlegekStat = dolgozok
    .GroupBy(d => d.Reszleg)
    .Select(group => new { Reszleg = group.Key, DolgozokSzama = group.Count() })
    .OrderBy(stat => stat.Reszleg);  

Console.WriteLine("Részlegek statisztikája:");
foreach (var stat in reszlegekStat)
{
    Console.WriteLine($"{stat.Reszleg}: {stat.DolgozokSzama} fő");
}
// elkészítési idő 47 perc