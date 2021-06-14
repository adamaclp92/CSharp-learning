using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendezes
{
    public class Program
    {

        static void Tombfeltoltes(int[] tomb)
        {
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 20);
             
            }
        }

        static void RendezetlenKiiratas(int[] tomb)
        {
            Console.WriteLine("A rendezetlen tömb:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + ", ");
            }
            Console.WriteLine("\n\n");
        }

        static void RendezettKiiratas(int[] tomb)
        {
        
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + ", ");
            }
            Console.WriteLine("\n\n");
        }

        static void KozvetlenRend(int[] tomb)
        {
            Console.WriteLine("Közvetlen rendezés:");
            for (int i = 0; i < tomb.Length-1; i++)
            {
                for (int j = i+1; j < tomb.Length; j++)
                {
                    if (tomb[j] < tomb[i])
                    {
                        int csere = tomb[j];
                        tomb[j] = tomb[i];
                        tomb[i] = csere;
                    }
                }
              
            }

        }

       static void MinRend(int[] tomb)
        {
            Console.WriteLine("Minimumkiválasztásos rendezés:");
            for (int i = 0; i < tomb.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < tomb.Length; j++)
                {
                    if (tomb[j] < tomb[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int csere = tomb[min];
                    tomb[min] = tomb[i];
                    tomb[i] = csere;
                }
            }

        }

        static void Buborek(int[] tomb)
        {
            Console.WriteLine("Buborék rendezés:");
            for (int i = tomb.Length - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (tomb[j] > tomb[j + 1])
                    {
                        int tmp = tomb[j + 1];
                        tomb[j + 1] = tomb[j];
                        tomb[j] = tmp;
                    }

        }

        static void BuborekRendJ2(int[] tomb)
        {
            Console.WriteLine("Buborék javított 2 rendezés:");
            
            int i = tomb.Length - 1;
          
            while (i >= 1)
            {
                int utolsoCsereH = 0;
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        // csere
                       int tmp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = tmp;
                        utolsoCsereH = j;
                    }
                }
                i = utolsoCsereH;
            }
        }

        static void BuborekRendJ1(int[] tomb)
        {
            Console.WriteLine("Buborék javított 1 rendezés:");
            int i;
            int j;
            int tmp;
            bool csere = true;
            for (i = tomb.Length - 1; 0 < i && csere; --i)
            {
                csere = false;
                for (j = 0; j < i; ++j)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        // csere
                        tmp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = tmp;
                        csere = true; // ha volt csere, a változót igazra állítjuk

                    }
                }
            }
        }

        static void BeszuroRend(int[] tomb)
        {
            Console.WriteLine("Beszúró rendezés:");
            
            for (int i = 0; i<tomb.Length-1 ; i++)
            {
                int j = i;
                int x = tomb[i + 1];

                while (j>=0 && tomb[j] > x)
                {
                    tomb[j + 1] = tomb[j];
                    j = j - 1;
                }
                tomb[j + 1] = x;
            }
        }

        static void Shell(int[] tomb)
        {
            Console.WriteLine("Shell rendezés:");
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < tomb.Length; i++)
                {
                    j = i;
                    temp = tomb[i];
                    while ((j >= inc) && (tomb[j - inc] > temp))
                    {
                        tomb[j] = tomb[j - inc];
                        j = j - inc;
                    }
                    tomb[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

       /* static void ShellMin(int[] tomb)
        {
            Console.WriteLine("Shell minimumos rendezés:");
            int i, j, d, c, minH;
            d = tomb.Length;

            do
            {
                d = d / 3 + 1;

                for (int k = 1; k < d; k++)
                {
                    j = k;

                    while (j <= tomb.Length - d)
                    {
                        minH = j;
                        i = j + d;

                        while (i <= tomb.Length)
                        {
                            if (tomb[i-1] < tomb[minH])
                                minH = i;
                            i = i + d;
                        }
                        if (j != minH)
                        {
                            c = tomb[j];
                            tomb[j] = tomb[minH];
                            tomb[minH] = c;
                        }
                        j = j + d;
                    }
                }

            } while (d /!= 1);
        }*/

        static void Osszefuttatas(int[] tomb1, int[] tomb2, int[] tomb3)
        {
            Console.WriteLine("Összefuttatás:");
            int i = 0;
            int j = 0;
            int k = -1;

            while (i < tomb1.Length && j < tomb2.Length)
            {
                k++;
                if (tomb1[i] < tomb2[j])
                {
                    tomb3[k] = tomb1[i];
                    i++;
                }
                else if (tomb1[i] > tomb2[j])
                {
                    tomb3[k] = tomb2[j];
                    j++;
                }
                else
                {
                    tomb3[k] = tomb1[i];
                    k++;
                    i++;
                    tomb3[k] = tomb2[j];
                   
                    j++;
                }


            }

            while (i < tomb1.Length)
            {
                k++;
                tomb3[k] = tomb1[i];
                
                i++;
            }
            while (j < tomb2.Length)
            {
                k++;
                tomb3[k] = tomb2[j];
               
                j++;
            }

        }

        public static void CocktailSort(int[] A)
        {
            Console.WriteLine("Koktél rendezés: ");
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i <= A.Length - 2; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        //test whether the two elements are in the wrong order
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    //we can exit the outer loop here if no swaps occurred.
                    break;
                }
                swapped = false;
                for (int i = A.Length - 2; i >= 0; i--)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swapped = true;
                    }
                }
                //if no elements have been swapped, then the list is sorted
            } while (swapped);
        }

        public  static void Main(string[] args)
        {
            int[] tomb = new int[20];
            Tombfeltoltes(tomb);
            RendezetlenKiiratas(tomb);
            KozvetlenRend(tomb);
            RendezettKiiratas(tomb); 

            int[] tomb2 = new int[20];
            Tombfeltoltes(tomb2);
            RendezetlenKiiratas(tomb2);
            MinRend(tomb2);
            RendezettKiiratas(tomb2);

            int[] tomb5 = new int[20];
            Tombfeltoltes(tomb5);
            RendezetlenKiiratas(tomb5);
            Buborek(tomb5);
            RendezettKiiratas(tomb5);

            int[] tomb3 = new int[20];
            Tombfeltoltes(tomb3);
            RendezetlenKiiratas(tomb3);
            BuborekRendJ1(tomb3);
            RendezettKiiratas(tomb3);

            int[] tomb4 = new int[20];
            Tombfeltoltes(tomb4);
            RendezetlenKiiratas(tomb4);
            BuborekRendJ2(tomb4);
            RendezettKiiratas(tomb4);

           
            int[] tomb6 = new int[20];
            Tombfeltoltes(tomb6);
            RendezetlenKiiratas(tomb6);
            BeszuroRend(tomb6);
            RendezettKiiratas(tomb6);

            int[] tomb7 = new int[20];
            Tombfeltoltes(tomb7);
            RendezetlenKiiratas(tomb7);
            Shell(tomb7);
            RendezettKiiratas(tomb7);

            int[] tomb9 = new int[20];
            Tombfeltoltes(tomb9);
            RendezetlenKiiratas(tomb9);
            CocktailSort(tomb9);
            RendezettKiiratas(tomb9);

            int[] tomb8 = new int[12];
            int[] a = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] b = new int[] { 5, 9, 12, 13, 15, 18 };
            Osszefuttatas(a, b, tomb8);
            RendezettKiiratas(tomb8);

            Console.ReadLine();
            
        }
    }
}
