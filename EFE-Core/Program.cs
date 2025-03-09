
using EFE_Core;
using static EFE_Core.ApplicationDbContext;
using System.Linq;
using System.Net.Http.Headers;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;



var _context = new ApplicationDbContext();

var book = _context.Books.SingleOrDefault(b => b.Id == 2);

System.Console.WriteLine(book.Author.Name);

_context.SaveChanges();








//var books = _context.Books
//    .Join
//    (
//        _context.Authors,
//        book => book.AuthorId,
//        author => author.AuthorId,
//        (book, author) => new
//        {
//            BookId = book.BookId,
//            BookName = book.Name,
//            AuthorName = author.Name,
//            AuthorNationalityId = author.NationalityId
//        }
//    )
//    .GroupJoin(
//        _context.Nationalities,
//        book => book.AuthorNationalityId,
//        nationality => nationality.NationalityId,
//        (book, nationality) => new
//        {
//            Book = book,
//            Nationlaity = nationality
//        }
//    )
//    .SelectMany(
//        b => b.Nationlaity.DefaultIfEmpty(),
//        (b, n) => new { b.Book, Nationality = n }
//    );


//foreach(var book in books)
//{
//    Console.WriteLine($"{book.Book.BookId} - {book.Book.BookName} - {book.Book.AuthorName} - {book.Nationality?.Name}");
//}


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





//var stocks = _context.Stocks
//    .GroupBy(m => m.Industry)
//    .Select(m => new { Name = m.Key, StockCount = m.Count(), IdSum = m.Sum(m => m.id) })
//    .OrderByDescending(m => m.StockCount);
//foreach(var stock in stocks)
//{
//    System.Console.WriteLine($"{stock.Name}-- {stock.StockCount}--{stock.IdSum}");
//}
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


//static double ConvertStringToDouble(string input)
//{
//    if (string.IsNullOrWhiteSpace(input))
//        return 0;
//    input = input.Replace("$", "").Trim();

//    double multiplier = 1;
//    if(input.EndsWith("M",StringComparison.OrdinalIgnoreCase))
//    {
//        multiplier = 100_000_000;
//        input = input[..^1];// Remove 'M'
//    }
//    else if (input.EndsWith("K", StringComparison.OrdinalIgnoreCase))
//    {
//        multiplier = 1_000;
//        input = input[..^1]; // Remove 'K'
//    }
//    else if (input.EndsWith("B", StringComparison.OrdinalIgnoreCase))
//    {
//        multiplier = 1_000_000_000;
//        input = input[..^1]; // Remove 'B'
//    }
//    // Try parsing the numeric part
//    if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
//    {
//        return result * multiplier;
//    }
//    return 0;
//}


//using (var _context = new YourDbContext())
//{
//    // Retrieve all stocks
//    var stocks = _context.Stocks.ToList();

//    // Convert balances to double and find the stock with the maximum balance
//    var stockWithMaxBalance = stocks
//        .Select(stock => new
//        {
//            stock.Id,
//            Balance = ConvertToDouble(stock.Balance)
//        })
//        .Where(stock => stock.Balance.HasValue)
//        .OrderByDescending(stock => stock.Balance.Value)
//        .FirstOrDefault();

//    if (stockWithMaxBalance != null)
//    {
//        Console.WriteLine($"Stock ID with max balance: {stockWithMaxBalance.Id}");
//        Console.WriteLine($"Max Balance: {stockWithMaxBalance.Balance.Value}");
//    }
//    else
//    {
//        Console.WriteLine("No valid balances found.");
//    }
//}
