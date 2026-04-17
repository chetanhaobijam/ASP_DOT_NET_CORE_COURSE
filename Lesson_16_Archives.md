## /Views/Home/Index.cshtml
```html
@{
    ViewData["Title"] = "Index";
    // Layout = "~/Views/Shared/_Layout2.cshtml";
    Layout = null;
}

<h1>Index Page</h1>
<p>This is my Home Page</p>
```

## /Views/Home/About.cshtml
```html
@{
    ViewData["Title"] = "About";
}

<h1>About Page</h1>
<p>This is my About Page</p>
```

## /Views/Home/Contact.cshtml
```html
@{
    ViewData["Title"] = "Contact";
}

<h1>Contact Page</h1>
<p>This is my Contact Us Page</p>
```

## /Views/_ViewStart.cshtml_
```html
@{
    // Layout = "_Layout";

    if(User.IsInRole("Admin"))
    {
        Layout = "_Layout2";
    } else
    {
        Layout = "_Layout";
    }
}
```

## /Views/Shared/_Layout2.cshtml_
```html
<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
</head>
<body>
    <main>
        <h1>Second Layout</h1>  
        @RenderBody()
    </main>
</body>
</html>
```