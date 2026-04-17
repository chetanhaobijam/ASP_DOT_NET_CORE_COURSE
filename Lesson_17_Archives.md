## Controllers/HomeController.cs
```cs
public IActionResult Index()
{
    ViewData["data1"] = "Chetan Haobijam";
    ViewData["data2"] = "Programmer";
    ViewData["data3"] = DateTime.Now.ToShortDateString();
    string[] arr = { "Sanjay", "Sunny", "Suraj" };
    ViewData["data4"] = arr;

    List<string> names = new List<string> { "Washing", "Swimming", "Bathing" };
    ViewData["data5"] = names;

    return View(); //ViewResult, PartialViewResult, JsonResult, etc.
}
```

## Views/Home/Index.cshtml
```html
<h1>Index Page</h1>
<p>This is my Home Page</p>

@ViewData["data1"]
<br />
@ViewData["data2"]
<br />
@ViewData["data3"]

@{
    foreach (var item in (string[])ViewData["data4"])
    {
        <h2>The name of the person is @item</h2>
    }
}

@{
    foreach (var item in (List<string>)ViewData["data5"])
    {
        <h2>He was @item</h2>
    }
}

```