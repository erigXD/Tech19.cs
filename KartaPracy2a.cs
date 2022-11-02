using System;

class Program {
  public static void Main (string[] args) {
    int a,b,c,d,g,k,l,m;
            //zad1
    
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            if ((a + b) % 2 == 0) {
              System.Console.WriteLine("TAK"); 
            }
            else {
              System.Console.WriteLine("NIE");
            }

            //zad2
    
            a = int.Parse(System.Console.ReadLine());
            g = int.Parse(System.Console.ReadLine());
            if ((a + g)/ 2 > Math.Sqrt(a * g)) {
              System.Console.WriteLine("TAK");
            }                            
            else {
              System.Console.WriteLine("NIE");
            }
                  

            //zad3
    
            k = int.Parse(System.Console.ReadLine());
            l = int.Parse(System.Console.ReadLine());
            m = int.Parse(System.Console.ReadLine());
                if (k == l && k == m && l == m) {
                  System.Console.WriteLine("NIE, wszystkie liczby są równe");
                }
                else 
                  if (k == l) 
                    System.Console.WriteLine("Są to k i l");
                else 
                  if (k == m) 
                    System.Console.WriteLine("Są to k i m");
                else 
                  if (l == m) 
                    System.Console.WriteLine("Są to l i m");
              else 
                System.Console.WriteLine("NIE");

            //zad4
    
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            d = int.Parse(System.Console.ReadLine());
            if (a < b && a < c && a < d) 
              System.Console.WriteLine("Najmniejsza to " + a);
            else 
              if (b < a && b < c && b < d) 
                System.Console.WriteLine("Najmniejsza to " + b);
            else 
              if (c < b && c < a && c < d) 
                System.Console.WriteLine("Najmniejsza to " + c);
            else 
              if (d < b && d < c && d < a) 
                System.Console.WriteLine("Najmniejsza to " + d);
            else 
              System.Console.WriteLine("Jest kilka najmniejszych liczb");
            
            //zad5
    
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            if (b - c < a && a < b + c || a - c < b && b < a + c || a - b < c && c < a + b)
            { 
                System.Console.WriteLine("TAK");
            }
            else System.Console.WriteLine("NIE");

            //zad6
    
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                System.Console.WriteLine("Da się zbudować trójkąt");
                if (a*a + b*b == c*c || b*b + c*c == a*a || c*c + a*a == b*b)
                {
                    System.Console.WriteLine("Prostokątny");
                }
                else 
                  if (a*a + b*b < c*c || b*b + c*c < a*a || c*c + a*a < b*b)
                {
                    System.Console.WriteLine("Rozwartokątny");
                }
                else 
                  if (a*a + b*b > c*c || b*b + c*c > a*a || c*c + a*a > b*b)
                {
                    System.Console.WriteLine("Ostrokątny");
                }
            }
            else 
              System.Console.WriteLine("Nie da się zbudować trójkątu");
  
  }
}
