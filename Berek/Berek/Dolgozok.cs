namespace Berek;

internal class Dolgozok
{
    public string Nev { get; set; }
    public string Neme { get; set; }
    public string Reszleg { get; set; }
    public int MunkaViszonyKezdete { get; set; }
    public int Ber { get; set; }



    public Dolgozok(string sor) 
    {
    var v = sor.Split(";");
        Nev = v[0];
        Neme = v[1];
        Reszleg = v[2];
        MunkaViszonyKezdete = int.Parse(v[3]);
        Ber = int.Parse(v[4]);
    }

    public override string ToString()
    {
        return $"{Nev}, {Neme}, {Reszleg}, {MunkaViszonyKezdete}, {Ber}";
    }
}
