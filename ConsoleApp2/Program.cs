//tür dönüşümleri 
byte byteSayi = 255;
int intSayi = 1256;

Console.WriteLine(byteSayi.GetType());
Console.WriteLine(intSayi.GetType());
Console.WriteLine("byteSayi" + byteSayi);
Console.WriteLine("intSayi" + intSayi);
Console.ReadKey();

Console.Write("Sayi giriniz: ");
String str = Console.ReadLine();
Console.WriteLine(str);

/*
checked
{
    byteSayi = (byte) intSayi; //hata verir
}
*/
/*
int strTwoSayi = int.Parse(str);
Console.WriteLine("str2int: " +strTwoSayi);

Console.Write("sayi1 girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("sayi2 girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());    

Console.WriteLine("sayi1+sayi2= "+(sayi2 + sayi1));
*/

//Rastegele sayı olustur

Random random = new Random();
int sayi1 = random.Next(100); //[0,100)
Console.WriteLine("rastegele: "+ sayi1);

double sayi2 = random.NextDouble(); //[0,1)
Console.WriteLine("rastegele: " + sayi2);
Console.ReadKey();









