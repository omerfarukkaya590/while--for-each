// See https://aka.ms/new-console-template for more information
class Program
    {
        static void Main(string[] args)
        {
           //While
           //1 den başlayarak console dan ririlen sayı dahil ortalama hesaplayıp console a yazdıran program.
           Console.Write("Lütfen Bir Sayı Giriniz");
           int sayi= int.Parse(Console.ReadLine());
           int sayac=1;
           int toplam =0;
           while (sayac<=sayi)
           {
                toplam+= sayac;
                sayac++;
           }
           Console.WriteLine(toplam/sayi);
           // a 'dan z ye kadartüm harfleri console a yazdıralım
           char character = 'a';
           while (character<'z')
           {
            Console.Write(character);
            character++;
           }
           //for-each
           Console.WriteLine("******For-Each*******");
           string[] arabalar = {"BMW","FORD","NİSSAN","AUDİ"};
           foreach (var araba in arabalar)
           {
            Console.WriteLine(araba);
           }

        }
    }
