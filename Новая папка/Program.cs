// // task1

// int n = Convert.ToInt32(Console.ReadLine());

// int d1 = n % 10;           
// int d2 = n / 10 % 10;      
// int d3 = n / 100 % 10;     
// int d4 = n / 1000 % 10;    
// int d5 = n / 10000 % 10;   

// int jam = d1 + d2 + d3 + d4 + d5;

// int juft = 0;
// int toq = 0;

// if (d1 % 2 == 0) juft++;
// else toq++;
// if (d2 % 2 == 0) juft++;
// else toq++;
// if (d3 % 2 == 0) juft++;
// else toq++;
// if (d4 % 2 == 0) juft++;
// else toq++;
// if (d5 % 2 == 0) juft++;
// else toq++;

// Console.WriteLine("Digit:5");
// Console.WriteLine("Sum:" + jam);
// Console.WriteLine("Even:" + juft);
// Console.WriteLine("Odd:" + toq);
// // //task2
// int a;
// int b;
// a=Convert.ToInt32(Console.ReadLine());
// b=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Add:{a+b}");
// Console.WriteLine($"Subtract:{a-b}");
// Console.WriteLine($"Multiply:{a*b}");
// Console.WriteLine($"Division:{a/b}");
// // task3
// int n = Convert.ToInt32(Console.ReadLine());
// int max=int.MinValue;
// int n1 = n % 10;
// int n2 = n / 10 % 10;
// int n3 = n / 100 % 10;
// int n4 = n / 1000 % 10;

// int min = n1;
// if (n2 < min) min = n2;
// if (n3 < min) min = n3;
// if (n4 < min) min = n4;


// if (n1 > max) max = n1;
// if (n2 > max) max = n2;
// if (n3 > max) max = n3;
// if (n4 > max) max = n4;

// Console.WriteLine(min + " + " + max + " = " + (min + max));
// //task4
// void Pow(int x, int y)
// {
//     int t = 1;
//     for (int i = 0; i < y; i++)
//     {
//         t = t * x;
//     }
//     Console.WriteLine(t);
// }

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// Pow(x, y);
// //task5
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("x = " + y);
// Console.WriteLine("y = " + x);
// //task6

// int x = Convert.ToInt32(Console.ReadLine());
//  for (int i = 1; i <= x; i++)
//     {
//         if (x % i == 0)
//         {
//             Console.Write(i + " ");
//         }
//     }
// //task7
// void array(int[] arr, int value)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] + value;
//     }
// }

// int[] arr = new int[] { 1, 2, 3 };
// array(arr, 5);

// Console.WriteLine("[" + arr[0] + ", " + arr[1] + ", " + arr[2] + "]");

// //task8
// int min=int.MaxValue;

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine());

//     if (a < min) min = a;
//     if (b < min) min = b;
//     if (c < min) min = c;
//     if (d < min) min = d;
   
// System.Console.WriteLine(min);

// //task9

// int max=int.MaxValue;
// int a;
// int b;
//  a = Convert.ToInt32(Console.ReadLine());
//  b = Convert.ToInt32(Console.ReadLine());
// if (a < max) max = a;
// if (b < max) max = b;
// System.Console.WriteLine(max);

//task10
 //int max=int.MinValue;
// int a;
// int b;
//  a = Convert.ToInt32(Console.ReadLine());
//  b = Convert.ToInt32(Console.ReadLine());
// if (a > max) max = a;
// if (b > max) max = b;
// System.Console.WriteLine(max);