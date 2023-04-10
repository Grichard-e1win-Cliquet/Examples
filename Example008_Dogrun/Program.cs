Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int Friend = 2;
int Time = 0;

while(distance > 10)
{
    if(Friend == 1)
    {
        Time = distance / (firstFriendSpeed + dogSpeed);
        Friend = 2;
    }

    else
    {
        Time = distance / (secondFriendSpeed + dogSpeed);
        Friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * Time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз.");
