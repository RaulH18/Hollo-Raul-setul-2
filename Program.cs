//1 set 2
/*Console.Write("Introduceti numarul de elemente in secventa: ");
int n = Convert.ToInt32(Console.ReadLine());

int numerePare = 0;

Console.Write("Introduceti secventa de numere: ");
for(int i = 0; i < n; i++)
{
    Console.Write($"Elementul {i + 1}: ");
    int nr = Convert.ToInt32(Console.ReadLine());

    if (nr % 2 == 0)
    {
        numerePare++;
    }
}
 

Console.WriteLine($"Numerele pare din secventa sunt: {numerePare} ");*/


// 2 set 2
/*Console.Write("Introduceti numatul de elemente in secventa: ");
int n = Convert.ToInt32(Console.ReadLine());

int nrPozitive = 0;
int nrNegative = 0;
int nrZero = 0;

Console.Write("Introduceti secventa de numare: ");
for(int i = 0; i < n; i++)
{
    Console.Write($"Elementul {i + 1}: ");
    int nr = Convert.ToInt32(Console.ReadLine());   

    if(nr < 0)
    {
        nrNegative++;
    }

    else if(nr == 0)
    {
        nrZero++;
    }

    else
    {
        nrPozitive++;
    }
}

Console.WriteLine($"Numere negative: {nrNegative}");
Console.WriteLine($"Numere care sunt zero: {nrZero}");
Console.WriteLine($"Numere pozitive: {nrPozitive}");*/



//3nset 2
/*Console.Write("Introduceti o valoare pentru n: ");
int n = Convert.ToInt32(Console.ReadLine());

int suma = 0;
int produs  = 0;    

for(int i = 1; i <= n; i++)
{
    suma += i;
    produs *= i;
}

Console.WriteLine($"Suma numerelor la 1 la {n} este: {suma}");
Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");
*/


/*static void Main()
{

    Console.WriteLine("Introduceti numarul de elemente in secventa: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] secventa = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Elementul {i}: ");
        secventa[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Introduceti numarul cautat: ");
    int a = Convert.ToInt32(Console.ReadLine());

    int pozitie = GasestePozitie(secventa, a);

    Console.WriteLine($"Numarul {a} se afla pe pozitia: {pozitie}");
}

static int GasestePozitie(int[] secventa, int a)
{
    for (int i = 0;i < secventa.Length; i++)
    {
        if (secventa[i] == a)
        {
            return i;
        }
    }
}   return -1;


using Syste m;
*/
/*class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul de elemente in secventa: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        Console.WriteLine("Introduceti secventa de numere:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Introduceti numarul cautat: ");
        int a = int.Parse(Console.ReadLine());
        
        int pozitie = GasestePozitie(secventa, a);

        Console.WriteLine($"Numarul {a} se afla pe pozitia: {pozitie}");
    }

    static int GasestePozitie(int[] secventa, int a)
    {
        for (int i = 0; i < secventa.Length; i++)
        {
            if (secventa[i] == a)
            {
                return i;
            }
        }
        return -1;
    }
}*/






/* int[] secventa = { 1, 2, 3, 4, 5, 6 };

 int numereEgaleCuPozitia = 0;

 for(int i = 0; i < secventa.Length;  i++)
 {
     if (secventa[i] == i)
     {
         numereEgaleCuPozitia++;
     }
 }

 Console.WriteLine($"Numere egale cu pozitia lor: {numereEgaleCuPozitia}");



*/

/*int[] secventa = { 1, 2, 3, 4, 5, 6 };

BubbleSort(secventa);

bool esteCrescatoare = VerificaOrdineCrescatoare(secventa);

if (esteCrescatoare)
{
    Console.WriteLine("Secventa este crescatoare.");
}
else
{
    Console.WriteLine("Secventa nu este crescatoare.");
}

static void BubbleSort(int[] array)
{
    int n = array.Length;
    bool swap;

    do
    {
        swap = false;

        for (int i = 1; i < n; i++)
        {
            if (array[i - 1] > array[i])
            {
                int temp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = temp;

                swap = true;
            }
        }

        n--;

    }while (swap);
}

static bool VerificaOrdineCrescatoare(int[] array)
{
    for(int i = 1 ; i < array.Length ; i++)
    {
        if (array[i - 1] > array[i])
        {
            return false;
        }
    }

    return true;
}*/



