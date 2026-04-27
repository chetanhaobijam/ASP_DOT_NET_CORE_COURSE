## /Controllers/HomeController.cs
```csharp
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Controllers_And_Actions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "Haobijam";
            ViewBag.data2 = "Chetan";
            TempData["data3"] = "Singh";
            TempData["insects"] = new List<string> { "Mosquito", "Cockroach", "Houseful", "Ant"};
            TempData.Keep("data3");
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
        }

        [Route("About")]
        public IActionResult About()
        {
            TempData.Keep("data3");
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            TempData.Keep("data3");
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
            
        }
    }
}
```

## /Views/Home/Index.cshtml
```html
@{
    ViewData["Title"] = "Index";
    // Layout = "~/Views/Shared/_Layout2.cshtml";
    Layout = null; 
}

<h1>Index Page</h1>

<p>Hi, my name is @ViewData["data1"] @ViewBag.data2 @TempData["data3"].</p>

<p>And the insects I hate are:
    @{
        if(TempData["insects"] != null)
        {
            foreach (var item in (List<string>)TempData["insects"])
            {
                <span>@item</span>
            }
        }
        else
        {
            <span>No Data Found and it will never be found.</span>
        }
    }
</p>
```

## /Views/Home/About.cshtml
```html
@{
    ViewData["Title"] = "About";
}

<h1>About Page</h1>
<p>This is my About Page</p>

<p>Hi, my name is @ViewData["data1"] @ViewBag.data2 @TempData["data3"].</p>
```

## /Views/Home/Contact.cshtml
```html
@{
    ViewData["Title"] = "Contact";
}

<h1>Contact Page</h1>
<p>This is my Contact Us Page</p>
@TempData["data3"];
```