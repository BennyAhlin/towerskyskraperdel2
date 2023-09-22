int realFloor = 114;
int fakeFloors = 0;

for (int count = 1; count <= realFloor + fakeFloors; count++)
{
    if (count % 10 == 4)
    {
        fakeFloors++;
    }
    if (count % 100 == 13)
    {
        fakeFloors++;
    }
}

Console.WriteLine(" you floor is " + (realFloor + fakeFloors));