using System;
using System.Collections.Generic;

namespace Lab_6
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            FileService f = new FileService();
            int[,] result = f.ReadFile();

            iMatrix matrix = new iMatrix();
            int[,] IMatrix = matrix.createMatrix(f, result);
            iMatrix.printMatrix(IMatrix, f);
            f.WriteFileIncident(IMatrix);

            Console.WriteLine("\n");

            sMatrix sMatrix = new sMatrix();
            int[,] SumMatrix = sMatrix.CreateMatrix(f, result);
            sMatrix.printMatrix(SumMatrix, f);
            f.WriteFileSumij(SumMatrix);
            Console.WriteLine("\n");
            int[,] degs = CharchactGraf.FindInnerAndOut(sMatrix);

            for (int i = 1; i < f.GetN() + 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(degs[i, j] + " ");
                }
                Console.WriteLine();
            }


            //Console.WriteLine("Lab_7");

            //CharchactGraf.isVisyacha(sMatrix, degs);  // 7
            //CharchactGraf.isIsolated(sMatrix, degs);  // 7


            //Console.WriteLine("Lab_8");
            //DFS dfs = new DFS();  // 8
            //dfs.Search(sMatrix, 4);
            //dfs.PrintResult();

            //Console.WriteLine();
            //Console.WriteLine("Lab_9");
            //BFS bfs = new BFS();  // 9
            //bfs.Search(sMatrix, 4);
            //bfs.PrintResult();


            //Console.WriteLine("Lab_10");
            ////10
            //WeightMatrix w = new WeightMatrix();
            //int[,] lab10graph = f.ReadFileWeight();
            //int[,] lab10 = w.CreateMatrix(f, lab10graph);
            //WeightMatrix.printMatrix(lab10, f);
            ////10

            //Console.WriteLine("Lab_11");
            ////11
            //Console.WriteLine();
            //FloydPathMatrix floidlab11 = new FloydPathMatrix(w, lab10);
            ////11
            //Console.WriteLine("Lab_12");
            ////12
            //Console.WriteLine();
            //DeixtraMatrix floidlab12 = new DeixtraMatrix(w, lab10);
            ////12

            //Console.WriteLine("Lab_13");
            ////13
            //int[,] WeightGraph = f.ReadFileWeight();

            //sMatrix sMatrix1 = new sMatrix();
            //int[,] SumMatrix1 = sMatrix1.CreateMatrix(f, WeightGraph);
            //sMatrix.printMatrix(SumMatrix1, f);
            //Console.WriteLine();

            //ColoredGraph graphColor = new ColoredGraph(sMatrix1);
            ////13



            Console.ReadKey();

        }

    }
}
