## /Controllers/HomeController.cs
```cs
using Microsoft.AspNetCore.Mvc;

namespace Controllers_And_Actions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
        }

        public IActionResult About()
        {
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
        }

        public IActionResult Contact()
        {
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
        }

        //Lesson 13 Archives
        //public string DisplayString()
        //{
        //    return "Welcome to my life!";
        //}

        //public int DisplayNumber(int id)
        //{
        //    return id;
        //}
    }
}

```

## /Views/Shared/_Layout.cshtml
```html
<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
</head>
<body>
    <header style="background-color: pink;">
        <h1>Header Portion</h1>
    </header>

    @RenderBody()

    <footer style="background-color: darkcyan; color: #fff;">
        <h1>Footer Portion</h1>
    </footer>
</body>
</html>

```

## /Views/Home/Index.cshtml
```html
@{
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h1>Index Page</h1>
<p>This is my Home Page</p>

```

## /Views/Home/About.cshtml
```html
@{
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h1>About Page</h1>
<p>This is my About Page</p>

```

## /Views/Home/Contact.cshtml
```html
@{
    ViewData["Title"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h1>Contact Page</h1>
<p>This is my Contact Us Page</p>

```