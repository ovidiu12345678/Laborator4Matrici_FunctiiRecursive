using System;
namespace Matrice
{
    class Program
    {



        //static void Main(string[] args)


        ////Ex 2
        ////Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
        ////k.Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
        //// Scrieti o functie care va calcula suma elementelor unei astfel de matrici, apelati-o si afisati-i
        ////rezultatul.
        //// Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
        ////rezultatu

        //{
        //    Console.WriteLine("Introduce-ti dimensiunea ! ");

        //    int m = CitireNumere();

        //    int n = CitireNumere();

        //    int k = CitireNumere();



        //    CitireMatrice(m, n, k);


        //    int[,,] matrice3D = CitireMatrice(m, n, k);

        //    int suma = SumaElementeMatrice3D(n, m, k, matrice3D);

        //    int max = MaxElementeMatrice3D(m, n, k, matrice3D);

        //    Console.WriteLine("Suma elementelor obtinute a matricei este : " + suma);

        //    Console.WriteLine("Maximul dintre valorile continute natricei8 generate este : " + max);

        //    AfisareMatrice(n, m, k, matrice3D);
        //}

        //static int CitireNumere()
        //{

        //    return int.Parse(Console.ReadLine());
        //}

        //static int[,,] CitireMatrice(int m, int n, int k)
        //{
        //    int[,,] matrice = new int[n, m, k];


        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            for (int q = 0; q < k; q++)
        //            {
        //                Console.WriteLine("Introduce-ti elementele matricei ! ");

        //                matrice[i, j, q] = int.Parse(Console.ReadLine());
        //            }
        //        }
        //    }

        //    return matrice;
        //}


        //static void AfisareMatrice(int n, int m, int k, int[,,] matrice3D)
        //{
        //    Console.WriteLine("Matrcea generata contine elementele : ");


        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            for (int q = 0; q < k; q++)
        //            {
        //                Console.Write(matrice3D[i, j, q] + " ");
        //            }

        //            Console.Write("");
        //        }

        //        Console.WriteLine();
        //    }
        //}

        //static int SumaElementeMatrice3D(int n, int m, int k, int[,,] matrice3D)
        //{
        //    int suma = 0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            for (int q = 0; q < k; q++)
        //            {
        //                suma += matrice3D[i, j, q];
        //            }
        //        }
        //    }

        //    return suma;
        //}


        //static int MaxElementeMatrice3D(int m, int n, int k, int[,,] matrice3D)
        //{
        //    int max = int.MinValue;

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            for (int q = 0; q < k; q++)
        //            {
        //                max = Math.Max(max, matrice3D[i, j, q]);
        //            }
        //        }
        //    }

        //    return max;
        //}


        //static void Main(string[] args)
        //{
        //    // Exercitii matrici
        //    // Ex 1
        //    //Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura.Scrieti o
        //    //functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatu



        //    Console.WriteLine("Introduce-ti elementele vectoru-lui ! ");

        //    int n = int.Parse(Console.ReadLine());

        //    int[] VectorElemente = new int[n];

        //    InversareElementeVectorIntregi(n, VectorElemente);

        //}

        //static void InversareElementeVectorIntregi(int n, int[] VectorElemente)
        //{

        //    for(int VectorElement = n; VectorElement >= 0; VectorElement--)
        //    {
        //        Console.WriteLine("Vector-ul inversat este format din  elemente : " + VectorElement);
        //    }

        //}




        //static void Main(string[] args)
        //{
        //    // Ex 3 dificultate ridicata
        //    // Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile n m,
        //    //respectiv n, m. Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la
        //    //tastaura.Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
        //    //rezultatul

        //    Console.WriteLine("introduce-ti dimensiunea primei matrice ! ");

        //    int n = int.Parse(Console.ReadLine());

        //    int m = int.Parse(Console.ReadLine());

        //    int[,] matrice = new int[n, m];

        //    Console.WriteLine("introduce-ti dimensiunile ce-a de-a doua matrice ! ");

        //    int k = int.Parse(Console.ReadLine());

        //    int l = int.Parse(Console.ReadLine());

        //    int[,] MatriceB = new int[k, l];


        //    CitirePrimaMatrice(matrice);

        //    AfisarePrimaMatrice(matrice);

        //    CitireMariceaADoua(MatriceB);

        //    AfisareAdouaMatrice(MatriceB);

        //    ProdusulMatricelorRezultate(matrice, MatriceB);



        //}


        //static void CitirePrimaMatrice(int[,] matrice)
        //{
        //    Console.WriteLine("Introduce-ti elementele primei matrice ! ");

