//For-Loop

//Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdırır.

Console.WriteLine("Bir Sayi Giriniz: ");
int sayac = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    if (i % 2 == 1)
        Console.WriteLine(i);
}

//1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazıdırır.

int tekToplam = 0;
int ciftToplam = 0;
for (int i = 1; i <= 1000; i++)
{
    if (i % 2 == 1)
    {
        tekToplam += i;
    }
    else
        ciftToplam += i;
}
Console.WriteLine("Tek Toplam: " + tekToplam);
Console.WriteLine("Cift Toplam: " + ciftToplam);

//break, continue

for (int i = 1; i < 10; i++)
{
    if (i == 4)
        break;
    Console.WriteLine(i);
}

for (int i = 1; i < 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}