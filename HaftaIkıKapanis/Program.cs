// example 1
using System.Xml.Linq;

Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın?");
Console.WriteLine("");

//example 2
string name;
int age;
name = "sinan";
age = 34;
Console.WriteLine($"name değişkeni: {name} ve age değişkeni: {age}");
Console.WriteLine("");

//example 3
Random rnd = new Random();
int ranNum = rnd.Next();
Console.WriteLine(ranNum);
Console.WriteLine("");

//example 4
int remainderNumber = ranNum % 3;
Console.WriteLine(remainderNumber);
Console.WriteLine("");

//example 5
void IsOlderThan18()
{
    Console.Write("Yaşınızı giriniz:");
    int ageE5 = Convert.ToInt32(Console.ReadLine());
    if (ageE5 > 18)
    {
        Console.WriteLine("+");
    }
    else
    {
        Console.WriteLine("-");
    }
    Console.WriteLine("");
}

//example 6
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("");

//example 7
Console.Write("Değer 1 giriniz:");
string stringOne = Console.ReadLine();
Console.Write("Değer 2 giriniz:");
string stringTwo = Console.ReadLine();
string stringThree = stringOne;
stringOne = stringTwo;
stringTwo = stringThree;
Console.WriteLine("");

//example 8
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
Console.WriteLine("");

//example 9
int Addition(int num1, int num2)
{
    return num1 + num2;
}
Console.WriteLine("");

//example 10
string TrueOrFalse(bool state)
{
    if (state)
    {
        return ("true");
    }
    else
    {
        return ("false");
    }
}
Console.WriteLine("");

//example 11
int findOldest(int age1, int age2, int age3)
{
    if (age1 > age2 && age1 > age3)
    {
        return age1;
    }
    else if (age2 > age1 && age2 > age3)
    {
        return age2;
    }
    else
    {
        return age3;
    }
}
Console.WriteLine("");

//example 12
int FindMaxNum()
{
    Console.WriteLine("Sadece sayı giriniz ya da sonucu yazdırmak için y tuşuna basınız...");
    int max = 0;
    bool loop = true;
    do
    {
        Console.WriteLine("Sayı:");
        string input = Console.ReadLine();
        if (input == "y")
        {
            loop = false;
            break;
        }
        int inputNum = Convert.ToInt32(input);
        if (inputNum > max)
        {
            max = inputNum;
        }
    }
    while (loop == true);
    Console.WriteLine($"En büyük sayı: {max}");
    return max;
}
//FindMaxNum();
Console.WriteLine("");

//example 13
void changeNameOrder()
{
    Console.WriteLine("İsim1:");
    string name1 = Console.ReadLine();
    Console.WriteLine("İsim2:");
    string name2 = Console.ReadLine();
    string name3 = name1;
    name1 = name2;
    name2 = name3;
    Console.WriteLine($"İsimlerin sırası değişti böylece ilk isim {name1} ve ikinci isim {name2} oldu");
}
Console.WriteLine("");

//example 14
bool OddOrEven()
{
    bool odd = false;
    Console.WriteLine("Sayı giriniz:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 != 0)
    {
        odd = true;
    }
    return odd;
}
Console.WriteLine("");

//example 15
void CalcDist()
{
    Console.WriteLine("Hızınızı giriniz:");
    int speed = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Bu hızla kaç dakika gittiğinizi giriniz:");
    int time = Convert.ToInt32(Console.ReadLine());
    int dist = speed * (time / 60);
    Console.WriteLine($"Gidilen mesafe {dist} kilometredir");
}
Console.WriteLine("");

//example 16
void CalcArea()
{
    Console.WriteLine("Dairenin yarıçapını giriniz:");
    int r = Convert.ToInt32(Console.ReadLine());
    double area = 3.1415926535897931 * r * r;
    Console.WriteLine($"Daire alanı {area} cm karedir");
}
Console.WriteLine("");

//example 17
string sentence = "Zaman bir GeRi SayIm";
string allUpper = sentence.ToUpper();
string allLower = sentence.ToLower();
Console.WriteLine($"Hepsi büyük harfle: {allUpper} ve hepsi küçük harfle: {allLower}");
Console.WriteLine("");

//example 18
string greet = "    Selamlar   ";
greet = greet.Trim();
Console.WriteLine("");






