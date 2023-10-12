using System;

namespace OOP//sesuai nama folder yang dibuat pada dotnet new console
{
    class Program//sesuai nama file script
    {  
        static void Main(string[] args)
        {
            Smartphone samsung = new Smartphone();//namaClass namaObjek = new namaClass()
            Smartphone oppo = new Smartphone();

            oppo.detailSmartphone();
            samsung.detailSmartphone();//namaObjek.namaMethod()
            samsung.publicMethod();

            sistemOperasi android = new sistemOperasi();

            android.info();
        }
    }

    class MyClass{
        public void MyMethod(){
            Console.WriteLine("Hello World!");
        }
    }

    class Smartphone{
        string nama = "Samsung";
        string merk = "Galaxy A51";
        string warna = "Biru";
        int harga= 4000000;

        public void inputDetail(){
            Console.Write("Masukkan Nama : ");
            nama = Console.ReadLine();
            Console.Write("Masukkan Merk : ");
            merk = Console.ReadLine();
            Console.Write("Masukkan Warna : ");
            warna = Console.ReadLine();
            Console.Write("Masukkan Harga : ");
            harga = Convert.ToInt32(Console.ReadLine());

            detailSmartphone();
        }
        public void detailSmartphone(){//jika tidak ada script encapsulation, maka otomatis dibuat private
            Console.WriteLine("Nama : "+nama);
            Console.WriteLine("Merk : "+merk);
            Console.WriteLine("Warna : "+warna);
            Console.WriteLine("Harga : "+harga);
        }

        private void privateMethod(){
            Console.WriteLine("Private Method");
        }

        public void publicMethod(){
            privateMethod();//agar bisa dipanggil di class lain
        }
    }

    class sistemOperasi{
        private int versi = 10;
        public string nama = "Android";

        public void info(){
            Console.WriteLine("Versi : "+versi);
            Console.WriteLine("Nama : "+nama);
        }
    }
}