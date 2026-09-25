using _02_AdatvedelemEsKonstruktorok;

Bankszamla Anna = new Bankszamla("100");
Bankszamla Bela = new Bankszamla("200", 100000, 50000);
Anna.Befizetes(10000);
Bela.Befizetes(20000);
Console.WriteLine($"Anna bankszámla: {Anna.Szamlaszam}, Egyenleg: {Anna.Egyenleg}, Hitelkeret: {Anna.HitelKeret}");
Console.WriteLine($"Bela bankszámla: {Bela.Szamlaszam}, Egyenleg: {Bela.Egyenleg}, Hitelkeret: {Bela.HitelKeret}");