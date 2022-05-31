using Microsoft.AspNetCore.Mvc;

namespace MvcOdev.Controllers
{
    using Models;
   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Haberler> hbrList = new List<Haberler>();
            hbrList.Add(new Haberler {haberbaslik= "Haber 1 :",kisatext = " C# Prog. dilini öğrendik.Artık c# dilini biliyoruz.",tarih="19.05.22" });
            hbrList.Add(new Haberler {haberbaslik= "Haber 2 :",kisatext = " Sql Server Öğrendik.Hepimiz birer DBA'yiz..",tarih="20.05.22" });
            hbrList.Add(new Haberler {haberbaslik= "Haber 3 :",kisatext = " EF Core Örendik. Artık veritabanı ile sqli bağlıyoruz.",tarih="21.05.22" });
            hbrList.Add(new Haberler {haberbaslik= "Haber 4 :",kisatext = " Ve nihayet webteyiz. Hatta Asp.Net Core öğreneceğiz.",tarih="29.05.22" });
            hbrList.Add(new Haberler {haberbaslik= "Haber 5 :",kisatext = " Hoca dapperda anlatacakmış.",tarih="30.05.22" });
            return View(hbrList);
        }





    }
}
