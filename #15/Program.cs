﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int COL = 0;
            int FI = 0;
            string cadena;
            Console.Write("Cuantas Filas: ");
            cadena= Console.ReadLine();
            N = int.Parse(cadena);
            int[,] MAT = new int[N + 1, N + 1];
            for (F = 1; F <= N; F++)
            {
            for (C = 1; C <= N; C++)
            {
            if (((C == 1) | (F == C)))
            {
            MAT[F, C] = 1;
            }
            else
            {
            MAT[F, C] = MAT[F - 1, C] + MAT[F - 1, C - 1];
            }
            }
            }
            FI = 2;
            for (F = 1; F <= N; F++)
            {
            COL = 40 - (F * 2);
            for (C = 1; C <= N; C++)
            {
            if ((MAT[F, C] != 0))
            {
            Console.SetCursorPosition(COL, FI);
            Console.Write(MAT[F, C]);
            COL = COL + 4;
            }
            }
            FI = FI + 1;
            Console.WriteLine();
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}

