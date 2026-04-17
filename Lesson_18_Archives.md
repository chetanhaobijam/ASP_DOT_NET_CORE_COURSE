## /Controllers/HomeController.cs
```cs
public IActionResult Index()
{
    ViewBag.data1 = "Chetan Haobijam";
    ViewBag.data2 = 35;
    ViewBag.data3 = DateTime.Now.ToShortDateString();

    ViewBag.data4 = new string[] { "Football", "Cricket", "Swimming" };

    ViewBag.data5 = new List<string> { "Vienna", "London", "California" };

    ViewData["data6"] = "Abinash Babumayum";
    
    return View(); //ViewResult, PartialViewResult, JsonResult, etc.
}
```

## /Views/Home/Index.cshtml
```html
<h1>Index Page</h1>
<p>This is my Home Page</p>

<p>My name is @ViewBag.data1 and I am @ViewBag.data2 years old and today's date is @ViewBag.data3 and that other person's name is @ViewBag.data6. My name is again @ViewData["data1"].</p>

<p>
    The name of the sports are:
    @{
        foreach (var item in ViewBag.data4)
        {
            <span>@item</span>
        }
    }
</p>

<p>
    The name of the places are:
    @{
        foreach (var item in ViewBag.data5)
        {
            <span>@item</span>
        }
    }
</p>
```