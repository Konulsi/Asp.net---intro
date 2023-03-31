using Microsoft.AspNetCore.Mvc;
using System;

namespace Asp.net_intro.Controllers
{
    public class CalculateController : Controller
    {
        //4) Calculate controllerin index action-da fibonacci algoritmasinin cavabini tapib view-a gondermek ve h1-tagi icerisinde gostermek.
        public IActionResult Index()
        {
            int a = 0;
            int b = 1;
            int[] fibNums = new int[10];
            fibNums[0] = a;
            fibNums[1] = b;
            for (int i = 2; i < 10; i++)
            {
                int c = a + b;   // c=0+1= 1 // c=1+1=2 // c=2+1=3  // c=2+3=5
                a = b;  // 1    1   2   3
                b = c;  // 1   2    3   5
                fibNums[i] = c;
            }
            return View(fibNums);

        }
    }
}
