Console.Write("Have you done the first exam1?(1)Yes (2)No: ");
int exam1 = int.Parse(Console.ReadLine()!);

Console.Write("Have you done the second exam2?(1)Yes (2)No:");
int exam2 = int.Parse(Console.ReadLine()!);

Console.Write("Have you done the homework?(1)Yes (2)No:");
int hüpoints = int.Parse(Console.ReadLine()!);

Console.Write("Have you done the oral exam?(1)Yes (2)No:");
int oralexam = int.Parse(Console.ReadLine()!);

int Yes = 1;
int No = 2;
int points1=0;
int points2=0;
int result;
int all=0;
int prozent = 100;
int points;
 

if (exam1 == 1)
{
    Console.Write("How many points have you got?0-20");
     points1 = int.Parse(Console.ReadLine()!);
     all += 20;
}

if (exam2 == 1)
{
    Console.Write("How many points2 have you got?0-20");
     points2 = int.Parse(Console.ReadLine()!);
     all += 20;
}

if (oralexam == 1)
{
    Console.Write("How many points2 have you got?0-20");
     oralexam = int.Parse(Console.ReadLine()!);
     all += 20;
}

points = points1 + points2+hüpoints+oralexam;
result= points/ all*prozent;

if (result >= 89 )
{
    Console.Write("Congratulation you got an 1!");
}
else if (result >= 76) 
{
    Console.Write("Congratulation you got an 2!");
}
else if (result >=63)
{
    Console.Write("Congratulation you got an 3!");
}
else if (result >= 50)
{
    Console.Write("Congratulation you got an 4!");
}
else if (result<= 50)
{
    Console.Write("I am sorry you got an 5.");
}
