using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention 
        // syntax
        public void Ekle(Product urun) 
        {
            Console.WriteLine("Tebrikler Sepete eklendi: " + urun.Adi);
            
        }
        public void Ekle2(string urunadi,string aciklama,int fiyat,int stokAdedi) 
        {
            Console.WriteLine("eklene ürün :" + urunadi);
        }
    }
}
