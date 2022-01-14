using System;//luam din librarie System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamenteleProgramariiLaborator//numele proiectului
{
    class Program//clasa program in care se rezolva fiecare problema
    {
        static void p1()
        {
            double gradeC, gradeF, gradeK;
            Console.WriteLine("Va rugam alegeti dintre optiuni: ");
            Console.WriteLine("1-Schimbare grade Celsius in Farenheit: ");
            Console.WriteLine("2-Schimbare grade Celsius in Kelvin");
            Console.WriteLine("3-Schimbare grade Farenheit in Celsius");
            Console.WriteLine("4-Schimbare grade Farenheit in Kelvin");
            Console.WriteLine("5-Schimbare grade Kelvin in Celsius");
            Console.WriteLine("6-Schimbare grade Kelvin in Farenheit");
            Console.Write(">>> ");
            string input=Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Va rog introduceti gradele Celsius:\n>>> ");
                    gradeC=double.Parse(Console.ReadLine());
                    gradeF = gradeC * 1.8 + 32;
                    Console.WriteLine("Rezultatul este {0}",gradeF);
                    break;
                case "2":
                    Console.WriteLine("Va rog introduceti gradele Celsius:\n>>> ");
                    gradeC = double.Parse(Console.ReadLine());
                    gradeK = gradeC + 273.15;
                    Console.WriteLine("Rezultatul este {0}", gradeK);
                    break;
                case "3":
                    Console.WriteLine("Va rog introduceti gradele Farenheit:\n>>> ");
                    gradeF = double.Parse(Console.ReadLine());
                    gradeC = 1.8 * (gradeF - 32);
                    Console.WriteLine("Rezultatul este {0}", gradeC);
                    break;
                case "4":
                    Console.WriteLine("Va rog introduceti gradele Farenheit:\n>>> ");
                    gradeF = double.Parse(Console.ReadLine());
                    gradeK = 1.8 * (gradeF - 32)+273.15;
                    Console.WriteLine("Rezultatul este {0}", gradeK);
                    break;

                case "5":
                    Console.WriteLine("Va rog introduceti gradele Kelvin:\n>>> ");
                    gradeK = double.Parse(Console.ReadLine());
                    gradeC = gradeK - 273.15;
                    Console.WriteLine("Rezultatul este {0}", gradeC);
                    break;
                case "6":
                    Console.WriteLine("Va rog introduceti gradele Kelvin:\n>>> ");
                    gradeK = double.Parse(Console.ReadLine());
                    gradeF = 1.8*(gradeK-273.15)+32;
                    Console.WriteLine("Rezultatul este {0}", gradeK);
                    break;
                default:
                    Console.WriteLine("Input invalid. Incercati din nou: ");
                    p1();
                    break;
            }
        }
        static void p2()
        {
            Console.WriteLine("Alegeti dintre optiuni: ");
            Console.WriteLine("1-Adunare dintre doua numere: ");
            Console.WriteLine("2-Scadere dintre doua numere: ");
            Console.WriteLine("3-Inmultire dintre doua numere: ");
            Console.WriteLine("4-Impartire dintre doua numere: ");
            Console.WriteLine("5-Radical dintr-un numar: ");
            Console.WriteLine("6-Modul dintr-un numar: ");
            Console.Write(">>> ");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    int a, b;
                    Console.WriteLine("Dati valoarea primului numar\n>>> ");
                    a=int.Parse(Console.ReadLine());
                    Console.WriteLine("Dati valoarea pentru al doilea numar\n>>> ");
                    b=int.Parse(Console.ReadLine());
                    Console.WriteLine("Rezultatul este {0}",a+b);
                    break;
                case "2":
                    Console.WriteLine("Dati valoarea primului numar\n>>> ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dati valoarea pentru al doilea numar\n>>> ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Rezultatul este {0}", a - b);
                    break;
                case "3":
                    Console.WriteLine("Dati valoarea primului numar\n>>> ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dati valoarea pentru al doilea numar\n>>> ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Rezultatul este {0}", a*b);
                    break;
                case "4":
                    double x, y;
                    Console.WriteLine("Dati valoarea primului numar\n>>> ");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Dati valoarea pentru al doilea numar\n>>> ");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Rezultatul este {0}", x/y);
                    break;
                case "5":
                    Console.WriteLine("Dati valoarea numarului\n>>> ");
                    x=double.Parse(Console.ReadLine());
                    Console.WriteLine("Rezultatul este {0}",Math.Sqrt(x));
                    break;
                case "6":
                    Console.WriteLine("Dati valoarea numarului\n>>> ");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Rezultatul este {0}", Math.Abs(x));
                    break;
                default: Console.WriteLine("Valore incorecta. Incercati din nou: ");
                    p2();
                    break;
            }
        }
        static void p3()//problema 3
        {
            //declaram i,j,k
            int i, j, k;

            //inputam i,j,k
            Console.Write("Dati valoarea lui i: ");
            i=int.Parse(Console.ReadLine());
            Console.Write("Dati valoarea lui j: ");
            j = int.Parse(Console.ReadLine());
            Console.Write("Dati valoarea lui k: ");
            k = int.Parse(Console.ReadLine());

            //afisam direct rezultat calculului
            Console.WriteLine("Restul impartirii lui {0}^{1} la {2} este {3}",i,j,k,Math.Pow(i,j)%k);
            //folosim readline ca sa nu inchida consola inainte sa afiseze rezultatul
            Console.ReadLine();
        }

        static void p4()
        {
            //declaram n
            int n;
            //inputam n de la tastatura
            Console.WriteLine("Dati valoarea lui ");
            n=int.Parse(Console.ReadLine());

            //declaram suma
            int s = 1;//incepem de la 1 pentru ca 1 este divizorul oricarui numar
            for (int i = 2; i <= n / 2; i++)//parcurgem i-ul pana la jumatatea lui n pentru ca cel mai mic divizor poate sa fie 2
                if (n % i == 0)//daca restul da 0 inseamna ca este divizor al lui n
                    s = s + i;//si atuncea il adaugam in suma
            if(s==n)//verificam daca suma divizilor
                Console.WriteLine("Numarul este perfect");//afisam concluzia
            else//in caz contrar
                Console.WriteLine("Numarul nu este perfect");//nu este perfect

        }

        static bool nr_perfect(int n)//subprogram care verifica daca parametrul n este numar perfect
        {
            int s = 1;//suma o initilializam de la 1 pentru ca 1 este divizorul oricarui numar
            for (int i = 2; i <= n / 2; i++)//verificam pana la n/2 pentru ca acela este cel mai mare divizor al oricarui numar
                if (n % 1 == 0)//daca divide
                    s = s + i;//adaugam la suma
            if (s == n)//verificam daca suma este egal cu numar
                return true;
            return false;
        }
        static void p5()
        {
            //input a 
            int a, b;
            Console.Write("Dati numarul cel mai mic al intervalului deschis: ");
            a=int.Parse(Console.ReadLine());

            //input b
            Console.WriteLine("Dati numarul cel mai mare al intervalului deschis: ");
            b=int.Parse(Console.ReadLine());

            Console.Write("Numerele perfecte din interval sunt: ");
            //verificam fiecare numar incepand de la a si pana la b
            for(int i=a; i<=b; i++)
                if(nr_perfect(i)==true)
                    Console.Write("{0} ",i);
            Console.ReadLine();
        }

        static int suma_div(int n)//subprogram care returneaza suma divizorilor
        {
            int s = 1;
            for(int i = 2; i <= n/2; i++)
                if (n % 1 == 0)
                    s = s + i;
            return s;
        }

        static void p6()
        {
            int a, b;
            Console.Write("Dati numarul cel mai mic al intervalului deschis: ");
            a = int.Parse(Console.ReadLine());


            Console.WriteLine("Dati numarul cel mai mare al intervalului deschis: ");
            b = int.Parse(Console.ReadLine());

            for(int i=a; i<=b; i++)
                for(int j=a; j<=b; j++)
                {
                    if(suma_div(i)==suma_div(j))
                    {
                        Console.Write("O pereche de numere prietene: {0} si {1}",i,j);
                    }
                }
            Console.ReadLine();
        }
        static long factorial(int n)
        {
            if (n > 1)
                return n * factorial(n - 1);
            else return 1;
        }
        static long combinari(int n, int k)
        {
            return factorial(n) / (factorial(k) * factorial(n - k));
        }

        static void p7()
        {
            int n, k;
            Console.WriteLine("Dati valoarea lui n:");
            n=int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoarea lui k:");
            k=int.Parse(Console.ReadLine());

            Console.WriteLine("Combinari de {0} luate cate {1} este {2}",n,k,combinari(n,k));
        }

        static double media_aritmetica_divizori(int a)
        {
            int s = 0;
            int nr = 1;
            for(int i=2; i<=a/2; i++)
                if(a%i==0)
                {
                    s = s + i;
                    nr++;
                }
            return s / nr;
        }

        static double media_geometrica_divizori(int a)
        {
            int n = 0;
            int p = 1;
            for (int i = 2; i <= a / 2; i++)
                if (a % i == 0)
                {
                    p = p * i;
                    n++;
                }
            return Math.Pow(p,1/n);
        }

        static double media_harmonica_divizori(int a)
        {
            int n = 1, suma_div = 0;
            for (int i = 2; i <= a / 2; i++)
                if (a % i == 0)
                {
                    suma_div = suma_div + 1 / i;
                    n++;
                }
            return n / suma_div;
        }
        static void p8()
        {
            int a;
            Console.WriteLine("Dati valorea lui a:");
            a=int.Parse(Console.ReadLine());

            //output dupa metode
            Console.WriteLine("Media aritmetica pentru divizorii lui {0} este {1}",a,media_aritmetica_divizori(a));
            Console.WriteLine("Media geometrica pentru divizorii lui {0} este {1}",a,media_geometrica_divizori(a));
            Console.WriteLine("Media armonica pentru divizorii lui {0} este {1}", a,media_harmonica_divizori(a));
        }

        static void p9()
        {

        }

        static bool verificare_prim(int n)
        {
            if (n % 2 == 0&&n!=2)
                return false;
            else
            {
                bool verificat = true;
                int d = 3;
                while(d<=n/2)
                {
                    if(d%n==0)
                    {
                        verificat = true;
                        break;
                    }
                }
                return verificat;
            }
        }

        static void p10()
        {
            Console.WriteLine("Dati valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
                Console.WriteLine("Nu exista numere prime mai mici");
            else
                for (int i = 2; i <= n; i++)
                    if (verificare_prim(i) == true)
                        Console.WriteLine("{0}", i);
            Console.ReadLine();
        }


        static void p14()
        {
            int input = -1, min = int.MaxValue, max=int.MinValue;
            Console.WriteLine("Dati valori: (0 pentru a inchide)");
            while(input!=0)
            {
                Console.Write(">>> ");
                input= int.Parse(Console.ReadLine());
                if (input == 0)
                    break;
                else
                {
                    if (min > input)
                        min = input;
                    else if (input < max)
                        max = input;
                }

            }
            Console.WriteLine("Valoarea cea mai mica si cea mai mare care a fost data la tastatura sunt {0} respectiv {1}",min,max);
            Console.ReadLine();
        }

        static void p15()
        {
            Console.WriteLine("Dati o valoare: ");
            int n=int.Parse(Console.ReadLine());

            Console.WriteLine("Factorialul lui {0} este {1}",n,factorial(n));
        }

        static void controller()//meniu de alegere intre optiuni
        {
            Console.WriteLine("Alegeti dintre optiuni: ");
            Console.WriteLine("1-Problema 1: ");
            Console.WriteLine("2-Problema 2: ");
            Console.WriteLine("3-Problema 3: ");
            Console.WriteLine("4-Problema 4: ");
            Console.WriteLine("5-Problema 5: ");
            Console.WriteLine("6-Problema 6: ");
            Console.WriteLine("7-Problema 7: ");
            Console.WriteLine("8-Problema 8: ");
            Console.WriteLine("9-Problema 9: ");
            Console.WriteLine("10-Problema 10: ");
            Console.WriteLine("14-Problema 14: ");
            Console.WriteLine("15-Problema 15: ");

            //inputeaza de la user optiunea
            Console.Write(">>>");
            string input = Console.ReadLine();

            //alege conform raspunsului de la user una dintre probleme de la 1 la 60

            switch(input)
            {
                case "1": p1();
                    break;
                case "2":
                    p2();
                    break;
                case "3":
                    p3();
                    break;
                case "4":
                    p4();
                    break;
                case "5":
                    p5();
                    break;
                case "6":
                    p6();
                    break;
                case "7":
                    p7();
                    break;
                case "8":
                    p8();
                    break;
                case "9":
                    p9();
                    break;
                case "10":
                    p10();
                    break;
                case "14":
                    p14();
                    break;
                case "15":
                    p15();
                    break;
                default://daca nu se introduce ceva valid atuncea programul se autoapeleaza, reafisand meniul
                    Console.WriteLine("Ati introdus o valoare incorecta. Incercati din nou");
                    controller();
                    break;
            }    
        }
           
        static void Main(string[] args)
        {
            controller();
        }
    }
}
