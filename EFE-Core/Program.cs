
using EFE_Core;
using static EFE_Core.ApplicationDbContext;
using System.Linq;
using System.Net.Http.Headers;
using System.Diagnostics.Metrics;


var _context = new ApplicationDbContext();

//var stocks = GetData(0, 20);

var stocks = _context.Stocks
    .GroupBy(m => m.Industry)
    .Select(m => new { Name = m.Key, StockCount = m.Count(), IdSum = m.Sum(m => m.id) })
    .OrderByDescending(m => m.StockCount);
foreach(var stock in stocks)
{
    System.Console.WriteLine($"{stock.Name}-- {stock.StockCount}--{stock.IdSum}");
}
//static void SeedData()
//{
//    using var _context = new ApplicationDbContext();
//    _context.Database.EnsureCreated();
//    var blog = _context.Blogs.FirstOrDefault(b => b.Url == "www.google.com");
//    if (blog == null)
//    {
//        _context.Blogs.Add(new Blog { Name = "Test1", Url = "www.google.com" });
//        _context.Blogs.Add(new Blog { Name = "Test2", Url = "www.youtube.com" });
//        _context.Blogs.Add(new Blog { Name = "Test3", Url = "www.facebook.com" });
//        _context.Blogs.Add(new Blog { Name = "Test4", Url = "www.github.com" });
//    }
//    _context.SaveChanges();
//}

//static List<Stock> GetData(int pageNumber, int pageSize)
//{
//    var _context = new ApplicationDbContext();

//    return _context.Stocks.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
//}