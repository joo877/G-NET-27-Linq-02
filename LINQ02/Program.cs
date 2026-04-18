 namespace LINQ02;

using LINQ.Models;
using static LINQ.DataSources.Source;

internal class Program
    {
    static void Main(string[] args)
    {

        #region Q01

        //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);


        #endregion

        #region Q02
        //var result = ProductList.Skip(5).Take(5);
        #endregion

        #region Q03
        //var result = ProductList.Where(p => p.UnitPrice < 25).OrderBy(p => p.UnitPrice).Take(5);
        #endregion

        #region Q04
        //var result = ProductList.Where(p => p.Category == "Seafood").All(p=>p.UnitsInStock > 0);
        //Console.WriteLine(result);
        #endregion

        #region Q05
        //int[] ids = { 3, 9, 13, 18 };
        //var result = ids.Contains(9);
        //Console.WriteLine(result);
        #endregion

        #region Q06
        //var result = ProductList.GroupBy(p => p.Category);
        //foreach (var P in result)
        //{
        //    Console.WriteLine($"{P.Key} - Count {P.Count()}");

        //}
        #endregion

        #region Q07
        //var result = ProductList.GroupBy( p => p.Category);
        //foreach (var g in result)
        //{
        //    Console.WriteLine($"{g.Key}");
        //    foreach (var item in g)
        //    {
        //        Console.WriteLine(new { item.ProductName });
        //    }

        //}
        #endregion

        #region Q08
        // var result = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);
        //foreach (var g in result)
        //{
        //    Console.WriteLine($"{g.Key} - Count {g.Count()}");

        //}
        #endregion

        #region Q09
        //var result = from c in CustomerList

        //             group c by c.Country into g
        //             select new
        //             {
        //                 Country = g.Key,
        //                 Count = g.Count(),
        //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))

        //             };
        #endregion

        #region Q10
        //var result = ProductList.Sum(p => p.UnitsInStock);
        //Console.WriteLine(result);
        #endregion

        #region Q11
        //var result01 = ProductList.Max(p => p.UnitPrice);
        //var result02 = ProductList.Min(p => p.UnitPrice);
        //Console.WriteLine($"the CHEAPEST PRODUCT : {result02} - THE MOST EXPENSIVE : {result01}  ");
        #endregion

        #region Q12
        //var result = ProductList.Select(p => p.Category).Distinct();
        #endregion

        #region Q13
        //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        //int[] setB = { 3, 6, 9, 12, 15, 13 };

        //var result = setA.Except(setB);
        #endregion

        #region Q14
        //string[] list1 = { "Germany", "France", "UK", "Spain" };
        //string[] list2 = { "france", "SPAIN", "Italy" };

        //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
        #endregion

        #region Q15
        //var result = ProductList.ToDictionary(p => p.ProductID);
        //Console.WriteLine(result[18]);
        #endregion

        #region Q16
        //var result = ProductList.First(p => p.UnitPrice > 50 );
        //Console.WriteLine( result );
        #endregion

        #region Q17
        //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
        //Console.WriteLine(result);
        #endregion

        #region Q18
     //   var table = Enumerable.Range(1, 10)
     //.Select(i => $"7 x {i} = {7 * i}");
        #endregion

        #region Q19
        //var result = Enumerable.Range(1,30).Where(n => n % 2 == 0);

        #endregion

        #region Q20
        //var result01 = ProductList.Select(p => p.ProductName).Take(3);
        //var result02 = CustomerList.Select(c => c.CompanyName).Take(3);
        //var result = result01.Concat(result02);

        #endregion

        #region Q21
    //    var result = ProductList.Zip(CustomerList,
    //(p, c) => $"({p.ProductName} sold to {c.CompanyName})");
        #endregion
        //foreach (var item in result)

        //    Console.WriteLine(item);
    }
}

