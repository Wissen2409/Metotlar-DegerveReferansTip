// Değer tip ve Referans tip kavramı : 

// .Net içerisinde, bazı tipler değerli tipli bazıları ise, referans tiplidir.

// Değer tip ve referans tipli olan değişkenler, bellekte duruş şekilleri olarak bir birlerinden ayrılırlar

// Bellekte(RAM) 2 ana bölge üzerinden değer tip ve referans tip konusunu konuşulabilir

// Değer tipli değişkenler, belleğin STACK bölgesinde yer alırlar

// 



// bir tane int tipinden değişken 
int a =10;

// Ekrana yazdıralım
Console.WriteLine(a); // 10  10

// Değer değiştir metoduna parametre olarak gönderdik
IntDegistir(a);

// ve tekrar ekrana yazdırdık
Console.WriteLine(a); // 11  10

// bir tane string tipinden dizimiz var
string[] isimler ={"ayşe","fatma","ali","veli","mustafa","hikmet"};
// Dizinin sıfırıncı elemanını ekrana yazdırdık
Console.WriteLine(isimler[0]);  // ayşe  

//DEgistir metoduna gönderdik 
DiziDegistir(isimler);

// Ve tekrar ekrana yazdırdık
Console.WriteLine(isimler[0]);  // değiştirilmiştir. 

static void IntDegistir(int degisken){

    degisken=11;
}
static void DiziDegistir(string[] dizi){

    dizi[0]="Değiştirilmiştir";
}
