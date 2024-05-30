// See https://aka.ms/new-console-template for more information

//string
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

int c = a + b ;
Console.WriteLine(c);

int d = 2100000000; //max 32 bit
int e = 2100000000;
long f = (long)d + (long)e ; //need to convert to long for accept more than 32 bit
Console.WriteLine(f);

long gg = 210000000000000;
long hh = 210000000000000;
long ii = gg + hh;
Console.WriteLine(ii);

double aa = 21.2;
double bb = 22.3;
double cc = aa + bb ;
Console.WriteLine(cc);

float dd = 21.23F;
float ee = 22.3F;
float ff = dd + ee ;
Console.WriteLine(ff);