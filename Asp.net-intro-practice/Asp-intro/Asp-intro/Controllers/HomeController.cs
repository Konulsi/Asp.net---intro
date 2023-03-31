using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class HomeController : Controller
    {

        //bu interface vasitesile geriye view qaytarirsan
        public IActionResult Index()
        {
            int[] nums = {1,2,3,5,6,7};
            return View(nums);   //view hazir metoddur IactionResult a gore ishleyir

        }


















        //index burada actiondur
        //public string Index(int id)
        //{
        //    //return GetName();


        //    //burada yoxlayiriq eger id 0-a beraberdirse return ele "aqshin"-in ozunu.metodu dayandiracaq.
        //    //eks halda if e girmeyecek
        //    if (id == 0)
        //    {
        //        return "Aqshin";
        //    }
        //    return "Aqshin - " + id;
        //}



        //burada id evezine slug ile axtraiw edirikse bele yazilir
        //public string Detail(string slug, string name)
        //{
        //    return slug + " " + name;
        //}






        //adi metod yaradib index actionunda chagirib ishlede bilerik
        //private string GetName()
        //{
        //    return "Aqshin";
        //}

    }
}
