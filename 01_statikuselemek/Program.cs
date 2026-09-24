using _01_statikuselemek;

Console.WriteLine($"eur to huf: {Valutavalto.EurToHuf(100)}");
Console.WriteLine($"usd to huf: {Valutavalto.UsdToHuf(250)}");
Console.WriteLine($"Total conversions: {Valutavalto.GetOsszesAtvaltas()}");