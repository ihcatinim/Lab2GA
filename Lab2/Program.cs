internal class Program
{
    public static void Main(string[] args)
    {
        //bai2.1



        /*  int m, y;
          Console.Write("nhap thang ban can kiem tra:");
          m = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("nhap vao nam ban can kiem tra:");
          y = Convert.ToInt32(Console.ReadLine());    

         switch(m)
          {
              case 1:
                  Console.WriteLine("thang {0} nam {1} co 31 ngay", m, y);
                  break;
              case 2:
                  if (DateTime.IsLeapYear(y))
                  {
                      Console.WriteLine("thang {0} nam {1} co 28 ngay", m,y);
                      break;
                  }else {
                      Console.WriteLine("thang {0} nam {1} co 28 ngay", m,y);
                      break;
                  }
              case 3:
                  Console.WriteLine("thang {0} nam {1} co 31 ngay", m, y);
                  break;
              case 7:
                  Console.WriteLine("thang {0} nam {1} co 31 ngay", m, y);
                  break;
              case 8:
                  Console.WriteLine("thang {0} nam {1} co 31 ngay", m, y);
                  break;
              case 10:
                  Console.WriteLine("thang {0} nam {1} co 31 ngay", m, y);
                  break; 
              case 12:
                  Console.WriteLine("thang {0} nam {1} co 31 ngay", m, y);
                  break;
              case 4:
                  Console.WriteLine("thang {0} nam {1} co 30 ngay", m, y);
                  break;
              case 6:
                  Console.WriteLine("thang {0} nam {1} co 30 ngay", m, y);
                  break;
              case 9:
                  Console.WriteLine("thang {0} nam {1} co 30 ngay", m, y);
                  break;
              case 11:
                  Console.WriteLine("thang {0} nam {1} co 30 ngay", m, y);
                  break;

          }
      
         
        
                                                    //bai 2.2



        Console.WriteLine("nhap vao so giay can chuyen doi:");
        int n = Convert.ToInt32(Console.ReadLine());

        int h = n / 3600;
        int m = n % 3600 / 60;
        int s = n % 3600 % 60;
        
        Console.WriteLine("\n Sau khi doi tu so giay {0}= {1}:{2}:{3}", n, h, m, s);
        */



        //bai2.3


        /*
        int tong3chusochan = 0;
        for (int i = 100; i <= 999; i++)
        {
            if ((i / 100) % 2 == 0 && ((i % 100) / 10) % 2 == 0 && ((i % 100) % 10) % 2 == 0)
            {
                tong3chusochan += i;

            }
           


        }
        Console.WriteLine("tong 3 so co 3 chu so la chan la:{0}", tong3chusochan);

        */
        //Bai2.4


        /*
        int i, j, bien_dem, so_hang, k;

        Console.Write("\n");
        Console.Write("Ve tam giac sao deu trong C#:\n");
        Console.Write("----------------------------");
        Console.Write("\n\n");

        Console.Write("Nhap so hang: ");
        so_hang = Convert.ToInt32(Console.ReadLine());
        bien_dem = so_hang + 4 - 1;
        for (i = 1; i <= so_hang; i++)
        {
            for (k = bien_dem; k >= 1; k--)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= i; j++)
                Console.Write("* ");
            Console.Write("\n");
            bien_dem--;
        }

        Console.ReadKey();
        */
        //Bai2.5
        /*
        Console.WriteLine("nhap canh cua tam giac:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap canh cua tam giac:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap canh cua tam giac:");
        int c = Convert.ToInt32(Console.ReadLine());    
        if(a +b>c && b + c > a && c+a>b) {
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            {
                Console.WriteLine("tam giac co canh ban vua nhap la tam giac vuong");
            }
             else if (a==b && b == c)
            {
                Console.WriteLine("tam giac deu");
            }
             else if(a==b|| b==c||  c==a)
            {
                Console.WriteLine("tam giac can");
            }
             else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
            {
                Console.WriteLine("tam giac tu");
            }
            else
            {
                Console.WriteLine("tam giac nhon");
            }
        }else
            { 
            Console.WriteLine("khong phai tam giac"); 
            }

        */
        //Bai2.7

        /*
        Console.WriteLine("nhap lai suat nam:");
        double lsn = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("nhap so tien ban gui:");
        int P = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap so thang ban gui:");
        int n = Convert.ToInt32(Console.ReadLine());

        double lst = (lsn / 100)/12;
        //Console.WriteLine(lst);
        double A = P * Math.Pow((1 + lst), n);
        Console.WriteLine(A);
        */

    }
}
