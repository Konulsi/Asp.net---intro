using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace Asp.net_intro.Controllers
{

    //2) Home controllerin index action-da 1-den 20-e kimi ededlerin arasindan tek olanlari secib, viewda h3 taglarinde gostermek.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = { };
  
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    Array.Resize(ref nums, nums.Length + 1);
                    nums[nums.Length - 1] = i;

                }
            }
            return View(nums);
        }


    }
}
