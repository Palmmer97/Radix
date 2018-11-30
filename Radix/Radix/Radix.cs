using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix
{
    class Vector
    {
        public int info;
        public int next;
        public Vector()
        {
            info = 0;
            next = 0;
        }
    }
    public class Radix
    {
        int H;
        int[] V;
        
        List<int> V1 = new List<int>
        {
            3,6,9,5,1,4,7,2,1,3
        };
        List<int> V2 = new List<int>
        {
            8, 3, 9, 3, 11, 7, 1, 27, 12
        };
        List<int> V5 = new List<int>
        {
            25, 108, 1024, 12, 351, 251, 39
        };
        public void INSERTAR(int N, int p)
        {
            H = N;
            V = new int[N];
            if (p==1)
            {
               for (int I = 1; I <= N; I++)
               {
                Console.Write("INGRESA LOS NUMEROS ({0}): ", V1[I - 1]);
                V[I - 1] = int.Parse(Console.ReadLine());

               }  
            }
            if (p == 2)
            {
                for (int I = 1; I <= N; I++)
                {
                    Console.Write("INGRESA LOS NUMEROS ({0}): ", V2[I - 1]);
                    V[I - 1] = int.Parse(Console.ReadLine());

                }
            }
            if (p == 5)
            {
                for (int I = 1; I <= N; I++)
                {
                    Console.Write("INGRESA LOS NUMEROS ({0}): ", V5[I - 1]);
                    V[I - 1] = int.Parse(Console.ReadLine());

                }
            }

           
        }
        public void MORTRAR()
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.WriteLine("\t {0}.- {1} ", i + 1, V[i]);
            }
        }
        public void METODORADIX()
        {
            int i, first, n, j, p = 0, expon, y, q, m = 8;
            n = V.Length;
            Vector[] vec = new Vector[50];
            int[] rear = new int[10];
            int[] front = new int[11];
            for (i = 0; i < n; i++)
            {
                vec[i] = new Vector();
                vec[i].info = V[i];
                vec[i].next = i + 1;
            }
            vec[n - 1] = new Vector();
            vec[n - 1].info = V[n - 1];
            vec[n - 1].next = -1;
            first = 0;
            for (int k = 0; k < m; k++)
            {
                for (i = 0; i <= 9; i++)
                {
                    rear[i] = -1;
                }
                for (i = 0; i <= 10; i++)
                {
                    front[i] = -1;
                }
                while (first != -1)
                {
                    p = first;
                    first = vec[first].next;
                    y = vec[p].info;
                    expon = 1;
                    for (i = 0; i != k; i++)
                    {
                        expon = expon * 10;
                    }
                    j = (y / expon) % 10;
                    q = rear[j];
                    if (q == -1)
                    {
                        front[j] = p;
                    }
                    else
                    {
                        vec[q].next = p;
                    }
                    rear[j] = p;
                }
                j = 0;
                p = -1;
                while (j <= 9 && front[j] == -1)
                {
                    j = j + 1;
                }
                first = front[j];
                while (j <= 9)
                {
                    i = j + 1;
                    while (i <= 9 && front[i] == -1)
                    {
                        i++;
                    }
                    if (i <= 9)
                    {
                        p = i;
                        vec[rear[j]].next = front[i];
                    }
                    j = i;
                }
                if (p != -1)
                {
                    vec[rear[p]].next = -1;
                }
            }
            for (i = 0; i < n; i++)
            {
                V[i] = vec[first].info;
                first = vec[first].next;
            }
        }
    }
}
