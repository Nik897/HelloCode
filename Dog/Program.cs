int count = 0, friend = 2,
    firstFriendSpeed = 1, secondFriendSpeed = 2,
    dogSpeed = 5;
 double time = 1, distance = 10000;   

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance -= (firstFriendSpeed + secondFriendSpeed ) * time;
    count++;
}  
Console.Write("Собака пробежит ");
Console.Write(count);  
Console.Write(" раз.");