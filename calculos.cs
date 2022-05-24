using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaDeCalculadora
{
    class calculos
    {
        public static int suma (int x ,int y)
        {
            return x+y;
        }
        public static int resta(int x, int y)
        {
            return x - y;
        }
        public static int mult(int x, int y)
        {
            return x * y;
        }
        public static double div(int x, int y)
        {
            return x / y;
        }
        public static int expo(int x, int y)
        {
            int res =0;
            if (y == 0)
            {
                return res;
            }
            else if (y == 1)
            {
                return x;
            }
            else {
                res = x;
                for (int i = 1; i < y; i++)
                {
                    res = res * x;
                }
            }
            return res; 
        }
        public static double areatri(int x, int y)
        {
            return x * y / 2;
        }
        public static double areaCir(int x) 
        { 
            double res = x*x;
            res = res * 3.14;
            return res;
        }
        public static int periCuadrado(int x) { 
            return 4*x;
        }
        public static int periRect(int x , int y)
        {
            return 2*x + 2*y;
        }
        public static int periTri(int x, int y ,int z)
        {
            return x+y+z;
        }
        public static int periTrap(int x, int y ,int z ,int a)
        {
            return x+y+z+a;
        }
        public static double radio(int x) {
            return x / 2;
        }
    }


}
