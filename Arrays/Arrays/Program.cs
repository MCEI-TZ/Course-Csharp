using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Simple
            int[] numArray = new int[5];

            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;

            // Use of leng for know how many data have the array
            Console.WriteLine(numArray.Length);

            // Array defineted

            int[] numArray2 = { 13, 12, 32, 32, 32, 34, 324, 23 };

            // Another way
            int[] numArray3 = new int[] { 13, 12, 32, 32, 32, 34, 324, 23 };

            // Loop for each
            foreach (var item in numArray3)
            {
                Console.WriteLine(item);
            }

            // Matrix (Arrays of Arrays)
            // Array 2D
            int[,] matrix2d = new int[,] { { 1, 2, 3, 4, 5, 6, 8 }, { 9, 2, 3, 4, 2, 1, 2 } };

            for (int i = 0; i < matrix2d.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2d.GetLength(1); j++)
                {
                    Console.WriteLine("{0}{1} = {2}", i, j, matrix2d[i, j]);
                }
            }

            Console.WriteLine("=======================================================================");
            //Array 3D
            int[,,] matrix3d = new int[,,] { { { 1, 2, 3, 4, 5, 6, 8 }, { 1, 2, 3, 4, 5, 6, 8 } }, { { 1, 2, 3, 4, 5, 6, 8 }, { 1, 2, 3, 4, 5, 6, 8 } } };

            for (int i = 0; i < matrix3d.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3d.GetLength(1); j++)
                {
                    for (global::System.Int32 k = 0; k < matrix3d.GetLength(2); k++)
                    {
                        Console.WriteLine("{0}{1}{2} = {3}", i, j, k, matrix3d[i, j, k]);

                    }
                }
            }

            // ------------------------------------------------------------
            // Iregular Array
            // First way to declare an irregular array
            int[][] iregular = new int[3][];
            iregular[0] = new int[5];
            iregular[1] = new int[3];
            iregular[2] = new int[2];

            iregular[0] = new int[] { 1, 2, 3, 4, 5 };
            iregular[1] = new int[] { 2, 1 };
            iregular[2] = new int[] { 3, 2 };
            // Second way to declare an irregular array
            int[][] jregular = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 2, 1 },
                new int[] { 3, 2 }
            };

            Console.WriteLine("-------------------------------------------------");
            // print the iregulardata
            for (int i = 0; i < jregular.Length; i++)
            {
                for (int j = 0; j < jregular[i].Length; j++)
                {
                    Console.WriteLine("{0}{1} = {1}", i, j, jregular[i][j]);
                }

            }

            // ---------------------------------------------------------------------
            // Array List Example
            Console.WriteLine("-------------------------------------------------");
            ArrayList arrayList = new ArrayList();
            // Adding elements to the arraylist
            arrayList.Add("Hola");
            arrayList.Add(1);
            arrayList.Add(true);
            arrayList.Add(false);

            // Count how many elements have the arraylist
            Console.WriteLine(arrayList.Count);

            // Removing an element from the arrayList
            arrayList.Remove(false);

            // Removing by an index
            arrayList.RemoveAt(0);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
