using SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    //kullanıcının kendi başına yeni bir nesne oluşturmasını istemiyorsak ve bizim kontrolümüzde tek bir nesne üzerinden hareket etmek istiyorsak bu singelton patterni tercih ederiz.
    public class CountryProvider
    {
        private static CountryProvider _instance;
        //public static CountryProvider Instance => _instance ?? (_instance = new CountryProvider()); // parantez içerisinde bir atama gerçekleştiriliyor ve instance geri döndürülüyor.
        //private CountryProvider() //kullanıcını nesne oluşturmasını engelliyoruz.
        //{
        //    Console.WriteLine(DateTime.Now.ToLongTimeString());
        //    Task.Delay(2000).GetAwaiter().GetResult();
        //}
        public List<Country> GetCountries()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            return new List<Country>
            {
                new Country{Defination= "Turkey"},
                new Country{Defination= "Germany"}
            };
        }

        ///VEYA 

        //static constructor ilgili class ile yapılacak olan ilk işlem neticesinde çalışır dahada çalışmaz.
        static CountryProvider()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Task.Delay(2000).GetAwaiter().GetResult();
            _instance = new CountryProvider();
        }
        public static CountryProvider Instance => _instance;

    }
}