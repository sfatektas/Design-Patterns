// See https://aka.ms/new-console-template for more information
using SingletonPattern;

var countries = CountryProvider.Instance.GetCountries();

countries.ForEach(x=>Console.WriteLine(x.Defination));


var countries2 = CountryProvider.Instance.GetCountries();

countries2.ForEach(x => Console.WriteLine(x.Defination));
