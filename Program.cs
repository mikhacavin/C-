// See https://aka.ms/new-console-template for more information

//string
//note : string is immutable
Console.WriteLine("---------------String---------------");
string initial = "Mom";
Console.WriteLine($"Hello, {initial}!");

//replace var value
initial = "I'm still ur Mom";
Console.WriteLine($"Hello, {initial}!");

//replace string 
initial = initial.Replace("Mom", "Daddy");


Console.WriteLine(initial.Contains("Daddy"));
Console.WriteLine(initial.ToUpper());
Console.WriteLine(initial.StartsWith("I'm "));


//number
Console.WriteLine("---------------Number---------------");
int a = 21;
int b = 20;

int c = a + b;
Console.WriteLine(c);

int d = 2100000000; //max 32 bit
int e = 2100000000;
long f = (long)d + (long)e; //need to convert to long for accept more than 32 bit
Console.WriteLine(f);

long gg = 210000000000000;
long hh = 210000000000000;
long ii = gg + hh;
Console.WriteLine(ii);

double aa = 21.2;
double bb = 22.3;
double cc = aa + bb;
Console.WriteLine(cc);

float dd = 21.23F;
float ee = 22.3F;
float ff = dd + ee;
Console.WriteLine(ff);

decimal jj = 42.1M;
decimal kk = 32.3M;
decimal ll = jj + kk;
Console.WriteLine(ll);

//brancing ids, conditional logic
int ab = 5;
int bc = 6;
int cd = ab + bc;
if (cd > 10)
{
    Console.WriteLine("the answer is greater than 10");
}

bool MyTest = cd > 9;
if (MyTest)
{
    Console.WriteLine("the answer is greater than 10 ~");
}
else
{
    Console.WriteLine("the answer is les than 10 ~");
}

if ((ab + bc + cd > 10) && (ab == bc))
{
    Console.WriteLine("pernyataan pertama benar");
    Console.WriteLine("dan pernyataan kedua benar");
}
else
{
    Console.WriteLine("pernyataan pertama benar");
    Console.WriteLine("dan pernyataan kedua salah maka pesan ini muncul");
}

if ((ab + bc + cd > 10) || (ab == bc))
{
    Console.WriteLine("pernyataan pertama benar maka pesan ini muncul");
    Console.WriteLine("dan pernyataan kedua salah namun karena pernyataan pertama benar, maka pesan ini juga muncul");
}
else
{
    Console.WriteLine("pernyataan pertama salah");
    Console.WriteLine("dan  pernyataan kedua salah");
}

//brancing while  loops
int counter = 0;

counter++;
Console.WriteLine(counter);

counter++;
Console.WriteLine(counter);

counter++;
Console.WriteLine(counter);

int number = 0;
while (number < 5)
{
    Console.WriteLine($"ini operation while {number}");
    number++;
}


do
{
    Console.WriteLine($"ini operation do while {number}");
    number++;
} while (number < 10);


//for loops
for (
    int i = 0; //initialise
     i < 5; //conditional
     i++) //iteration
{
    //do the thing
    if (i == 3)
    {
        Console.WriteLine(i);
    }
}

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}


//list T and Collection of Data
// <T> -> means type. the type of data in list of objects
var names = new List<string>{
    "mikha",
    "cavin",
    "arthir"
};

names.Add("Imanuel");
names.Add("Imanuel lagi");
names.Add("Imanuel lagi lagi");


foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine(names[4]);
// Console.WriteLine(names[names.Count - 1]);
//get the data from 1 on the bnack, or get the data from first on the last



//arrays, lists, indexing, and foreach
Console.WriteLine(names[^1]);

foreach (var name in names[2..4]) // akan menampilkan data di index ke 2 hingga 4 (tapi 4 tidak ikut di index)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


var students = new string[] { "nita", "lisa", "denis" };

students = [.. students, "dikon"];


foreach (var student in students)
{
    Console.WriteLine($"Hello {student.ToUpper()}!");
}


//sorting and searching lists
var kids = new List<string> { "mikha", "cavin", "arthir" };
kids.Sort();

foreach (var kid in kids)
{
    Console.WriteLine($"Hello {kid.ToUpper()}!");
}

