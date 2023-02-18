

string KategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = false;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("azalış butonu");
}
else if (dolarDun<dolarBugun) 
{
    Console.WriteLine("artış butonu");
}
else 
{
    Console.WriteLine("eşittir butonu");
}


if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı Ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

Console.WriteLine(KategoriEtiketi); 