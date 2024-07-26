using hesapMakinesi.Data;
using hesapMakinesi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hesapMakinesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBContext _context;

        public HomeController(DBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public class islem1
        {
            public string islem { get; set; }
            public string oprtr { get; set; }
        }

        [HttpPost]
        public IActionResult islemNe([FromBody] islem1 islem)
        {
            double sayi1 = 0;
            double sayi2 = 0;
            string[] asd;
            double sonuc = 0;

            switch (islem.oprtr)
            {
                case "+":
                    asd = islem.islem.Split('+');
                    if (asd.Length <= 1)
                    {
                        return Ok(new { success = false, Message = "Sayilarda bos deger olamaz" });
                    }
                    sayi1 = Convert.ToDouble(asd[0]);
                    sayi2 = Convert.ToDouble(asd[1]);
                    sonuc = Topla(sayi1, sayi2);
                    break;
                case "-":
                    asd = islem.islem.Split('-');
                    if (asd.Length <= 1)
                    {
                        return Ok(new { success = false, Message = "Sayilarda bos deger olamaz" });
                    }
                    sayi1 = Convert.ToDouble(asd[0]);
                    sayi2 = Convert.ToDouble(asd[1]);
                    sonuc = Cikar(sayi1, sayi2);
                    break;
                case "*":
                    asd = islem.islem.Split('*');
                    if (asd.Length <= 1)
                    {
                        return Ok(new { success = false, Message = "Sayilarda bos deger olamaz" });
                    }
                    sayi1 = Convert.ToDouble(asd[0]);
                    sayi2 = Convert.ToDouble(asd[1]);
                    sonuc = Çarp(sayi1, sayi2);
                    break;
                case "/":
                    asd = islem.islem.Split('/');
                    if (asd.Length <= 1)
                    {
                        return Ok(new { success = false, Message = "Sayilarda bos deger olamaz" });
                    }
                    sayi1 = Convert.ToDouble(asd[0]);
                    sayi2 = Convert.ToDouble(asd[1]);
                    sonuc = Böl(sayi1, sayi2);
                    break;
                default:
                    break;
            }

            var yeniSonuc = new Result()
            {
                ad = "HAK3",
                IsActive = true,
                numerusordo = sayi1.ToString(),
                numerusordo2 = sayi2.ToString(),
                sonucdeðeri = Convert.ToDecimal(sonuc)
            };

            _context.Results.Add(yeniSonuc);
            _context.SaveChanges();

            return Ok(new { sonuc = sonuc, success = true });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var results = await _context.Results.ToListAsync();
            return Json(new { data = results });
        }

        private double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        private double Cikar(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }

        private double Çarp(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }

        private double Böl(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }
    }

}
