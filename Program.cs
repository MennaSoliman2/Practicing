// See https://aka.ms/new-console-template for more information
				//Reverse a string 
{/* Console.Write("Enter a string: ");
 string name=Console.ReadLine();
 string newstr="";
 for(int i=name.Length-1;i>=0;i--){
	newstr=newstr+name[i];
 }
Console.WriteLine(newstr);*/
//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
				//count for a's
/*Console.Write("Enter a string: ");
 string str=Console.ReadLine();
 int count=0;
for(int i=0;i<str.Length;i++){
	if(str[i]=='a')
	{
		count++;	
	}
		  }
 Console.WriteLine("the count of a is: "+count);*/
//////////////////////////////////////////////////////////////////////////////////////////////////
				//last index of a
/*Console.Write("Enter a string: ");
 string str=Console.ReadLine();
for(int i=str.Length-1;i>=0;i--)
{
	if(str[i]=='a')
	{	Console.WriteLine(i);
		break;
	}else
		continue;
}*/
////////////////////////////////////////////////////////////////////////////////////////////////
				//Remove all a
/*Console.Write("Enter a string: ");
string str=Console.ReadLine();
string newstr="";
for(int i=0;i<str.Length;i++)
{
	if(str[i]!='a')
	{
		newstr=newstr+str[i];
	}    
}
Console.WriteLine(newstr);*/
/////////////////////////////////////////////////////////////////////////////////////////////
				//Add 0 after each a
/*Console.Write("Enter a string: ");
string str=Console.ReadLine();
string newstr="";
for(int i=0;i<str.Length;i++)
{
	        if(str[i]=='a')
		{
			newstr +=str[i]+"0";

		}else
		{
			newstr+=str[i];
		}
}
Console.WriteLine(newstr);*/
/////////////////////////////////////////////////////////////////////////////////////////////
					//count of non-literals
/*Console.Write("Enter a string: ");
string str=Console.ReadLine();
int count=0;
for(int i=0;i<str.Length;i++)
{	if(Char.IsDigit(str[i])||Char.IsPunctuation(str[i]))
	{
		count++;
	}
}
Console.WriteLine(count);*/
//////////////////////////////////////////////////////////////////////////////////////////
					//Is Palindrome	
/*Console.Write("Enter a string: ");
string str=Console.ReadLine();
string newstr="";
for(int i=str.Length-1;i>=0;i--)
{
	newstr=newstr+str[i];
}
if(newstr==str)
{
	Console.WriteLine("Is Palindrome!");
}else
{
	Console.WriteLine("Not Palindrome");
}*/
///////////////////////////////////////////////////////////////////////////////////////////
					//Remove Duplicate
/*Console.Write("Enter a string: ");
string str=Console.ReadLine();
string newstr="";
for(int i=0;i<str.Length;i++)
{
	if(!newstr.Contains(str[i]))
	{
		newstr+=str[i];
	}
}
Console.WriteLine(newstr);*/
//////////////////////////////////////////////////////////////////////////////////////////////
					//Earliest Nearest value from Mean













}
