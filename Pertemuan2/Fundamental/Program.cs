using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //untuk menulis pesan teks manual
        Console.WriteLine ("Hi");
        
        //string
        string bilangan = "123456";
        Console.WriteLine(bilangan);
        Console.WriteLine("\n");
        
        //var
        var divisi="Game";
        var nama="Afi";
        Console.WriteLine(nama);
        Console.WriteLine(divisi);
        Console.WriteLine("\n");
        
        //constant, jika diganti, program akan error
        const double phi=3.14;//sampai 16 digit
        const float phifloat=3.14f;//7 digit
        Console.WriteLine(phifloat);
        Console.WriteLine(phi);
        Console.WriteLine("\n");
        
        //Tipe data
        //int
        int angka = 0888888;
        float massa = 2.1234567f;
        double massax = 123456.12345678912345;
        Console.WriteLine(angka);
        Console.WriteLine(massa);
        Console.WriteLine(massax);
        Console.WriteLine("\n");
        
        //string
        string namauser = "Yunus";
        string nim = "A11.2022.14341";
        
        Console.WriteLine(namauser + " - " + nim);
        Console.WriteLine("\n");
        
        //Backslash
        string buah = "Apel\tPear\tNanas\rMelon\tSemangka\tPisang";
        Console.WriteLine(buah);
        Console.WriteLine("\n");
        
        //Uppercase Lowercase
        Console.WriteLine(namauser.ToLower());
        Console.WriteLine(namauser.ToUpper());
        Console.WriteLine("panjang string: " + namauser.Length);
        Console.WriteLine("\n");
        
        //String Interpolation
        var date = DateTime.Now;
        Console.WriteLine($"Halo, {nama}! hari ini adalah {date.DayOfWeek}, pukul {date:th:mm} WIB.");
        Console.WriteLine("\n");
        
        //Boolean
        bool bool1=true;
        if (bool1 == false){
            Console.WriteLine("Salah");
        }else{
            Console.WriteLine("Benar");
        }
        
        
        
        Console.WriteLine("\n");
        
        //konversi tipe data
        // string angkastring = (string) angka; salah karena
        // Cannot convert type 'int' to 'string'
        string x = "5";
        string y = "7";
        int convert = (int)massa;
        Console.WriteLine(massa);
        Console.WriteLine(convert);
        Console.WriteLine($"{angka.ToString()}");//int ke string
        int sum = int.Parse(x)+int.Parse(y);//string ke int
        Console.WriteLine(sum);
        Console.WriteLine("\n");
        
        //Operator matika
        Console.WriteLine("Penjumlahan: "+(int.Parse(x)+int.Parse(y)));
        Console.WriteLine("Pengurangan: "+(int.Parse(x)-int.Parse(y)));
        Console.WriteLine("Pembagian: "+(int.Parse(x)/int.Parse(y)));
        Console.WriteLine("Perkalian: "+(int.Parse(x)*int.Parse(y)));
        Console.WriteLine("Modulo: "+(int.Parse(x)%int.Parse(y)));
        Console.WriteLine("Negatif: "+(-int.Parse(x)));
        Console.WriteLine("\n");
        
        
        //increment-decrement
        int bilang = 5;
        Console.WriteLine(bilang++);
        Console.WriteLine(bilang);
        Console.WriteLine(++bilang);
        Console.WriteLine(bilang);
        Console.WriteLine("\n");
        
        //Penugasan
        Console.WriteLine(bilang+=3);
        Console.WriteLine("\n");
        
        //Input
        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Username is: " + userName);

        //Logika
        if(userName.ToLower() == "yunus" && bool1 == true || massa > 2 || bool1 != false){
            Console.WriteLine("Username is: " + userName + " " + bool1 + " " + massa);
        }
        Console.WriteLine("\n");
        
        //Array
        int[] bilanganarr = {1 , 2, 3, 4, 5};
        Console.WriteLine(bilangan[0]);
        Console.WriteLine(bilangan[1]);
        Console.WriteLine(bilangan[2]);
        
        string[] divisibtng = new string[3];
        divisibtng[0] = "web";
        divisibtng[1] = "game";
        divisibtng[2] = "data Analis";
        Console.WriteLine(divisibtng[2]);
        Console.WriteLine("\n");
        
        //Array Multidimensi'
        int[,] arrMulti = new int[2, 4];
        int[,] arrmulti = {{1, 2, 3, 4}, {5, 6, 7, 8}};
        Console.WriteLine(arrmulti[1, 2]);
        Console.WriteLine("\n");
        
        //List
        var profesi = new List<string> {"Dokter", "Guru", "Pilot"};
        for(int i = 0; i < profesi.Count; i++){
            if(i < profesi.Count -1 ){
            Console.Write(profesi[i] + ", ");
            }else{
            Console.Write(profesi[i]);
            }
        }
        Console.WriteLine("\n");
        
        //Switch dan break
        int nilaiswitch = 75;
        switch(nilaiswitch){
            case >75:
                Console.WriteLine("Nilai sempurna");
                break;
            case <= 75:
                Console.WriteLine("Nilai Kurang");
                break;
            default:
                Console.WriteLine("Default");
                break;
        }
        Console.WriteLine("\n");

        //Ternary
        string hasilternary = (nilaiswitch %2 == 0 ) ? "Genap":"Ganjil";
        Console.WriteLine(hasilternary);
        Console.WriteLine("\n");

        //Loop for
        for(int i = 0; i < profesi.Count; i++){
            if(i < profesi.Count -1 ){
            Console.Write(profesi[i] + ", ");
            }else{
            Console.Write(profesi[i]);
            }
        }
        Console.WriteLine("\n");

        //Loop While
        int loopwhile = 3;
        while(loopwhile > 0){
            Console.WriteLine(loopwhile);
            loopwhile--;
        }
        Console.WriteLine("\n");

        //Loop Do While
        do{
            Console.WriteLine(loopwhile);
            loopwhile--;
        }while(loopwhile > 0);
        Console.WriteLine("\n");

        //Loop Foreach
        int[] nilaiforeach = new int[3] { 0, 1, 2};
        foreach(int nilai in nilaiforeach){
            Console.WriteLine(nilai);
        }
        Console.WriteLine("\n");


        
    }
        //Function
    public static void Halo(){
        Console.WriteLine("Halo");
    }
    public static void Halo(string nama){
        Console.WriteLine("Halo " + nama);
    }
}
