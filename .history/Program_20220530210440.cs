//Develop a solution for validating and converting date values to specific format 

//Design and develop a program that will validate and convert values of a date to the following format: mmmm d, yyyy.(e.g. January 1, 2000)

//Program will accept three inputs from the user: 
//1. Day
//2. Month
//3. Year

using static System.Console;

string date = ReadLine();
string[] dateArray = date.Split('/');

string month = ReadLine();
string day = ReadLine();