/*using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] secventa = { 5, 2, 8, 1, 3, 7 }; 

        if (secventa.Length > 0)
        {
            int minValue = secventa.Min();
            int maxValue = secventa.Max();

            Console.WriteLine($"Cea mai mica valoare: {minValue}");
            Console.WriteLine($"Cea mai mare valoare: {maxValue}");
        }
        else
        {
            Console.WriteLine("Secventa este goala.");
        }
    }
}
*/



//8 set 2

/*int n  = o;
int reultat = fibonacci(n);
Console.WriteLine($"Al {n}-lea numar din sirul lui fibonacci este: {reultat}");

static int fibonacci(int n)
{
    if (n <= 1)
        return n;

    int a = 0, b = 1, next = 0;

    for(int i = 2; i <= n; i++)
    {
        next = a + b;
           a = b;
           b = next;
    }

    return next;
}*/


/*int n = 0;
int[] secventa = { 1, 2, 3, 4, 5, 6 };

bool isMonotonic = IsMonotonic(secventa, n);

if (isMonotonic)
    Console.WriteLine("Secventa este monotona.");
else
    Console.WriteLine("Secventa nu este monotona.");

static bool IsMonotonic(int[] secventa, int n)
{
    bool monotonic = true;

    for(int i = 0; i < n; i++)
    {
        if (secventa[i] != secventa[i - 1])
        {
            monotonic = secventa[i] > secventa[i - 1];
            break;
        }
    }

    for(int i = 2; i < n; i++)
    {
        if ((secventa[i] > secventa[i - 1]) != monotonic)
        {
            monotonic = false;
            break;
        }
    }

    return monotonic;
}   
*/


/*int[] secventa = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
int rezultat = NumereEgaleConsecutiveDinSecventa(secventa);
Console.WriteLine($"Numarul maxim de numere consecutive egale este: {rezultat}");

static int NumereEgaleConsecutiveDinSecventa(int[] secventa)
{

    if (secventa.Length == 0)
        return 0;

    var grupuri = secventa.GroupBy(num => num);

    int lungimeMaxima = grupuri.Max(grup => grup.Count());

    return lungimeMaxima;
}*/


/*double[] secventa = { 2.23, 4.5, 7.25  };
double sumaInverselor = CalculSumaInverselor(secventa);
Console.WriteLine($"Suma inverselor este: {sumaInverselor}");

static double CalculSumaInverselor(double[] secventa)
{
    if(secventa.Length == 0)
        return 0;

    double sumaInverselor = 0;

    for(int i = 0; i < secventa.Length; i++)
    {
        sumaInverselor += 1 / secventa[i];
    }

    return sumaInverselor;
}   */

/*class Program
{
    static void Main()
    {
        int[] secventa = { 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 };
        int numarGrupuri = CalculNmarGrupuri(secventa);
        Console.WriteLine($"NUmarul de grupuri este: {numarGrupuri}");
    }

    static int CalculNmarGrupuri(int[] secventa)
    {
        if (secventa.Length == 0)
        {
            return 0;
        }

        int numarGrupuri = 0;

        for(int i = 0; i < secventa.Length; i++)
        {
            if (secventa[i] !=0)
            {
                numarGrupuri++;

                while(i < secventa.Length && secventa[i] != 0)
                {
                    i++;
                }
            }
        }
        
        return numarGrupuri;
    }
}*/

/*using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Exemplu de utilizare
        int[] sequence = { 4, 5, 6, 7, 1, 2, 3 };

        if (IsRotatedSortedSequence(sequence))
        {
            Console.WriteLine("Secventa este o secventa crescatoare rotita.");
        }
        else
        {
            Console.WriteLine("Secventa NU este o secventa crescatoare rotita.");
        }
    }

    static bool IsRotatedSortedSequence(int[] sequence)
    {
        int n = sequence.Length;

        // Identifica indexul minimului
        int minIndex = Array.IndexOf(sequence, sequence.Min());

        // Verifica daca secventa este in ordine crescatoare rotita
        for (int i = 0; i < n - 1; i++)
        {
            int current = (minIndex + i) % n;
            int next = (minIndex + i + 1) % n;

            if (sequence[current] > sequence[next])
            {
                return false;
            }
        }

        return true;
    }
}
*/

