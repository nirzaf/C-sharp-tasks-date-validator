//Develop a solution for validating and converting date values to specific format 

//Design and develop a program that will validate and convert values of a date to the following format: mmmm d, yyyy.(e.g. January 1, 2000)

//Program will accept three inputs from the user: 
//1. Day
//2. Month
//3. Year

using static System.Console;

WriteLine("Please enter the date : ");
int day = Convert.ToInt32(ReadLine());
WriteLine("Please enter the month : ");
int month = Convert.ToInt32(ReadLine());
WriteLine("Please enter the year : ");
int year = Convert.ToInt32(ReadLine());

if(month==2)
{
    if(day>28)
    {
        WriteLine("Invalid date");
    }
    else
    {
        WriteLine("{0}/{1}, {2}", month, day, year);
    }
}
else if(month==4 || month==6 || month==9 || month==11)
{
    if(day>30)
    {
        WriteLine("Invalid date");
    }
    else
    {
        WriteLine("{0} {1}, {2}", month, day, year);
    }
}
else
{
    if(day>31)
    {
        WriteLine("Invalid date");
    }
    else
    {
        WriteLine("{0} {1}, {2}", month, day, year);
    }
}

