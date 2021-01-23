using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtitacCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("ihtiyac kredi planı hesaplandı");
        }
    }
}
