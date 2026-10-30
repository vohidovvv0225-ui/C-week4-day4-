class Counter
{
    public int value;

    public Counter(int value)
    {
        this.value = value;
    }

    public void Decrement()
    {
        if (value > 0)
        {
            value--;
        }
    }

    public void Reset()
    {
        value = 0;
    }

    public void PrintValue()
    {
        Console.WriteLine(value);
    }
}
