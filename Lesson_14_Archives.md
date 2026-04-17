## /Views/Home/Index.cshtml
```html

@{
    ViewData["Title"] = "Index";
}

<h1>Hello All. Today is @DateTime.Now</h1>

@{
    var slNo = 1;
    var firstName = "Chetan";
    var lastName = "Haobijam";
    var occupation = "Programmer";
    var status = "Active";
}

<table>
    <thead>
        <tr>
            <th>Sl. No.</th>
            <th>Name</th>
            <th>Occupation</th>
            <th>Status</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>@slNo</td>
            <td>@firstName @lastName</td>
            <td>@occupation</td>
            <td>@status</td>
        </tr>
    </tbody>
</table>

@{
    var quantity = 20;

    if(quantity.Equals(30))
    {
        <h2>Perfect and Equal Quantity!</h2>
    } else
    {
        <h2>Bad quantity</h2>
    }
}


@{
    for (var i = 0; i < 10; i++)
    {
        <h2>Hello World</h2>
    }
}

@{
    string[] fruits = { "Apple", "Mango", "Papaya", "Pomegranate", "Pineapple" };

    foreach(var item in fruits)
    {
        <h3>I love @item</h3>;
    }
}

@{
    string[] names = { "Chetan", "Rahul", "Aman" };
    var counter = 1;
}


<table>
    <tr>
        <th>Sl. No.</th>
        <th>Names</th>
    </tr>
    @{
        foreach(var item in names)
        {
            <tr>
                <td>@counter</td>
                <td>@item</td>
            </tr>
            counter++;
        }
    }
</table>

```