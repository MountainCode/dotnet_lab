using System.Resources;

string day;
string year;
string holiday;
string celebrate = "{0} will occur on {1} in {2}.\n";

var rm = new ResourceManager("rmc", typeof(Program).Assembly);

Console.WriteLine("Obtain resources using the current UI culture.");

day = rm.GetString("day");
year = rm.GetString("year");
holiday = rm.GetString("holiday");
Console.WriteLine(celebrate, holiday, day, year);
