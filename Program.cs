class Varios
{
    static void Main()
    {
        /*
        string []estudiantes = new string[5];

        estudiantes[0] = "Denis";
        estudiantes[1] = "Carlos";
        estudiantes[2] = "Maria";
        estudiantes[3] = "Pedro";
        estudiantes[4] = "Jose";

        string[]frutas = new string[] {"Pera","Manzana","Uva"};
        int[] años = new int[] { 2024, 2025, 2026 };
        int index=0;
        double[] notas = new double[5];
        double suma = 0;
        double promedio;
        while (index<5)
        {
            Console.WriteLine("Ingrese la calificación No"+(index+1)+":");
            notas[index] = double.Parse(Console.ReadLine());
            suma=suma+notas[index];
            index++;
        }
        Console.WriteLine("Notas del estudiante:");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Notas:"+notas[i]);
        }
        promedio=suma/notas.Length;
        if (promedio>=60)
        {
            Console.WriteLine("El estudiante está aprobado con un promedio de "+promedio);
        }
        else
        {
            Console.WriteLine("El estudiante está reprobado con un promedio de " + promedio);
        }
        //Imprimir todos los arreglos
        Console.WriteLine("Estudiantes");
        for (int i = 0; i < estudiantes.Length; i++)
        {
            Console.WriteLine("Nombre de estudiante:" + estudiantes[i]);
        }
        Console.WriteLine("Frutas");
        for (int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine("Fruta:"+frutas[i]);
        }
        Console.WriteLine("Años");
        for (int i = 0; i < años.Length; i++)
        {
            Console.WriteLine("Año:"+años[i]);
        }
        
        int [,]matriz=new int[3,3];
        Console.WriteLine("Elementos de la matriz");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Elemento ["+(i+1)+"]["+(j+1)+"]");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Matriz ingresada");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" "+matriz[i,j]);              
            }
            Console.WriteLine();
        }
        */

        int d1, d2, d3, d4;
        int[,,] arreglo3D;

        Console.WriteLine("Digite la primera dimensión");
        d1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la segunda dimensión");
        d2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la tercera dimensión");
        d3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la cuarta dimensión");
        d4 = int.Parse(Console.ReadLine());
        /*
        arreglo3D = new int[d1, d2, d3];
        Console.WriteLine("Elementos del arreglo Tridimensional");
        for (int i = 0; i < d1; i++)
        {
            for (int j = 0; j < d2; j++)
            {
                for (int k = 0; k < d3; k++)
                {
                    Console.WriteLine("Elemento [" + (i + 1) + "][" + (j + 1) + "][" + (k + 1) + "]");
                    arreglo3D[i, j, k] = int.Parse(Console.ReadLine());
                }
            }
        }
        Console.WriteLine("Arreglo 3D ingresado");
        for (int i = 0; i < d1; i++)
        {
            for (int j = 0; j < d2; j++)
            {
                for (int k = 0; k < d3; k++)
                {
                    Console.Write(" " + arreglo3D[i, j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        */
        int suma = 0;
        int mayor = 0, menor = 0;
        int[,,,] arreglo4d = new int[d1, d2, d3, d4];
        Console.WriteLine("Digite los elementos de arreglo de 4 dimensiones");
        for (int i = 0; i < d1; i++)
        {
            for (int j = 0; j < d2; j++)
            {
                for (int k = 0; k < d3; k++)
                {
                    for (int l = 0; l < d4; l++)
                    {
                        Console.WriteLine("Elemento [" + (i + 1) + "][" + (j + 1) + "][" + (k + 1) + "][" + (l + 1) + "]");
                        arreglo4d[i, j, k, l] = int.Parse(Console.ReadLine());
                        suma += arreglo4d[i, j, k, l];
                        if (i == 0 && j == 0 && k == 0 && l == 0)
                        {
                            mayor = arreglo4d[i, j, k, l];
                            menor = arreglo4d[i, j, k, l];
                        }

                        if (arreglo4d[i, j, k, l] < menor)
                        {
                            menor = arreglo4d[i, j, k, l];
                        }
                        if (arreglo4d[i, j, k, l] > mayor)
                        {
                            mayor = arreglo4d[i, j, k, l];
                        }

                    }
                }
            }
        }

        Array.Sort(arreglo4d);
        Console.WriteLine("Elemetos del arreglo de 4 dimensiones");
        for (int i = 0; i < d1; i++)
        {
            for (int j = 0; j < d2; j++)
            {
                for (int k = 0; k < d3; k++)
                {
                    for (int l = 0; l < d4; l++)
                    {
                        Console.WriteLine(" " + arreglo4d[i, j, k, l]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine("Suma de los elementos del arreglo:" + suma);
        Console.WriteLine("El menor numero es:" + menor);
        Console.WriteLine("El mayor numero es:" + mayor);
    }

}