        //    for (int i = 0; i < matrice.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrice.GetLength(1); j++)
        //        {
        //            matrice[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //}

        //static void AfisarePrimaMatrice(int[,] matrice)
        //{
        //    Console.WriteLine("Prima matrice contine elementele : ");


        //    for (int i = 0; i < matrice.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrice.GetLength(1); j++)
        //        {
        //            Console.Write(matrice[i, j] + " ");
        //        }

        //        Console.WriteLine(" ");
        //    }

        //    Console.WriteLine();

        //}

        //static void CitireMariceaADoua(int[,] MatriceB)
        //{



        //    Console.WriteLine("Introduce-ti elementele celei de-a doua matrice ! ");



        //    for (int i = 0; i < MatriceB.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < MatriceB.GetLength(1); j++)
        //        {
        //            MatriceB[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //}


        //static void AfisareAdouaMatrice(int[,] MatriceB)
        //{
        //    Console.WriteLine("A doua matrice contine elementele : ");


        //    for (int i = 0; i < MatriceB.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < MatriceB.GetLength(1); j++)
        //        {
        //            Console.Write(MatriceB[i, j] + " ");
        //        }

        //        Console.WriteLine(" ");
        //    }

        //    Console.WriteLine();
        //}

        //static int ProdusulMatricelorRezultate(int[,] matrice, int[,] matriceB)
        //{
        //    int MatriceLine = matrice.GetLength(0);

        //    int MatriceColoana = matrice.GetLength(1);

        //    int MatriceBColoane = matriceB.GetLength(1);


        //    int aux;


        //    int[,] produsMatrice = new int[MatriceLine, MatriceBColoane];

        //    for (int i = 0; i < MatriceLine; i++)
        //    {
        //        for (int j = 0; j < MatriceBColoane; j++)
        //        {
        //            aux = 0;


        //            for (int k = 0; k < MatriceColoana; k++)
        //            {
        //                aux += matrice[i, k] * matriceB[k, j];
        //            }

        //            produsMatrice[i, j] = aux;
        //        }
        //    }
        //    return produsMatrice;

        //}



        //static void Main(string[] args)
        //{
        //    // Ex 5
        //    //Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,
        //    // apelati - o si afisati-i rezultatul.

        //    Console.WriteLine("Introduce-ti de la tastatura valoarea lui n ! ");

        //    int n = int.Parse(Console.ReadLine());

        //    int aux = 0;

        //    int SumaElemente = SumaNumerelorN(n, aux);


        //    Console.WriteLine("Suma elementelor lui n este : " + SumaElemente);
        //}

        //static int SumaNumerelorN(int n, int suma)
        //{
        //    if (n <= 0)
        //    {
        //        return suma;
        //    }

        //    suma += n;

        //    return SumaNumerelorN(n - 1, suma);

        //}



        //        static void Main(string[] args)
        //        {
        //            //Ex 6 dificultate ridicata
        //            //Scrieti o functie recursiva care va calcula al n - lea element din sirul lui
        //            //Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul.


        //            Console.WriteLine("Introduceti numarul dorit de la tastatura ! ");

        //            int numar = Citire();

        //            Console.WriteLine("Elementele din sirul-lui Fibonacii este : " + Fibonacii(numar));
        //        }

        //        static int Citire()
        //        {
        //            int numar = int.Parse(Console.ReadLine());

        //            if(numar <= 0)
        //            {
        //                Console.WriteLine("numarul ales de catre dumneavoastra trebuie sa fie mai mare decat zero {0} ! ");
        //            }

        //            return numar;
        //        }

        //        static int Fibonacii(int n)
        //        {
        //            if(n <= 2)
        //            {
        //                return 1;
        //            }

        //            return Fibonacii(n - 1) + Fibonacii(n - 2);
        //        }
        //    }

        //}

        //        static void Main(string[] args)
        //        {
        //            //Ex 7 dificultate ridicata
        //            //Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va
        //            //afisa urmatoarea piramida a numerelor:
        //            //  1
        //            //  2 2
        //            //  3 3 3
        //            //  4 4 4 4...
        //            //  n n n..... n


        //            Console.WriteLine("Introduceti o cifra n de la tastatura ! ");

        //            int n = int.Parse(Console.ReadLine());

        //            AfisarePiramida(n);
        //        }

        //       static void AfisarePiramida(int n)
        //        {
        //            if(n <= 0)
        //            {
        //                return;
        //            }

        //            string randuri = " ";

        //            for(int i = 0; i < n; i++)
        //            {
        //                randuri += n.ToString();
        //            }

        //            AfisarePiramida(n - 1);

        //            Console.WriteLine(randuri);
        //        }

        //    }

        //}




    }
}