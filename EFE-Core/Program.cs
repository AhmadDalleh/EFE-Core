
using EFE_Core;
using static EFE_Core.ApplicationDbContext;
using System.Linq;

var _context = new ApplicationDbContext();

var stocks = _context.Stocks.Where(m =>m.id>500).ToList();


foreach (var stock in stocks)
    Console.WriteLine($"ID: {stock.id}: {stock.Name}");
