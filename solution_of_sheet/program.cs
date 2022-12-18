// C# program to calculate the perimeter of Circle
 using System;
 class Program {
	static void Main(string[] args) {
        //  double r,per;
        //  double PI = 3.14;
        //  Console.WriteLine("Input the radius of the circle:");
        //  r = Convert.ToDouble(Console.ReadLine());
        // per = 2 * PI * r;
        // Console.WriteLine("Perimeter of Circle : {0}", per);
//////////////////////////////////////////////////////////////////////////////////
        // C# program to calculate the perimeter of Rectangle

        // Console.Write("Enter the value of length : ");
        // double Length = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Enter the value of width : ");
        // double Width = Convert.ToDouble(Console.ReadLine());
        // double Perimeter = 2 * (Length + Width);
        // Console.Write("Perimeter of Rectangle is: " + Perimeter);
        // Console.ReadLine();
///////////////////////////////////////////////////////////////////////////////////////////////////
        // C# program to check given strings are equal or not using equal to (==) operator

    //     Console.Write("Enter the first string : ");
    //     string str1 = Console.ReadLine();
    //     Console.Write("Enter the second string : ");
    //     string str2 = Console.ReadLine();
    //     if(str1==str2)
    //     Console.Write("equal");
    //   else
    //     Console.Write("Not equal");
//////////////////////////////////////////////////////////////////////////////////////////////////////////
// 4. C# program to input weekday number and print the weekday

//    Console.Write("Enter the weekday number : ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         switch(num){
//           case 1:
//              Console.Write("Sunday");
//             break;
//           case 2:
//              Console.Write("Monday");
//             break;
//             case 3:
//              Console.Write("Tuesday");
//             break;
//             case 4:
//              Console.Write("Wednesday");
//             break;
//             case 5:
//              Console.Write("Thursday");
//             break;
//             case 6:
//              Console.Write("Friday");
//             break;
//             case 7:
//              Console.Write("Saturday");
//             break;
//           default:
//             Console.Write("error");
//             break;
//         }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       
			int balance=10000,a,current,pass=4040,pass1,pass2;

			//read pass
			Console.WriteLine("Enter the pass");
			pass1=int.Parse(Console.ReadLine());

			//compare pass
			if(pass1==pass)
			{
				Console.WriteLine("1.To check balance");
				Console.WriteLine("2.To withdraw money");
				Console.WriteLine("3.To deposite Money");
				Console.WriteLine("4.To change the pass");
				Console.WriteLine("Enter your choice");
				int ch=int.Parse(Console.ReadLine());
				switch(ch)
				{
					case 1:
						Console.WriteLine("The current balance in your account is"+balance);
					break;
					
					case 2:
					Console.WriteLine("Enter the amount to withdraw");
					{
						a=int.Parse(Console.ReadLine());
						if(balance>=a)
						{
							if(a%100==0)
							{
								Console.WriteLine("Please collect the cash"+a);
								current=balance-a;
								Console.WriteLine("The current balance is now"+current);
							}
							else
								Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
						}
						else
						Console.WriteLine("Your account does not have sufficient balance");
					}

					break;

					case 3:
					Console.WriteLine("Enter the amount to be deposite");
					a=int.Parse(Console.ReadLine());
					current=balance+a;
					Console.WriteLine("The current balance in the account is"+current);
					break;
					
					case 4:
					Console.WriteLine("Want to change your pass");
					Console.WriteLine("Enter your previous pass");
					int prepass=int.Parse(Console.ReadLine());
					if(prepass==pass)
					{
						Console.WriteLine("Enter your new pass");
						pass2=int.Parse(Console.ReadLine());
						pass1=pass2;
						Console.WriteLine("Your pass is changed");
					}
					else
						Console.WriteLine("Enter your correct pass");
					break;
					
					default:
					Console.WriteLine("Please select correct option");
					break;
				}
			}
			else
				Console.WriteLine("pass is wrong");
		}
	}

            

    
    

