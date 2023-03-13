using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03hm
{
    class Zavod
    {
        public string name { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public string directorname { get; set; }
        public string place { get; set; }
        public int employees_amount { get; set; }

        public Zavod() { }
        public Zavod(string name, int year, string type, string director_full_name, string adress, int employees_amount)
        {
            this.name = name;
            this.year = year;
            this.type = type;
            this.directorname = directorname;
            this.place = place;
            this.employees_amount = employees_amount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zavod> firmas = new List<Zavod>()
            {
                new Zavod("Honda", 1948, "car", " Toshihiro Mibe", "Japan", 114),
                new Zavod("Nissan", 1933, "car", "Mackota Utida", "Ikogama", 132),
                new Zavod("hyundai", 1967, "car", "jung joo-young", "Seul", 90),
                new Zavod("Adidas", 1996, "clothes", "Adolf Dassler", "German", 12),
                new Zavod("Glovo", 2014, "food", "Jylleck", "Ukraine", 200),
                new Zavod("Bla-Bla-car", 2006, "travel", "Mark Kartman", "Los Angeles", 69)
            };

            #region Информация об о всех заводах
            //var all_firmas = from firma in firmas
            //                 select firma;
            //foreach (var firm in all_firmas)
            //{
            //    Console.WriteLine("{0} ({1})\nType: {2}\nDirector: {3}\nPlace: {4}\nAmount: {5}\n\n", firm.name, firm.date, firm.type, firm.director_full_name, firm.adress, firm.employees_amount);
            //}
            //*/

            //// Метод расширений
            ///*var all_firmas = from firma in firmas
            //                 select firma.name;
            //all_firmas = firmas.Select(f => f.name);
            //foreach (var n in all_firmas) { 
            //    Console.WriteLine(n);
            //}
            #endregion

            #region Завод которой в лондоне 
            //var search_london = from firma in firmas
            //                    where firma.place == "London"
            //                    select firma;
            //foreach (var i in search_london)
            //{
            //    Console.WriteLine("{0} - London", i.name);
            //}
            #endregion

            #region Завод с название food
            //var search_name = from firm in firmas
            //                  where firm.name.Contains("Food")
            //                  select firm;
            //foreach (var firm in search_name)
            //{
            //    Console.WriteLine("{0}", firm.name);
            //}
            #endregion

            #region Заводы в области IT
            //var search_type = from firma in firmas
            //                  where firma.type == "marketing" || firma.type == "it"
            //                  select firma;
            //foreach (var i in search_type)
            //{
            //    Console.WriteLine(i.name);
            //}
            #endregion

            #region Завод в котором более 100 человек
            //var amount_employees = from firma in firmas
            //                       where firma.employees_amount > 100
            //                       select firma;
            //foreach (var i in amount_employees)
            //{
            //    Console.WriteLine(i.name);
            //}
            #endregion

            #region Завод в диапозоне 100-300 человек 
            //var amount_employees = from firma in firmas
            //                       where firma.employees_amount >= 100 && firma.employees_amount <= 300
            //                       select firma;
            //foreach (var i in amount_employees)
            //{
            //    Console.WriteLine(i.name);
            //}
            #endregion

            #region Завод в сфере маркетинга 
            //var search_type = from firma in firmas
            //                  where firma.type == "marketing"
            //                  select firma;
            //foreach (var i in search_type)
            //{
            //    Console.WriteLine(i.name);
            //}
            #endregion

            #region Завод с директором White
            //var search_surname = from firma in firmas
            //                     where firma.directorname.Contains("White")
            //                     select firma;
            //foreach (var i in search_surname)
            //{
            //    Console.WriteLine(i.name);
            //}
            #endregion

            #region Завод с главой Black, и название White
            //var search_director = from firma in firmas
            //                      where firma.directorname.Contains("Black") && firma.name.Contains("White")
            //                      select firma;
            //foreach (var i in search_director)
            //{
            //    Console.WriteLine(i.name);
            //}
            #endregion

            #region Завод который построили 2 года назад
            //var search_firm = from firm in firmas
            //                  where firm.year < 2021
            //                  select firm;
            //foreach (var i in search_firm)
            //{
            //    Console.WriteLine(i.name);
            //}
            #endregion



        }
    }
}