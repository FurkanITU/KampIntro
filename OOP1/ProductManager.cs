﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + "added.");

        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "updated.");
        }
        public int Topla(int sayi1,int sayi2) 
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
