void parity (int a)
{
    if (a % 2 == 0)
    {
        Console.WriteLine($"Число {a} чётное");
    }
    else
    {
        Console.WriteLine($"Число {a} не чётное");
    }
}
parity(-3);
