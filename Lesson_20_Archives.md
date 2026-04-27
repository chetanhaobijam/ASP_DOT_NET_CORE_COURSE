## /Models/StudentModel.cs
```csharp
namespace Models_In_ASP_Core.Models
{
    public class StudentModel
    {
        public int rollNo { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Standard { get; set; }
    }
}

```

## /Controllers/StudentController.cs
```csharp
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Models_In_ASP_Core.Models;

namespace Models_In_ASP_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var students = new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Alice", Gender = "Female", Standard = 10 },
                new StudentModel { rollNo = 2, Name = "Bob", Gender = "Male", Standard = 9 },
                new StudentModel { rollNo = 3, Name = "Charlie", Gender = "Male", Standard = 8 }
            };
            ViewData["myStudents"] = students;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
```

## /Views/Home/Index.cshtml
```html
@{
    ViewData["Title"] = "Home Page";
    var students = ViewData["myStudents"] as List<StudentModel>;
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>

<table>
    <tr>
        <th>Roll No</th>
        <th>Name</th>
        <th>Gender</th>
        <th>Standard</th>
    </tr>
    @foreach (var student in students)
    {
        <tr>
            <td>@student.rollNo</td>
            <td>@student.Name</td>
            <td>@student.Gender</td>
            <td>@student.Standard</td>
        </tr>
    }
</table>

```