/*using System;

class program
{
    static void Main()
    {
        int[] sequence = { 2, 4, 7, 5, 1, 3 };

        if(IsRotatedSequence(sequence))
        {
            Console.WriteLine("Secventa este o secventa monotona rotita");
        }
        else
        {
            Console.WriteLine("Secventa nu este o secventa monoton rotita");
        }

        
    }

    static bool IsRotatedSequence(int[] sequence)
    {
        int n = sequence.Length;

        bool increasing = sequence[0] <= sequence[n - 1];

        for(int i = 1; i < n -1 ; i++)
        {
            int current = i;
            int next = i + 1;

            if(increasing && sequence[current] > sequence[next])
            {
                return false;
            }
            else if(!increasing && sequence[current] < sequence[next])
            {
                return false;
            }

            
        }

        return true;
    }
}*/


/*using System;

class Program
{
    static void Main()
    {
        int[] sequence = { 1, 2, 2, 3, 3, 5, 4, 4, 3 };

        if (IsBitonicSequence(sequence))
        {
            Console.WriteLine("Secventa este o una bitonica.");
        }
        else
        {
            Console.WriteLine("Seceventa nu este una bitonica.");
        }
    }

    static bool IsBitonicSequence(int[] sequence)
    {
        int n = sequence.Length;
        int i = 1;
        while(i < n && sequence[1] > sequence[i - 1])
        {
            i++;
        }

        int j = n - 2;
        while(j < n && sequence[i] > sequence[i - 1])
        {
            j--;
        }

        return i > 1 && j < n - 1 && i == j + 2;
        
    }
}*/

/*using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        int[] sequence = { 4, 5, 6, 7, 1, 2, 3 };

        if (IsRotatedBitonicSequence(sequence))
        {
            Console.WriteLine("Secventa este o secventa bitonica rotita.");
        }
        else
        {
            Console.WriteLine("Secventa NU este o secventa bitonica rotita.");
        }
    }

    static bool IsRotatedBitonicSequence(int[] sequence)
    {
        int n = sequence.Length;

        int turningPoint = FindTurningPointSequence(sequence, 0, n - 1);

        return turningPoint != -1 && sequence[turningPoint] == sequence[0] && sequence[turningPoint + 1] == sequence[n - 1];
    }

    static int FindTurningPointSequence(int[] sequence, int low, int high)
    {
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (sequence[mid] > sequence[mid + 1] && sequence[mid] > sequence[mid - 1])
            {
                return mid;
            }
            else if (sequence[mid] > sequence[mid + 1])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return -1;
       
    }   

}*/

//ultima setul 2

/*using System;

class Program
{
    static void Main()
    {
        // Exemplu de utilizare
        int[] sequence1 = { 0, 1, 0, 0, 1, 0, 1, 1 };
        int[] sequence2 = { 0, 0, 1, 1, 1, 0 };

        EvaluateParentheses(sequence1);
        EvaluateParentheses(sequence2);
    }
     
    static void EvaluateParentheses(int[] sequence)
    {
        int n = sequence.Length;

        int openCount = 0;
        int maxDepth = 0;
        int currentDepth = 0;

        for (int i = 0; i < n; i++)
        {
            if (sequence[i] == 0)
            {
                openCount++;
                currentDepth++;
            }
            else if (sequence[i] == 1)
            {
                if (openCount > 0)
                {
                    openCount--;
                    currentDepth--;
                }
                else
                {
                    Console.WriteLine("Secventa este incorecta.");
                    return;
                }
            }

            // Actualizează nivelul maxim de încuibare
            maxDepth = Math.Max(maxDepth, currentDepth);
        }
        for (int i = 0; i < n; i++)
        {
            if (sequence[i] == 0)
            {
                openCount++;
                currentDepth++;
            }
            else if (sequence[i] == 1)
            {
                if (openCount > 0)
                {
                    openCount--;
                    currentDepth--;
                }
                else
                {
                    Console.WriteLine("Secventa este incorecta.");
                    return;
                }
            }
            maxDepth = Math.Max(maxDepth, currentDepth);

        }

        if (openCount == 0)
        {
            Console.WriteLine($"Secventa este corecta. Nivelul maxim de incuibare este {maxDepth}.");
        }
        else
        {
            Console.WriteLine("Secventa este incorecta.");
        }
    }
}
*/