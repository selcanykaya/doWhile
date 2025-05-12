/*Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.
( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )*/

Console.Write("Bir limit belirtiniz:");
int limit = Convert.ToInt32(Console.ReadLine());
int sayac = 1;
while (sayac <= limit)
{
    Console.WriteLine($"{sayac}.Ben patikalıyım!");
    sayac++;
}
Console.WriteLine("--------------------------------------------------------");

int sayac2 = 1;
do
{
    Console.WriteLine($"{sayac2}.Ben patikalıyım!");
    sayac2++;
} while (sayac2 <= limit);

/*while döngüsünde ilk önce koşul kontrol edilir, eğer koşul sağlanıyorsa döngü başlar.
do while döngüsünde ise ilk önce döngü başlar, ardından koşul kontrol edilir. Bu nedenle en az bir kez çalışır.
örneğin kullanıcı 0 girerse while döngüsü hiç çalışmazken, do while döngüsü bir kez çalışır.*/