int sonuc = Topla(5, 3);

if (sonuc == 8)
    Console.WriteLine("Test başarılı!");
else
    throw new Exception("Test başarısız!");

static int Topla(int a, int b)
{
    return a + b;
}
