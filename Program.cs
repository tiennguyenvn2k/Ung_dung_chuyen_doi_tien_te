using System;
namespace dotnet_Ung_dung_chuyen_doi_tien_te;
class Program
{
    private static void Main(string[] args)
    {
        const int RATE = 23000;
        int tienUSD;
        Console.WriteLine("Moi nhap so tien (USD) : ");
        tienUSD = int.Parse(Console.ReadLine());
        Console.WriteLine("So tien " + tienUSD + " USD" +" quy doi ra VND la: " 
        + tienUSD*RATE +" VND");
    }
}